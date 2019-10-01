using Castle.Components.DictionaryAdapter;
using Data.Core.Models;
using Data.Core.Repository;
using Data.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Persistence.Repositories
{
    public class TravelWinRepository : IRepository
    {
        public string connString= ConfigurationManager.ConnectionStrings["TravelWinConn"].ConnectionString;

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<PackageListViewModel> GetPackages()
        {
            string selectStatement = "SELECT PackageId, PkgName FROM Packages";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(selectStatement, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<PackageListViewModel> data = new List<PackageListViewModel>();

            while (reader.Read())
            {
                PackageListViewModel p = new PackageListViewModel();
                p.PackageId = Convert.ToInt32(reader["PackageId"]);
                p.PkgName = reader["PkgName"].ToString();
                data.Add(p);
            }
            conn.Close();
            return data;
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetSuppliers()
        {
            throw new NotImplementedException();
        }
    }
}
