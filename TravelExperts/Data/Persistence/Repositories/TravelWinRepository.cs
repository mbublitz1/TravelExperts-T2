﻿using Castle.Components.DictionaryAdapter;
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
    public class TravelWinRepository
    {
        public string connString= ConfigurationManager.ConnectionStrings["TravelWinConnCole"].ConnectionString;

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

        public Package GetSinglePackage(int id)
        {
            string selectStatement = "SELECT * FROM Packages WHERE PackageId = " + id;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(selectStatement, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Package data = new Package();

            while (reader.Read())
            {
                data.PackageId = Convert.ToInt32(reader["PackageId"]);
                data.PkgName = reader["PkgName"].ToString();
                data.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);
                data.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);
                data.PkgDesc = reader["PkgDesc"].ToString();
                data.PkgBasePrice = Convert.ToDecimal(reader["PkgBasePrice"]);
                data.PkgAgencyCommission = Convert.ToDecimal(reader["PkgAgencyCommission"]);
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
