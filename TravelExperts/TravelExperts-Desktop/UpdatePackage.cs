using Data.Core.ViewModel;
using Data.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        BindingList<ProductListViewModel> toAdd = new BindingList<ProductListViewModel>();
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
            for (int i = 0; i < gridProductSupplierRemove.Rows.Count; i++)
            {
                ProductListViewModel gridRight = new ProductListViewModel();
                gridRight.ProdName = gridProductSupplierRemove.Rows[i].Cells["colProdTypeRight"].Value.ToString();
                gridRight.SupName = gridProductSupplierRemove.Rows[i].Cells["colSupplierRight"].Value.ToString();
                gridRight.ProductSupplierId = Convert.ToInt32(gridProductSupplierRemove.Rows[i].Cells["colProductSupplierIdRight"].Value);
                toAdd.Add(gridRight);
            }

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
            int PackageId = selectedPackage;
            string PkgName = txtPackageName.Text;
            DateTime PkgStartDate = dateTimePackageStart.Value;
            DateTime PkgEndDate = dateTimePackageEnd.Value;
            string PkgDesc = txtPackageDescription.Text;
            double PkgBasePrice = double.Parse(txtPackagePrice.Text);
            double PkgAgencyCommission = double.Parse(txtPackageAgency.Text);
            string PackageImageLocation = "";
            if (txtFilePath.Text == "")
            {
                PackageImageLocation = null;
            }
            else
            {
                PackageImageLocation = @"\Content\img\" + Path.GetFileName(txtFilePath.Text);
                File.Copy(txtFilePath.Text, @"C:\Users\John\Documents\GitHub\TravelExperts-T2\TravelExperts\TravelExperts\Content\img\" + Path.GetFileName(txtFilePath.Text));
                //File.Copy(txtFilePath.Text, @"C:\Users\Mike\Documents\GitHub\TravelExperts-T2\TravelExperts\TravelExperts\Content\img\" + Path.GetFileName(txtFilePath.Text));
            }

            List<int> productsList = new List<int>();
            for (int i = 0; i < gridProductSupplierRemove.Rows.Count - 1; i++)
            {
                int product = Convert.ToInt32(gridProductSupplierRemove.Rows[i].Cells["colProductSupplierIdRight"].Value);
                productsList.Add(product);
            }

            TravelWinRepository package = new TravelWinRepository();
            package.UpdatePackage(PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PackageImageLocation, productsList);
            callRefreshData();
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

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            ProductListViewModel gridRight = new ProductListViewModel();
            gridRight.ProdName = gridProductSupplierAdd.CurrentRow.Cells["colProdTypeLeft"].Value.ToString();
            gridRight.SupName = gridProductSupplierAdd.CurrentRow.Cells["colSupplierLeft"].Value.ToString();
            gridRight.ProductSupplierId = Convert.ToInt32(gridProductSupplierAdd.CurrentRow.Cells["colProductSupplierId"].Value);
            toAdd.Add(gridRight);
            gridProductSupplierRemove.DataSource = toAdd;
        }

        private void BtnRemoveSupplier_Click(object sender, EventArgs e)
        {
            toAdd.RemoveAt(gridProductSupplierRemove.CurrentRow.Index);
            gridProductSupplierRemove.DataSource = toAdd;
        }
    }
}
