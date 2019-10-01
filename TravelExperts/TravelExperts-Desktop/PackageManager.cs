﻿using Data.Core.Repository;
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
    public partial class PackageManager : Form
    {        
        public PackageManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TravelWinRepository packages = new TravelWinRepository();
            gridPackages.DataSource = packages.GetPackages();
        }

        private void GridPackages_SelectionChanged(object sender, EventArgs e)
        {
            TravelWinRepository package = new TravelWinRepository();
            int selectedPackage = Convert.ToInt32(gridPackages.CurrentRow.Cells["PackageId"].Value);
            var list = package.GetSinglePackage(selectedPackage);
            lblPackageName.Text = list.PkgName;
            lblDesc.Text = list.PkgDesc;
            txtStartDate.Text = list.PkgStartDate.ToString();
            txtEndDate.Text = list.PkgEndDate.ToString();
            txtBasePrice.Text = Convert.ToString(list.PkgBasePrice);
            txtCommission.Text = Convert.ToString(list.PkgAgencyCommission);
        }
    }
}