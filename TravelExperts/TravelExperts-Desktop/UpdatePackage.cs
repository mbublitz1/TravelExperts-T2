using Data.Core.ViewModel;
using Data.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        bool newImage = false;
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
            txtPackagePrice.Text = PkgBasePrice.ToString("F");
            txtPackageAgency.Text = PkgAgencyCommission.ToString("F");
            txtFilePath.Text = PackageImageLocation;
        }

        private void UpdatePackage_Load(object sender, EventArgs e)
        {
            gridProductSupplierRemove.AutoGenerateColumns = false;
            TravelWinRepository package = new TravelWinRepository();
            gridProductSupplierAdd.DataSource = package.GetProductSuppliers();
            gridProductSupplierRemove.DataSource = package.GetProducts(selectedPackage);
            for (int i = 0; i < gridProductSupplierRemove.Rows.Count; i++)
            {
                ProductListViewModel gridRight = new ProductListViewModel();
                gridRight.ProdName = gridProductSupplierRemove.Rows[i].Cells["colProdTypeRight"].Value.ToString();
                gridRight.SupName = gridProductSupplierRemove.Rows[i].Cells["colSupplierRight"].Value.ToString();
                gridRight.ProductSupplierId = Convert.ToInt32(gridProductSupplierRemove.Rows[i].Cells["ProductSupplierId"].Value);
                toAdd.Add(gridRight);
            }

            string image = ConfigurationManager.AppSettings["PathToProject"] + txtFilePath.Text;
            try
            {
                //pbImage.Image = Image.FromFile(image);
                pbImage.Load(image);
            }
            catch
            {
                PictureBox errorPic = new PictureBox();
                pbImage.Image = errorPic.ErrorImage;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            try
            {
                int PackageId = selectedPackage;
                string PkgName = txtPackageName.Text;
                DateTime PkgStartDate = dateTimePackageStart.Value;
                DateTime PkgEndDate = dateTimePackageEnd.Value;
                string PkgDesc = txtPackageDescription.Text;
                double PkgBasePrice = double.Parse(txtPackagePrice.Text);
                double PkgAgencyCommission = double.Parse(txtPackageAgency.Text);
                string PackageImageLocation = "";
                if (!newImage)
                {
                    PackageImageLocation = txtFilePath.Text;
                }
                else if (txtFilePath.Text == "")
                {
                    PackageImageLocation = null;
                }
                else
                {
                    //string image = ConfigurationManager.AppSettings["PathToProject"];
                    PackageImageLocation = @"\Content\img\" + Path.GetFileName(txtFilePath.Text);
                    //File.Copy(txtFilePath.Text, image + PackageImageLocation);
                    string host = "ftp://mikebublitz.com/Content/img/" + Path.GetFileName(txtFilePath.Text);

                    FileInfo toUpload = new FileInfo(txtFilePath.Text);
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host);
                    request.Credentials = new NetworkCredential("mwbublit", "ftppassword");
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    Stream ftpStream = request.GetRequestStream();
                    FileStream file = File.OpenRead(txtFilePath.Text);
                    int length = 1024;
                    byte[] buffer = new byte[length];
                    int bytesRead = 0;
                    do
                    {
                        bytesRead = file.Read(buffer, 0, length);
                        ftpStream.Write(buffer, 0, bytesRead);
                    }
                    while (bytesRead != 0);
                    file.Close();
                    ftpStream.Close();
                }

                List<int> productsList = new List<int>();
                for (int i = 0; i < gridProductSupplierRemove.Rows.Count; i++)
                {
                    int product = Convert.ToInt32(gridProductSupplierRemove.Rows[i].Cells["ProductSupplierId"].Value);
                    productsList.Add(product);
                }

                TravelWinRepository package = new TravelWinRepository();
                package.UpdatePackage(PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PackageImageLocation, productsList);
                callRefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                newImage = true;
                this.txtFilePath.Text = this.openFileDialog1.FileName;
                pbImage.Image = Image.FromFile(txtFilePath.Text);
            }
        }

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            ProductListViewModel gridRight = new ProductListViewModel();
            gridRight.ProdName = gridProductSupplierAdd.CurrentRow.Cells["colProdTypeLeft"].Value.ToString();
            gridRight.SupName = gridProductSupplierAdd.CurrentRow.Cells["colSupplierLeft"].Value.ToString();
            gridRight.ProductSupplierId = Convert.ToInt32(gridProductSupplierAdd.CurrentRow.Cells["colProductSupplierIdLeft"].Value);
            toAdd.Add(gridRight);
            gridProductSupplierRemove.DataSource = null;
            gridProductSupplierRemove.DataSource = toAdd;
        }

        private void BtnRemoveSupplier_Click(object sender, EventArgs e)
        {
            toAdd.RemoveAt(gridProductSupplierRemove.CurrentRow.Index);
            gridProductSupplierRemove.DataSource = toAdd;
        }
    }
}
