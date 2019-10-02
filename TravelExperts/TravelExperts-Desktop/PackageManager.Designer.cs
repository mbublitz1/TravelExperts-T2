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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPackages
            // 
            this.gridPackages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPackages.ColumnHeadersVisible = false;
            this.gridPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageId,
            this.PackageName});
            this.gridPackages.Location = new System.Drawing.Point(12, 12);
            this.gridPackages.Name = "gridPackages";
            this.gridPackages.ReadOnly = true;
            this.gridPackages.RowHeadersVisible = false;
            this.gridPackages.RowHeadersWidth = 51;
            this.gridPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPackages.Size = new System.Drawing.Size(175, 352);
            this.gridPackages.TabIndex = 1;
            this.gridPackages.SelectionChanged += new System.EventHandler(this.GridPackages_SelectionChanged);
            // 
            // PackageId
            // 
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
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Location = new System.Drawing.Point(193, 12);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(78, 13);
            this.lblPackageName.TabIndex = 2;
            this.lblPackageName.Text = "package name";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(234, 141);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(237, 167);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(193, 45);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "description";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(295, 138);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtStartDate.TabIndex = 6;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(295, 164);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtEndDate.TabIndex = 7;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(465, 144);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(58, 13);
            this.lblBasePrice.TabIndex = 8;
            this.lblBasePrice.Text = "Base Price";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(529, 141);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.ReadOnly = true;
            this.txtBasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtBasePrice.TabIndex = 9;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(461, 170);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(62, 13);
            this.lblCommission.TabIndex = 10;
            this.lblCommission.Text = "Commission";
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(529, 167);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.ReadOnly = true;
            this.txtCommission.Size = new System.Drawing.Size(100, 20);
            this.txtCommission.TabIndex = 11;
            // 
            // gridProducts
            // 
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(237, 224);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersVisible = false;
            this.gridProducts.RowHeadersWidth = 51;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(392, 140);
            this.gridProducts.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(191, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(272, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(353, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(662, 12);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(466, 352);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 17;
            this.pbImage.TabStop = false;
            // 
            // PackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 462);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.gridPackages);
            this.Name = "PackageManager";
            this.Text = "Package Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridView gridPackages;
        private System.Windows.Forms.PictureBox pbImage;
    }
}

