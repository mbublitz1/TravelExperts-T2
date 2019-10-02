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
            txtStartDate.Text = data.PkgStartDate.ToString();
            txtEndDate.Text = data.PkgEndDate.ToString();
            txtBasePrice.Text = Convert.ToString(data.PkgBasePrice);
            txtCommission.Text = Convert.ToString(data.PkgAgencyCommission);
            gridProducts.DataSource = package.GetProducts(selectedPackage);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            TravelWinRepository package = new TravelWinRepository();
            int selectedPackage = Convert.ToInt32(gridPackages.CurrentRow.Cells["PackageId"].Value);
            package.DeletePackage(selectedPackage);
            gridPackages.DataSource = package.GetPackages();
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
