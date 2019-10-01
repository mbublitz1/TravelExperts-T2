using Data.Core.Repository;
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
            IRepository repo = new TravelWinRepository();
            gridPackages.DataSource = repo.GetPackages();
        }
    }
}
