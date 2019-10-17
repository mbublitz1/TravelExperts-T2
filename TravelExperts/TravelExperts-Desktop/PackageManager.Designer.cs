namespace TravelExperts_Desktop
{
    partial class PackageManager
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
            this.gridPackages = new System.Windows.Forms.DataGridView();
            this.PackageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.colProdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gridAllProducts = new System.Windows.Forms.DataGridView();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllProductSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPackages = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllProducts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPackages
            // 
            this.gridPackages.AllowUserToAddRows = false;
            this.gridPackages.AllowUserToDeleteRows = false;
            this.gridPackages.AllowUserToResizeColumns = false;
            this.gridPackages.AllowUserToResizeRows = false;
            this.gridPackages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPackages.ColumnHeadersVisible = false;
            this.gridPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageId,
            this.PackageName,
            this.Expired});
            this.gridPackages.Location = new System.Drawing.Point(7, 26);
            this.gridPackages.MultiSelect = false;
            this.gridPackages.Name = "gridPackages";
            this.gridPackages.ReadOnly = true;
            this.gridPackages.RowHeadersVisible = false;
            this.gridPackages.RowHeadersWidth = 51;
            this.gridPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPackages.Size = new System.Drawing.Size(175, 716);
            this.gridPackages.TabIndex = 1;
            this.gridPackages.SelectionChanged += new System.EventHandler(this.GridPackages_SelectionChanged);
            // 
            // PackageId
            // 
            this.PackageId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PackageId.DataPropertyName = "PackageId";
            this.PackageId.HeaderText = "Package Id";
            this.PackageId.MinimumWidth = 6;
            this.PackageId.Name = "PackageId";
            this.PackageId.ReadOnly = true;
            this.PackageId.Visible = false;
            // 
            // PackageName
            // 
            this.PackageName.DataPropertyName = "PkgName";
            this.PackageName.HeaderText = "PackageName";
            this.PackageName.MinimumWidth = 6;
            this.PackageName.Name = "PackageName";
            this.PackageName.ReadOnly = true;
            // 
            // Expired
            // 
            this.Expired.DataPropertyName = "Expired";
            this.Expired.HeaderText = "Expired";
            this.Expired.Name = "Expired";
            this.Expired.ReadOnly = true;
            this.Expired.Visible = false;
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.Location = new System.Drawing.Point(211, 3);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(237, 39);
            this.lblPackageName.TabIndex = 2;
            this.lblPackageName.Text = "packageName";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(215, 647);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 13);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(215, 673);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(64, 13);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(214, 424);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(86, 20);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "description";
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(293, 647);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(103, 13);
            this.txtStartDate.TabIndex = 6;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(293, 673);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(103, 13);
            this.txtEndDate.TabIndex = 7;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(402, 647);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(72, 13);
            this.lblBasePrice.TabIndex = 8;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.Location = new System.Drawing.Point(480, 647);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.ReadOnly = true;
            this.txtBasePrice.Size = new System.Drawing.Size(103, 13);
            this.txtBasePrice.TabIndex = 9;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommission.Location = new System.Drawing.Point(402, 673);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(76, 13);
            this.lblCommission.TabIndex = 10;
            this.lblCommission.Text = "Commission:";
            // 
            // txtCommission
            // 
            this.txtCommission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommission.Location = new System.Drawing.Point(480, 673);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.ReadOnly = true;
            this.txtCommission.Size = new System.Drawing.Size(103, 13);
            this.txtCommission.TabIndex = 11;
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeRows = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdType,
            this.colSupplier,
            this.ProductSupplierId});
            this.gridProducts.Location = new System.Drawing.Point(218, 476);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersVisible = false;
            this.gridProducts.RowHeadersWidth = 51;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(466, 140);
            this.gridProducts.TabIndex = 13;
            // 
            // colProdType
            // 
            this.colProdType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdType.DataPropertyName = "ProdName";
            this.colProdType.HeaderText = "Product Type";
            this.colProdType.Name = "colProdType";
            this.colProdType.ReadOnly = true;
            this.colProdType.Width = 96;
            // 
            // colSupplier
            // 
            this.colSupplier.DataPropertyName = "SupName";
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            // 
            // ProductSupplierId
            // 
            this.ProductSupplierId.DataPropertyName = "ProductSupplierId";
            this.ProductSupplierId.HeaderText = "ProductSupplierId";
            this.ProductSupplierId.Name = "ProductSupplierId";
            this.ProductSupplierId.ReadOnly = true;
            this.ProductSupplierId.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(265, 719);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(346, 719);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(427, 719);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gridAllProducts
            // 
            this.gridAllProducts.AllowUserToAddRows = false;
            this.gridAllProducts.AllowUserToDeleteRows = false;
            this.gridAllProducts.AllowUserToResizeRows = false;
            this.gridAllProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdName,
            this.SupName,
            this.AllProductSupplierId});
            this.gridAllProducts.Location = new System.Drawing.Point(7, 23);
            this.gridAllProducts.MultiSelect = false;
            this.gridAllProducts.Name = "gridAllProducts";
            this.gridAllProducts.ReadOnly = true;
            this.gridAllProducts.RowHeadersVisible = false;
            this.gridAllProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAllProducts.Size = new System.Drawing.Size(310, 687);
            this.gridAllProducts.TabIndex = 18;
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProdName.DataPropertyName = "ProdName";
            this.ProdName.HeaderText = "Product Type";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            this.ProdName.Width = 96;
            // 
            // SupName
            // 
            this.SupName.DataPropertyName = "SupName";
            this.SupName.HeaderText = "Supplier";
            this.SupName.Name = "SupName";
            this.SupName.ReadOnly = true;
            // 
            // AllProductSupplierId
            // 
            this.AllProductSupplierId.DataPropertyName = "ProductSupplierId";
            this.AllProductSupplierId.HeaderText = "AllProductSupplierId";
            this.AllProductSupplierId.Name = "AllProductSupplierId";
            this.AllProductSupplierId.ReadOnly = true;
            this.AllProductSupplierId.Visible = false;
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackages.Location = new System.Drawing.Point(3, 0);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(79, 20);
            this.lblPackages.TabIndex = 19;
            this.lblPackages.Text = "Packages";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(3, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(72, 20);
            this.lblProducts.TabIndex = 20;
            this.lblProducts.Text = "Products";
            // 
            // btnConfigure
            // 
            this.btnConfigure.Location = new System.Drawing.Point(134, 719);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(75, 23);
            this.btnConfigure.TabIndex = 21;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.BtnConfigure_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPackages);
            this.panel1.Controls.Add(this.gridPackages);
            this.panel1.Controls.Add(this.lblPackageName);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.txtStartDate);
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Controls.Add(this.txtEndDate);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.lblBasePrice);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtBasePrice);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblCommission);
            this.panel1.Controls.Add(this.gridProducts);
            this.panel1.Controls.Add(this.txtCommission);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 753);
            this.panel1.TabIndex = 24;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(218, 59);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(466, 352);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 17;
            this.pbImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblProducts);
            this.panel2.Controls.Add(this.gridAllProducts);
            this.panel2.Controls.Add(this.btnConfigure);
            this.panel2.Location = new System.Drawing.Point(808, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 752);
            this.panel2.TabIndex = 25;
            // 
            // PackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 775);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PackageManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView gridPackages;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expired;
        private System.Windows.Forms.DataGridView gridAllProducts;
        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllProductSupplierId;
    }
}

