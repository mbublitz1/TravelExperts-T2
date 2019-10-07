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
    public partial class AddPackage : Form
    {
        public delegate void GenerateEvent();
        public static GenerateEvent callRefreshData;
        public AddPackage()
        {
            InitializeComponent();
        }

        private void AddManager_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string PkgName = txtPackageName.Text;
            DateTime PkgStartDate = dateTimePackageStart.Value;
            DateTime PkgEndDate = dateTimePackageEnd.Value;
            string PkgDesc = txtPackageDescription.Text;
            double PkgBasePrice = double.Parse(txtPackagePrice.Text);
            double PkgAgencyCommission = double.Parse(txtPackageAgency.Text);
            TravelWinRepository package = new TravelWinRepository();
            package.InsertPackage(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission);
            callRefreshData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
