﻿namespace TravelExperts_Desktop
{
    partial class AddPackage
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
            this.lblPkgName = new System.Windows.Forms.Label();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.lblPkgEndDate = new System.Windows.Forms.Label();
            this.lblPackagePrice = new System.Windows.Forms.Label();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.lblPkgAgency = new System.Windows.Forms.Label();
            this.dateTimePackageStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePackageEnd = new System.Windows.Forms.DateTimePicker();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.txtPackagePrice = new System.Windows.Forms.TextBox();
            this.txtPackageAgency = new System.Windows.Forms.TextBox();
            this.txtPackageDescription = new System.Windows.Forms.TextBox();
            this.gridProductSupplierAdd = new System.Windows.Forms.DataGridView();
            this.gridProductSupplierRemove = new System.Windows.Forms.DataGridView();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSupplierAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSupplierRemove)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(13, 18);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(108, 17);
            this.lblPkgName.TabIndex = 1;
            this.lblPkgName.Text = "Package Name:";
            this.lblPkgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.Location = new System.Drawing.Point(13, 57);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(135, 17);
            this.lblPkgStartDate.TabIndex = 2;
            this.lblPkgStartDate.Text = "Package Start Date:";
            this.lblPkgStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPkgEndDate
            // 
            this.lblPkgEndDate.AutoSize = true;
            this.lblPkgEndDate.Location = new System.Drawing.Point(13, 96);
            this.lblPkgEndDate.Name = "lblPkgEndDate";
            this.lblPkgEndDate.Size = new System.Drawing.Size(130, 17);
            this.lblPkgEndDate.TabIndex = 3;
            this.lblPkgEndDate.Text = "Package End Date:";
            this.lblPkgEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPackagePrice
            // 
            this.lblPackagePrice.AutoSize = true;
            this.lblPackagePrice.Location = new System.Drawing.Point(13, 135);
            this.lblPackagePrice.Name = "lblPackagePrice";
            this.lblPackagePrice.Size = new System.Drawing.Size(103, 17);
            this.lblPackagePrice.TabIndex = 4;
            this.lblPackagePrice.Text = "Package Price:";
            this.lblPackagePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Location = new System.Drawing.Point(13, 213);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(142, 17);
            this.lblPkgDesc.TabIndex = 5;
            this.lblPkgDesc.Text = "Package Description:";
            this.lblPkgDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPkgAgency
            // 
            this.lblPkgAgency.AutoSize = true;
            this.lblPkgAgency.Location = new System.Drawing.Point(13, 174);
            this.lblPkgAgency.Name = "lblPkgAgency";
            this.lblPkgAgency.Size = new System.Drawing.Size(118, 17);
            this.lblPkgAgency.TabIndex = 6;
            this.lblPkgAgency.Text = "Package Agency:";
            this.lblPkgAgency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePackageStart
            // 
            this.dateTimePackageStart.Location = new System.Drawing.Point(161, 57);
            this.dateTimePackageStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePackageStart.Name = "dateTimePackageStart";
            this.dateTimePackageStart.Size = new System.Drawing.Size(200, 22);
            this.dateTimePackageStart.TabIndex = 8;
            // 
            // dateTimePackageEnd
            // 
            this.dateTimePackageEnd.Location = new System.Drawing.Point(161, 96);
            this.dateTimePackageEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePackageEnd.Name = "dateTimePackageEnd";
            this.dateTimePackageEnd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePackageEnd.TabIndex = 9;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(161, 18);
            this.txtPackageName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(200, 22);
            this.txtPackageName.TabIndex = 10;
            // 
            // txtPackagePrice
            // 
            this.txtPackagePrice.Location = new System.Drawing.Point(161, 135);
            this.txtPackagePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPackagePrice.Name = "txtPackagePrice";
            this.txtPackagePrice.Size = new System.Drawing.Size(200, 22);
            this.txtPackagePrice.TabIndex = 11;
            // 
            // txtPackageAgency
            // 
            this.txtPackageAgency.Location = new System.Drawing.Point(161, 174);
            this.txtPackageAgency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPackageAgency.Name = "txtPackageAgency";
            this.txtPackageAgency.Size = new System.Drawing.Size(200, 22);
            this.txtPackageAgency.TabIndex = 12;
            // 
            // txtPackageDescription
            // 
            this.txtPackageDescription.Location = new System.Drawing.Point(161, 213);
            this.txtPackageDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPackageDescription.Multiline = true;
            this.txtPackageDescription.Name = "txtPackageDescription";
            this.txtPackageDescription.Size = new System.Drawing.Size(200, 43);
            this.txtPackageDescription.TabIndex = 13;
            // 
            // gridProductSupplierAdd
            // 
            this.gridProductSupplierAdd.AllowUserToResizeRows = false;
            this.gridProductSupplierAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductSupplierAdd.Location = new System.Drawing.Point(461, 41);
            this.gridProductSupplierAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridProductSupplierAdd.Name = "gridProductSupplierAdd";
            this.gridProductSupplierAdd.RowHeadersVisible = false;
            this.gridProductSupplierAdd.RowHeadersWidth = 82;
            this.gridProductSupplierAdd.RowTemplate.Height = 24;
            this.gridProductSupplierAdd.Size = new System.Drawing.Size(244, 244);
            this.gridProductSupplierAdd.TabIndex = 14;
            // 
            // gridProductSupplierRemove
            // 
            this.gridProductSupplierRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductSupplierRemove.Location = new System.Drawing.Point(779, 41);
            this.gridProductSupplierRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridProductSupplierRemove.Name = "gridProductSupplierRemove";
            this.gridProductSupplierRemove.RowHeadersVisible = false;
            this.gridProductSupplierRemove.RowHeadersWidth = 82;
            this.gridProductSupplierRemove.RowTemplate.Height = 24;
            this.gridProductSupplierRemove.Size = new System.Drawing.Size(252, 244);
            this.gridProductSupplierRemove.TabIndex = 15;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Location = new System.Drawing.Point(720, 71);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(45, 86);
            this.btnAddSupplier.TabIndex = 16;
            this.btnAddSupplier.Text = "→\r\n";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSupplier.Location = new System.Drawing.Point(720, 164);
            this.btnRemoveSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(45, 86);
            this.btnRemoveSupplier.TabIndex = 17;
            this.btnRemoveSupplier.Text = "←";
            this.btnRemoveSupplier.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gridProductSupplierRemove);
            this.panel1.Controls.Add(this.txtPackageDescription);
            this.panel1.Controls.Add(this.txtPackageAgency);
            this.panel1.Controls.Add(this.btnRemoveSupplier);
            this.panel1.Controls.Add(this.txtPackagePrice);
            this.panel1.Controls.Add(this.gridProductSupplierAdd);
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
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel1.Size = new System.Drawing.Size(1045, 300);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Products Suppliers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Add ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(712, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Remove";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApply
            // 
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(821, 322);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(157, 28);
            this.btnApply.TabIndex = 19;
            this.btnApply.Text = "Apply Package";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(984, 322);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 363);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPackage";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Text = "Add Package Manager";
            this.Load += new System.EventHandler(this.AddManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSupplierAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSupplierRemove)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.Label lblPkgEndDate;
        private System.Windows.Forms.Label lblPackagePrice;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Label lblPkgAgency;
        private System.Windows.Forms.DateTimePicker dateTimePackageStart;
        private System.Windows.Forms.DateTimePicker dateTimePackageEnd;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.TextBox txtPackagePrice;
        private System.Windows.Forms.TextBox txtPackageAgency;
        private System.Windows.Forms.TextBox txtPackageDescription;
        private System.Windows.Forms.DataGridView gridProductSupplierAdd;
        private System.Windows.Forms.DataGridView gridProductSupplierRemove;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnRemoveSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}