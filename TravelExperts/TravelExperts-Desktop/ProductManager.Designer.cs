namespace TravelExperts_Desktop
{
    partial class ProductManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.lblNewProduct = new System.Windows.Forms.Label();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products_Suppliers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNewProduct = new System.Windows.Forms.TextBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnSupplierAdd = new System.Windows.Forms.Button();
            this.lblSelectProduct = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.txtNewSuppler = new System.Windows.Forms.TextBox();
            this.lblNewSupplier = new System.Windows.Forms.Label();
            this.gridSuppliers = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products_Products_Suppliers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.btnProductAdd);
            this.panel1.Controls.Add(this.lblNewProduct);
            this.panel1.Controls.Add(this.gridProducts);
            this.panel1.Controls.Add(this.txtNewProduct);
            this.panel1.Controls.Add(this.lblProducts);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 579);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(38, 551);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Delete Selected";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(38, 522);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(102, 23);
            this.btnProductAdd.TabIndex = 4;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.BtnProductAdd_Click);
            // 
            // lblNewProduct
            // 
            this.lblNewProduct.AutoSize = true;
            this.lblNewProduct.Location = new System.Drawing.Point(6, 469);
            this.lblNewProduct.Name = "lblNewProduct";
            this.lblNewProduct.Size = new System.Drawing.Size(69, 13);
            this.lblNewProduct.TabIndex = 2;
            this.lblNewProduct.Text = "New Product";
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeRows = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.ColumnHeadersVisible = false;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProdName,
            this.Products_Suppliers});
            this.gridProducts.Location = new System.Drawing.Point(7, 32);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersVisible = false;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(177, 434);
            this.gridProducts.TabIndex = 1;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // ProdName
            // 
            this.ProdName.DataPropertyName = "ProdName";
            this.ProdName.HeaderText = "Product Name";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // Products_Suppliers
            // 
            this.Products_Suppliers.DataPropertyName = "Products_Suppliers";
            this.Products_Suppliers.HeaderText = "Products_Suppliers";
            this.Products_Suppliers.Name = "Products_Suppliers";
            this.Products_Suppliers.ReadOnly = true;
            this.Products_Suppliers.Visible = false;
            // 
            // txtNewProduct
            // 
            this.txtNewProduct.Location = new System.Drawing.Point(9, 485);
            this.txtNewProduct.Name = "txtNewProduct";
            this.txtNewProduct.Size = new System.Drawing.Size(177, 20);
            this.txtNewProduct.TabIndex = 3;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(3, 9);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(72, 20);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Products";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSupplierId);
            this.panel2.Controls.Add(this.lblSupplierId);
            this.panel2.Controls.Add(this.btnDeleteSupplier);
            this.panel2.Controls.Add(this.btnSupplierAdd);
            this.panel2.Controls.Add(this.lblSelectProduct);
            this.panel2.Controls.Add(this.cbProducts);
            this.panel2.Controls.Add(this.txtNewSuppler);
            this.panel2.Controls.Add(this.lblNewSupplier);
            this.panel2.Controls.Add(this.gridSuppliers);
            this.panel2.Controls.Add(this.lblSuppliers);
            this.panel2.Location = new System.Drawing.Point(273, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 579);
            this.panel2.TabIndex = 4;
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Location = new System.Drawing.Point(7, 446);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(263, 20);
            this.txtSupplierId.TabIndex = 8;
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Location = new System.Drawing.Point(4, 430);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(59, 13);
            this.lblSupplierId.TabIndex = 7;
            this.lblSupplierId.Text = "Supplier ID";
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(83, 551);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteSupplier.TabIndex = 6;
            this.btnDeleteSupplier.Text = "Delete Selected";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.BtnDeleteSupplier_Click);
            // 
            // btnSupplierAdd
            // 
            this.btnSupplierAdd.Location = new System.Drawing.Point(83, 522);
            this.btnSupplierAdd.Name = "btnSupplierAdd";
            this.btnSupplierAdd.Size = new System.Drawing.Size(102, 23);
            this.btnSupplierAdd.TabIndex = 5;
            this.btnSupplierAdd.Text = "Add";
            this.btnSupplierAdd.UseVisualStyleBackColor = true;
            this.btnSupplierAdd.Click += new System.EventHandler(this.BtnSupplierAdd_Click);
            // 
            // lblSelectProduct
            // 
            this.lblSelectProduct.AutoSize = true;
            this.lblSelectProduct.Location = new System.Drawing.Point(4, 469);
            this.lblSelectProduct.Name = "lblSelectProduct";
            this.lblSelectProduct.Size = new System.Drawing.Size(77, 13);
            this.lblSelectProduct.TabIndex = 5;
            this.lblSelectProduct.Text = "Select Product";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(7, 485);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(263, 21);
            this.cbProducts.TabIndex = 4;
            // 
            // txtNewSuppler
            // 
            this.txtNewSuppler.Location = new System.Drawing.Point(7, 407);
            this.txtNewSuppler.Name = "txtNewSuppler";
            this.txtNewSuppler.Size = new System.Drawing.Size(263, 20);
            this.txtNewSuppler.TabIndex = 3;
            // 
            // lblNewSupplier
            // 
            this.lblNewSupplier.AutoSize = true;
            this.lblNewSupplier.Location = new System.Drawing.Point(4, 391);
            this.lblNewSupplier.Name = "lblNewSupplier";
            this.lblNewSupplier.Size = new System.Drawing.Size(70, 13);
            this.lblNewSupplier.TabIndex = 2;
            this.lblNewSupplier.Text = "New Supplier";
            // 
            // gridSuppliers
            // 
            this.gridSuppliers.AllowUserToAddRows = false;
            this.gridSuppliers.AllowUserToDeleteRows = false;
            this.gridSuppliers.AllowUserToResizeRows = false;
            this.gridSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSuppliers.ColumnHeadersVisible = false;
            this.gridSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.SupName,
            this.Products_Products_Suppliers});
            this.gridSuppliers.Location = new System.Drawing.Point(7, 32);
            this.gridSuppliers.MultiSelect = false;
            this.gridSuppliers.Name = "gridSuppliers";
            this.gridSuppliers.ReadOnly = true;
            this.gridSuppliers.RowHeadersVisible = false;
            this.gridSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSuppliers.Size = new System.Drawing.Size(263, 356);
            this.gridSuppliers.TabIndex = 1;
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "SupplierId";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            this.SupplierId.Visible = false;
            // 
            // SupName
            // 
            this.SupName.DataPropertyName = "SupName";
            this.SupName.HeaderText = "SupName";
            this.SupName.Name = "SupName";
            this.SupName.ReadOnly = true;
            // 
            // Products_Products_Suppliers
            // 
            this.Products_Products_Suppliers.DataPropertyName = "Products_Suppliers";
            this.Products_Products_Suppliers.HeaderText = "Products_Suppliers";
            this.Products_Products_Suppliers.Name = "Products_Products_Suppliers";
            this.Products_Products_Suppliers.ReadOnly = true;
            this.Products_Products_Suppliers.Visible = false;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.Location = new System.Drawing.Point(3, 9);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(75, 20);
            this.lblSuppliers.TabIndex = 0;
            this.lblSuppliers.Text = "Suppliers";
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductManager";
            this.Load += new System.EventHandler(this.ProductManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblNewProduct;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox txtNewProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSupplierAdd;
        private System.Windows.Forms.Label lblSelectProduct;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.TextBox txtNewSuppler;
        private System.Windows.Forms.Label lblNewSupplier;
        private System.Windows.Forms.DataGridView gridSuppliers;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products_Suppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products_Products_Suppliers;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label lblSupplierId;
    }
}