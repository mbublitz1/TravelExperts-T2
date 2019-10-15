namespace TravelExperts_Desktop
{
    partial class UpdatePackage
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridProductSupplierRemove = new System.Windows.Forms.DataGridView();
            this.gridProductSupplierAdd = new System.Windows.Forms.DataGridView();
            this.colProdTypeLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblImageLocation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPackageDescription = new System.Windows.Forms.TextBox();
            this.txtPackageAgency = new System.Windows.Forms.TextBox();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.txtPackagePrice = new System.Windows.Forms.TextBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.dateTimePackageEnd = new System.Windows.Forms.DateTimePicker();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.dateTimePackageStart = new System.Windows.Forms.DateTimePicker();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.lblPkgAgency = new System.Windows.Forms.Label();
            this.lblPkgEndDate = new System.Windows.Forms.Label();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.lblPackagePrice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colProdTypeRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductSupplierIdRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSupplierRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSupplierAdd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(738, 603);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 24);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(616, 603);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(118, 24);
            this.btnApply.TabIndex = 22;
            this.btnApply.Text = "Apply Package";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridProductSupplierRemove);
            this.panel1.Controls.Add(this.gridProductSupplierAdd);
            this.panel1.Controls.Add(this.lblImageLocation);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPackageDescription);
            this.panel1.Controls.Add(this.txtPackageAgency);
            this.panel1.Controls.Add(this.btnRemoveSupplier);
            this.panel1.Controls.Add(this.txtPackagePrice);
            this.panel1.Controls.Add(this.txtPackageName);
            this.panel1.Controls.Add(this.btnAddSupplier);
            this.panel1.Controls.Add(this.dateTimePackageEnd);
            this.panel1.Controls.Add(this.lblPkgName);
            this.panel1.Controls.Add(this.dateTimePackageStart);
            this.panel1.Controls.Add(this.lblPkgStartDate);
            this.panel1.Controls.Add(this.lblPkgAgency);
            this.panel1.Controls.Add(this.lblPkgEndDate);
            this.panel1.Controls.Add(this.lblPkgDesc);
            this.panel1.Controls.Add(this.lblPackagePrice);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(784, 244);
            this.panel1.TabIndex = 21;
            // 
            // gridProductSupplierRemove
            // 
            this.gridProductSupplierRemove.AllowUserToAddRows = false;
            this.gridProductSupplierRemove.AllowUserToDeleteRows = false;
            this.gridProductSupplierRemove.AllowUserToResizeRows = false;
            this.gridProductSupplierRemove.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductSupplierRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductSupplierRemove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdTypeRight,
            this.colSupplierRight,
            this.colProductSupplierIdRight});
            this.gridProductSupplierRemove.Location = new System.Drawing.Point(584, 33);
            this.gridProductSupplierRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridProductSupplierRemove.MultiSelect = false;
            this.gridProductSupplierRemove.Name = "gridProductSupplierRemove";
            this.gridProductSupplierRemove.ReadOnly = true;
            this.gridProductSupplierRemove.RowHeadersVisible = false;
            this.gridProductSupplierRemove.RowHeadersWidth = 82;
            this.gridProductSupplierRemove.RowTemplate.Height = 24;
            this.gridProductSupplierRemove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductSupplierRemove.Size = new System.Drawing.Size(189, 198);
            this.gridProductSupplierRemove.TabIndex = 28;
            // 
            // gridProductSupplierAdd
            // 
            this.gridProductSupplierAdd.AllowUserToAddRows = false;
            this.gridProductSupplierAdd.AllowUserToDeleteRows = false;
            this.gridProductSupplierAdd.AllowUserToResizeRows = false;
            this.gridProductSupplierAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductSupplierAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductSupplierAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdTypeLeft,
            this.colSupplierLeft,
            this.colProductSupplierId});
            this.gridProductSupplierAdd.Location = new System.Drawing.Point(346, 33);
            this.gridProductSupplierAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridProductSupplierAdd.MultiSelect = false;
            this.gridProductSupplierAdd.Name = "gridProductSupplierAdd";
            this.gridProductSupplierAdd.ReadOnly = true;
            this.gridProductSupplierAdd.RowHeadersVisible = false;
            this.gridProductSupplierAdd.RowHeadersWidth = 82;
            this.gridProductSupplierAdd.RowTemplate.Height = 24;
            this.gridProductSupplierAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductSupplierAdd.Size = new System.Drawing.Size(183, 198);
            this.gridProductSupplierAdd.TabIndex = 27;
            // 
            // colProdTypeLeft
            // 
            this.colProdTypeLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdTypeLeft.DataPropertyName = "ProdName";
            this.colProdTypeLeft.HeaderText = "Product Type";
            this.colProdTypeLeft.MinimumWidth = 10;
            this.colProdTypeLeft.Name = "colProdTypeLeft";
            this.colProdTypeLeft.ReadOnly = true;
            this.colProdTypeLeft.Width = 96;
            // 
            // colSupplierLeft
            // 
            this.colSupplierLeft.DataPropertyName = "SupName";
            this.colSupplierLeft.HeaderText = "Supplier";
            this.colSupplierLeft.MinimumWidth = 10;
            this.colSupplierLeft.Name = "colSupplierLeft";
            this.colSupplierLeft.ReadOnly = true;
            // 
            // colProductSupplierId
            // 
            this.colProductSupplierId.DataPropertyName = "ProductSupplierId";
            this.colProductSupplierId.HeaderText = "ProductSupplierId";
            this.colProductSupplierId.Name = "colProductSupplierId";
            this.colProductSupplierId.ReadOnly = true;
            this.colProductSupplierId.Visible = false;
            // 
            // lblImageLocation
            // 
            this.lblImageLocation.AutoSize = true;
            this.lblImageLocation.Location = new System.Drawing.Point(10, 216);
            this.lblImageLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageLocation.Name = "lblImageLocation";
            this.lblImageLocation.Size = new System.Drawing.Size(83, 13);
            this.lblImageLocation.TabIndex = 25;
            this.lblImageLocation.Text = "Image Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Products Suppliers";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(121, 213);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(151, 20);
            this.txtFilePath.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(534, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Remove";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPackageDescription
            // 
            this.txtPackageDescription.Location = new System.Drawing.Point(121, 173);
            this.txtPackageDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackageDescription.Multiline = true;
            this.txtPackageDescription.Name = "txtPackageDescription";
            this.txtPackageDescription.Size = new System.Drawing.Size(151, 36);
            this.txtPackageDescription.TabIndex = 13;
            // 
            // txtPackageAgency
            // 
            this.txtPackageAgency.Location = new System.Drawing.Point(121, 141);
            this.txtPackageAgency.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackageAgency.Name = "txtPackageAgency";
            this.txtPackageAgency.Size = new System.Drawing.Size(151, 20);
            this.txtPackageAgency.TabIndex = 12;
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.Location = new System.Drawing.Point(540, 133);
            this.btnRemoveSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(34, 70);
            this.btnRemoveSupplier.TabIndex = 17;
            this.btnRemoveSupplier.Text = "←";
            this.btnRemoveSupplier.UseVisualStyleBackColor = true;
            this.btnRemoveSupplier.Click += new System.EventHandler(this.BtnRemoveSupplier_Click);
            // 
            // txtPackagePrice
            // 
            this.txtPackagePrice.Location = new System.Drawing.Point(121, 110);
            this.txtPackagePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackagePrice.Name = "txtPackagePrice";
            this.txtPackagePrice.Size = new System.Drawing.Size(151, 20);
            this.txtPackagePrice.TabIndex = 11;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(121, 15);
            this.txtPackageName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(151, 20);
            this.txtPackageName.TabIndex = 10;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(540, 58);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(34, 70);
            this.btnAddSupplier.TabIndex = 16;
            this.btnAddSupplier.Text = "→";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.BtnAddSupplier_Click);
            // 
            // dateTimePackageEnd
            // 
            this.dateTimePackageEnd.Location = new System.Drawing.Point(121, 78);
            this.dateTimePackageEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePackageEnd.Name = "dateTimePackageEnd";
            this.dateTimePackageEnd.Size = new System.Drawing.Size(151, 20);
            this.dateTimePackageEnd.TabIndex = 9;
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(10, 15);
            this.lblPkgName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(84, 13);
            this.lblPkgName.TabIndex = 1;
            this.lblPkgName.Text = "Package Name:";
            this.lblPkgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePackageStart
            // 
            this.dateTimePackageStart.Location = new System.Drawing.Point(121, 46);
            this.dateTimePackageStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePackageStart.Name = "dateTimePackageStart";
            this.dateTimePackageStart.Size = new System.Drawing.Size(151, 20);
            this.dateTimePackageStart.TabIndex = 8;
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.Location = new System.Drawing.Point(10, 46);
            this.lblPkgStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(104, 13);
            this.lblPkgStartDate.TabIndex = 2;
            this.lblPkgStartDate.Text = "Package Start Date:";
            this.lblPkgStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPkgAgency
            // 
            this.lblPkgAgency.AutoSize = true;
            this.lblPkgAgency.Location = new System.Drawing.Point(10, 141);
            this.lblPkgAgency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPkgAgency.Name = "lblPkgAgency";
            this.lblPkgAgency.Size = new System.Drawing.Size(92, 13);
            this.lblPkgAgency.TabIndex = 6;
            this.lblPkgAgency.Text = "Package Agency:";
            this.lblPkgAgency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPkgEndDate
            // 
            this.lblPkgEndDate.AutoSize = true;
            this.lblPkgEndDate.Location = new System.Drawing.Point(10, 78);
            this.lblPkgEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPkgEndDate.Name = "lblPkgEndDate";
            this.lblPkgEndDate.Size = new System.Drawing.Size(101, 13);
            this.lblPkgEndDate.TabIndex = 3;
            this.lblPkgEndDate.Text = "Package End Date:";
            this.lblPkgEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Location = new System.Drawing.Point(10, 173);
            this.lblPkgDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(109, 13);
            this.lblPkgDesc.TabIndex = 5;
            this.lblPkgDesc.Text = "Package Description:";
            this.lblPkgDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPackagePrice
            // 
            this.lblPackagePrice.AutoSize = true;
            this.lblPackagePrice.Location = new System.Drawing.Point(10, 110);
            this.lblPackagePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackagePrice.Name = "lblPackagePrice";
            this.lblPackagePrice.Size = new System.Drawing.Size(80, 13);
            this.lblPackagePrice.TabIndex = 4;
            this.lblPackagePrice.Text = "Package Price:";
            this.lblPackagePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pbImage);
            this.panel2.Location = new System.Drawing.Point(10, 262);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 365);
            this.panel2.TabIndex = 24;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(4, 6);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(466, 352);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 22;
            this.pbImage.TabStop = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(492, 603);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(100, 23);
            this.btnAddImage.TabIndex = 23;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.BtnAddImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // colProdTypeRight
            // 
            this.colProdTypeRight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdTypeRight.DataPropertyName = "ProdName";
            this.colProdTypeRight.HeaderText = "Product Type";
            this.colProdTypeRight.MinimumWidth = 10;
            this.colProdTypeRight.Name = "colProdTypeRight";
            this.colProdTypeRight.ReadOnly = true;
            this.colProdTypeRight.Width = 96;
            // 
            // colSupplierRight
            // 
            this.colSupplierRight.DataPropertyName = "SupName";
            this.colSupplierRight.HeaderText = "Supplier";
            this.colSupplierRight.MinimumWidth = 10;
            this.colSupplierRight.Name = "colSupplierRight";
            this.colSupplierRight.ReadOnly = true;
            // 
            // colProductSupplierIdRight
            // 
            this.colProductSupplierIdRight.DataPropertyName = "ProductSupplierId";
            this.colProductSupplierIdRight.HeaderText = "ProductSupplierId";
            this.colProductSupplierIdRight.Name = "colProductSupplierIdRight";
            this.colProductSupplierIdRight.ReadOnly = true;
            // 
            // UpdatePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 636);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdatePackage";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Update Package Manager";
            this.Load += new System.EventHandler(this.UpdatePackage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSupplierRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSupplierAdd)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPackageDescription;
        private System.Windows.Forms.TextBox txtPackageAgency;
        private System.Windows.Forms.Button btnRemoveSupplier;
        private System.Windows.Forms.TextBox txtPackagePrice;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.DateTimePicker dateTimePackageEnd;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.DateTimePicker dateTimePackageStart;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.Label lblPkgAgency;
        private System.Windows.Forms.Label lblPkgEndDate;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Label lblPackagePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblImageLocation;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView gridProductSupplierRemove;
        private System.Windows.Forms.DataGridView gridProductSupplierAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdTypeLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdTypeRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductSupplierIdRight;
    }
}