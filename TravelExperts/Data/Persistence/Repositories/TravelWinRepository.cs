using Castle.Components.DictionaryAdapter;
using Data.Core.Models;
using Data.Core.Repository;
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

        public List<Package> GetPackages()
        {
            string selectStatement = "SELECT PkgName FROM Packages";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(selectStatement, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Package> data = new List<Package>();

            while (reader.Read())
            {
                Package p = new Package();
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
