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
    public partial class UpdatePackage : Form
    {
        public delegate void GenerateEvent();
        public static GenerateEvent callRefreshData;
        public UpdatePackage(string PkgName, DateTime PkgStartDate, 
            DateTime PkgEndDate, string PkgDesc, 
            decimal PkgBasePrice, decimal PkgAgencyCommission )
        {
            InitializeComponent();
            txtPackageName.Text = PkgName;
            dateTimePackageStart.Value = PkgStartDate;
            dateTimePackageEnd.Value = PkgEndDate;
            txtPackageDescription.Text = PkgDesc;
            txtPackagePrice.Text = PkgBasePrice.ToString("C");
            txtPackageAgency.Text = PkgAgencyCommission.ToString("C");
        }

        private void UpdatePackage_Load(object sender, EventArgs e)
        {
            TravelWinRepository package = new TravelWinRepository();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            callRefreshData();
        }
    }
}
