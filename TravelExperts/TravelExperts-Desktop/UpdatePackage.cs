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
        int selectedPackage;
        public UpdatePackage(int PackageId, string PkgName, DateTime PkgStartDate,
            DateTime PkgEndDate, string PkgDesc,
            decimal PkgBasePrice, decimal PkgAgencyCommission, string PackageImageLocation)
        {
            InitializeComponent();
            selectedPackage = PackageId;
            txtPackageName.Text = PkgName;
            dateTimePackageStart.Value = PkgStartDate;
            dateTimePackageEnd.Value = PkgEndDate;
            txtPackageDescription.Text = PkgDesc;
            txtPackagePrice.Text = PkgBasePrice.ToString("C");
            txtPackageAgency.Text = PkgAgencyCommission.ToString("C");
            txtFilePath.Text = PackageImageLocation;
        }

        private void UpdatePackage_Load(object sender, EventArgs e)
        {
            TravelWinRepository package = new TravelWinRepository();
            gridProductSupplierAdd.DataSource = package.GetProductSuppliers();
            gridProductSupplierRemove.DataSource = package.GetProducts(selectedPackage);
            string image = @"C:\Users\John\Documents\GitHub\TravelExperts-T2\TravelExperts\TravelExperts" + txtFilePath.Text;
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
            //int selectedProductSupplier = Convert.ToInt32(gridProductSupplierAdd.CurrentRow.Cells[0].Value);

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            //callRefreshData();
        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txtFilePath.Text = this.openFileDialog1.FileName;
                pbImage.Image = Image.FromFile(txtFilePath.Text);
            }

        }
    }
}
