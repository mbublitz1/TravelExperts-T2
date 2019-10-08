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
using System.IO;
using Data.Core.ViewModel;

namespace TravelExperts_Desktop
{
    public partial class AddPackage : Form
    {
        public delegate void GenerateEvent();
        public static GenerateEvent callRefreshData;
        BindingList<ProductListViewModel> toAdd = new BindingList<ProductListViewModel>();
        //BindingList<ProductListViewModel> toRemove = new BindingList<ProductListViewModel>();

        public AddPackage()
        {
            InitializeComponent();
        }

        private void AddManager_Load(object sender, EventArgs e)
        {
            TravelWinRepository products = new TravelWinRepository();
            gridProductSupplierAdd.DataSource = products.GetProductSuppliers();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            ProductListViewModel gridRight = new ProductListViewModel();
            gridRight.ProdName = gridProductSupplierAdd.CurrentRow.Cells["colProdTypeLeft"].Value.ToString();
            gridRight.SupName = gridProductSupplierAdd.CurrentRow.Cells["colSupplierLeft"].Value.ToString();
            toAdd.Add(gridRight);
            gridProductSupplierRemove.DataSource = toAdd;
        }

        private void BtnRemoveSupplier_Click(object sender, EventArgs e)
        {
            toAdd.RemoveAt(gridProductSupplierRemove.CurrentRow.Index);
            gridProductSupplierRemove.DataSource = toAdd;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
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
                //File.Copy(txtFilePath.Text, @"C:\Users\John\Documents\GitHub\TravelExperts-T2\TravelExperts\TravelExperts\Content\img\" + Path.GetFileName(txtFilePath.Text));
                File.Copy(txtFilePath.Text, @"C:\Users\Mike\Documents\GitHub\TravelExperts-T2\TravelExperts\TravelExperts\Content\img\" + Path.GetFileName(txtFilePath.Text));
            }
            TravelWinRepository package = new TravelWinRepository();
            package.InsertPackage(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PackageImageLocation);
            callRefreshData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
