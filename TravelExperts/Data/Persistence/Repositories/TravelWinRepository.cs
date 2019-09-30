using Data.Core.Models;
using Data.Core.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Persistence.Repositories
{
    class TravelWinRepository : IRepository
    {
        public string connString= ConfigurationManager.ConnectionStrings["TravelWinConn"].ConnectionString;

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Package> GetPackages()
        {
            string selectStatement = "SELECT PackageId, PkgName FROM Packages";
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectStatement, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            

            throw new NotImplementedException();
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
