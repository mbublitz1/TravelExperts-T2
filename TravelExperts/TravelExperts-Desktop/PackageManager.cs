using Data.Core.Repository;
using Data.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts_Desktop
{
    public partial class PackageManager : Form
    {

        public PackageManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TravelWinRepository packages = new TravelWinRepository();
            gridPackages.DataSource = packages.GetPackages();
            int selectedPackage = Convert.ToInt32(gridPackages.CurrentRow.Cells["PackageId"].Value);
            gridProducts.DataSource = packages.GetProducts(selectedPackage);
        }

        private void GridPackages_SelectionChanged(object sender, EventArgs e)
        {
            TravelWinRepository package = new TravelWinRepository();
            int selectedPackage = Convert.ToInt32(gridPackages.CurrentRow.Cells["PackageId"].Value);
            var data = package.GetSinglePackage(selectedPackage);
            lblPackageName.Text = data.PkgName;
            lblDesc.Text = data.PkgDesc;
            txtStartDate.Text = data.PkgStartDate.Value.Date.ToShortDateString();
            txtEndDate.Text = data.PkgEndDate.Value.Date.ToShortDateString();
            txtBasePrice.Text = data.PkgBasePrice.ToString("c");
            txtCommission.Text = Convert.ToDouble(data.PkgAgencyCommission).ToString("c");
            gridProducts.DataSource = package.GetProducts(selectedPackage);
            string image = @"C:\Users\John\Documents\GitHub\TravelExperts-T2\TravelExperts\TravelExperts" + data.PackageImageLocation;
            try
            {
                pbImage.Image = Image.FromFile(image);
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
            string PkgName = lblPackageName.Text;
            DateTime PkgStartDate = DateTime.Parse(txtStartDate.Text);
            DateTime PkgEndDate = DateTime.Parse(txtEndDate.Text);
            string PkgDesc = lblDesc.Text;
            double PkgBasePrice = double.Parse(txtBasePrice.Text);
            double PkgAgencyCommission = double.Parse(txtCommission.Text);

            UpdatePackage UpdatePkgManager = new UpdatePackage(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission);
            UpdatePkgManager.Show();

        }
    }
}
