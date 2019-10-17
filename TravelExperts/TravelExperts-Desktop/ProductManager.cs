using Data.Core.Models;
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
    public partial class ProductManager : Form
    {
        public ProductManager()
        {
            InitializeComponent();
        }

        private void RefreshCB()
        {
            List<Product> productsList = new List<Product>();
            for (int i = 0; i < gridProducts.RowCount; i++)
            {
                Product p = new Product();
                p.ProductId = Convert.ToInt32(gridProducts.Rows[i].Cells["ProductId"].Value);
                p.ProdName = gridProducts.Rows[i].Cells["ProdName"].Value.ToString();
                productsList.Add(p);
            }
            cbProducts.DataSource = productsList;
            cbProducts.DisplayMember = "ProdName";
            cbProducts.ValueMember = "ProductId";
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            gridSuppliers.AutoGenerateColumns = false;
            TravelWinRepository products = new TravelWinRepository();
            gridProducts.DataSource = products.GetProduct();
            gridSuppliers.DataSource = products.GetSuppliers();
            RefreshCB();
        }

        private void BtnProductAdd_Click(object sender, EventArgs e)
        {
            string ProdName = txtNewProduct.Text;
            TravelWinRepository products = new TravelWinRepository();
            products.InsertProduct(ProdName);
            gridProducts.DataSource = products.GetProduct();
            RefreshCB();
            //callRefreshData();
        }

        private void BtnSupplierAdd_Click(object sender, EventArgs e)
        {
            int SupplierId = Convert.ToInt32(txtSupplierId.Text);
            string SupName = txtNewSuppler.Text;
            //int ProductId = (int) cbProducts.SelectedItem;
            Product prod = cbProducts.SelectedItem as Product;
            TravelWinRepository suppliers = new TravelWinRepository();
            suppliers.InsertSupplier(SupplierId, SupName, prod.ProductId);
        }
    }
}
