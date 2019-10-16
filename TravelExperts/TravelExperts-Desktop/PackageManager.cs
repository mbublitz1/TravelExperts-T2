using Data.Core.Models;
using Data.Core.Repository;
using Data.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts_Desktop
{
    public partial class PackageManager : Form
    {
        Package data;
        public PackageManager()
        {
            InitializeComponent();
        }
        public void RefreshData()
        {
            TravelWinRepository packages = new TravelWinRepository();
            gridPackages.DataSource = packages.GetPackages();
            int selectedPackage = Convert.ToInt32(gridPackages.CurrentRow.Cells["PackageId"].Value);
            gridProducts.DataSource = packages.GetProducts(selectedPackage);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TravelWinRepository packages = new TravelWinRepository();
            gridPackages.DataSource = packages.GetPackages();
            int selectedPackage = Convert.ToInt32(gridPackages.CurrentRow.Cells["PackageId"].Value);
            gridProducts.DataSource = packages.GetProducts(selectedPackage);
            AddPackage.callRefreshData += RefreshData;
            UpdatePackage.callRefreshData += RefreshData;

            for (int i = 0; i < gridPackages.RowCount; i++)
            {
                if (Convert.ToBoolean(gridPackages.Rows[i].Cells["Expired"].Value))
                {
                    gridPackages.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void GridPackages_SelectionChanged(object sender, EventArgs e)
        {
            TravelWinRepository package = new TravelWinRepository();
            int selectedPackage = Convert.ToInt32(gridPackages.CurrentRow.Cells["PackageId"].Value);
            data = package.GetSinglePackage(selectedPackage);
            lblPackageName.Text = data.PkgName;
            lblDesc.Text = data.PkgDesc;

            /*************************************************
            
            Causes a null value to be applied and I don't know why

            txtStartDate.Text = data.PkgStartDate.Value.Date.ToShortDateString();
            txtEndDate.Text = data.PkgEndDate.Value.Date.ToShortDateString();

            *************************************************/
            txtStartDate.Text = data.PkgStartDate.ToString();
            txtEndDate.Text = data.PkgEndDate.ToString();
            txtBasePrice.Text = data.PkgBasePrice.ToString("c");
            txtCommission.Text = Convert.ToDouble(data.PkgAgencyCommission).ToString("c");
            gridProducts.DataSource = package.GetProducts(selectedPackage);
            string image = ConfigurationManager.AppSettings["PathToProject"] + data.PackageImageLocation;
            try
            {
                //pbImage.Image = Image.FromFile(image);
                pbImage.Load(image);
            }
            catch
            {
                PictureBox errorPic = new PictureBox();
                //pbImage.Size = ;
                pbImage.Image = errorPic.ErrorImage;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete " + lblPackageName.Text + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TravelWinRepository package = new TravelWinRepository();
                int selectedPackage = Convert.ToInt32(gridPackages.CurrentRow.Cells["PackageId"].Value);
                package.DeletePackage(selectedPackage);
                gridPackages.DataSource = package.GetPackages();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPackage AddPkgManager = new AddPackage();
            AddPkgManager.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int PackageId = data.PackageId;
            string PkgName = data.PkgName;
            DateTime PkgStartDate = Convert.ToDateTime(data.PkgStartDate);
            DateTime PkgEndDate = Convert.ToDateTime(data.PkgEndDate);
            string PkgDesc = data.PkgDesc;
            decimal PkgBasePrice = data.PkgBasePrice;
            decimal PkgAgencyCommission = Convert.ToDecimal(data.PkgAgencyCommission);
            string PackageImageLocation = data.PackageImageLocation;

            UpdatePackage UpdatePkgManager = new UpdatePackage(PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PackageImageLocation);
            UpdatePkgManager.Show();
        }
    }
}
