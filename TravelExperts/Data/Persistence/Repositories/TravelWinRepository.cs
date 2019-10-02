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
using System.Windows.Forms;

namespace Data.Persistence.Repositories
{
    public class TravelWinRepository
    {
        public string connString= ConfigurationManager.ConnectionStrings["TravelWinConn"].ConnectionString;

        public List<PackageListViewModel> GetPackages()
        {
            string selectStatement = "SELECT PackageId, PkgName FROM Packages";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                List<PackageListViewModel> data = new List<PackageListViewModel>();

                while (reader.Read())
                {
                    PackageListViewModel p = new PackageListViewModel();
                    p.PackageId = Convert.ToInt32(reader["PackageId"]);
                    p.PkgName = reader["PkgName"].ToString();
                    data.Add(p);
                }
                reader.Close();
                return data;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Package GetSinglePackage(int id)
        {
            string selectStatement = "SELECT * FROM Packages WHERE PackageId = @id";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection & CommandBehavior.SingleRow);
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
                reader.Close();
                return data;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<ProductListViewModel> GetProducts(int id)
        {
            string selectStatement =
                @"SELECT pa.PackageId, p.ProdName, s.SupName FROM Products_Suppliers ps
                JOIN Products p ON ps.ProductId = p.ProductId
                JOIN Suppliers s ON ps.SupplierId = s.SupplierId
                JOIN Packages_Products_Suppliers pps ON ps.ProductSupplierId = pps.ProductSupplierId
                JOIN Packages pa ON pps.PackageId = pa.PackageId
                WHERE pa.PackageId = @id";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            selectCommand.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                List<ProductListViewModel> data = new List<ProductListViewModel>();

                while (reader.Read())
                {
                    ProductListViewModel p = new ProductListViewModel();
                    p.ProdName = reader["ProdName"].ToString();
                    p.SupName = reader["SupName"].ToString();
                    data.Add(p);
                }
                reader.Close();
                return data;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeletePackage(int id)
        {
            string deleteStatement = "DELETE FROM Packages WHERE PackageId = @id";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);
            deleteCommand.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                deleteCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
