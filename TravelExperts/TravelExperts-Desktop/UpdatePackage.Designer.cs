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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtPackageDescription = new System.Windows.Forms.TextBox();
            this.txtPackageAgency = new System.Windows.Forms.TextBox();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.txtPackagePrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(738, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 24);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(616, 262);
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
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.txtPackageDescription);
            this.panel1.Controls.Add(this.txtPackageAgency);
            this.panel1.Controls.Add(this.btnRemoveSupplier);
            this.panel1.Controls.Add(this.txtPackagePrice);
            this.panel1.Controls.Add(this.dataGridView1);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, -4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Products Suppliers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(532, 202);
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
            this.label2.Location = new System.Drawing.Point(540, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(584, 11);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(189, 198);
            this.dataGridView2.TabIndex = 15;
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
            this.btnRemoveSupplier.Location = new System.Drawing.Point(534, 129);
            this.btnRemoveSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(34, 70);
            this.btnRemoveSupplier.TabIndex = 17;
            this.btnRemoveSupplier.Text = "←";
            this.btnRemoveSupplier.UseVisualStyleBackColor = true;
            // 
            // txtPackagePrice
            // 
            this.txtPackagePrice.Location = new System.Drawing.Point(121, 110);
            this.txtPackagePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackagePrice.Name = "txtPackagePrice";
            this.txtPackagePrice.Size = new System.Drawing.Size(151, 20);
            this.txtPackagePrice.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(183, 198);
            this.dataGridView1.TabIndex = 14;
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
            this.btnAddSupplier.Location = new System.Drawing.Point(534, 19);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(34, 70);
            this.btnAddSupplier.TabIndex = 16;
            this.btnAddSupplier.Text = "→";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
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
            // UpdatePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 295);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtPackageDescription;
        private System.Windows.Forms.TextBox txtPackageAgency;
        private System.Windows.Forms.Button btnRemoveSupplier;
        private System.Windows.Forms.TextBox txtPackagePrice;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}