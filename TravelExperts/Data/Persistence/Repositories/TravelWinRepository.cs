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
using System.Windows.Forms;

namespace Data.Persistence.Repositories
{
    public class TravelWinRepository
    {
        public string connString = ConfigurationManager.ConnectionStrings["TravelWinConn"].ConnectionString;

        public List<PackageListViewModel> GetPackages()
        {
            string selectStatement = "SELECT PackageId, PkgName FROM Packages ORDER BY PackageId";
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
                    data.PackageImageLocation = reader["PackageImageLocation"].ToString();
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
                WHERE pa.PackageId = @id
                ORDER BY ProdName";
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
        public void InsertPackage(string PkgName, DateTime PkgStartDate,
            DateTime PkgEndDate, string PkgDesc,
            double PkgBasePrice, double PkgAgencyCommission, string PackageImageLocation, List<int> productsList)
        {
            string insertStatement =
                @"INSERT INTO Packages (PkgName, PkgStartDate, 
                PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PackageImageLocation)
                OUTPUT INSERTED.PackageId
                VALUES (@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, 
                @PkgBasePrice, @PkgAgencyCommission, @PackageImageLocation)";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
            insertCommand.Parameters.AddWithValue("@PkgName", PkgName);
            insertCommand.Parameters.AddWithValue("@PkgStartDate", PkgStartDate);
            insertCommand.Parameters.AddWithValue("@PkgEndDate", PkgEndDate);
            insertCommand.Parameters.AddWithValue("@PkgDesc", PkgDesc);
            insertCommand.Parameters.AddWithValue("@PkgBasePrice", PkgBasePrice);
            insertCommand.Parameters.AddWithValue("@PkgAgencyCommission", PkgAgencyCommission);
            if (PackageImageLocation == null)
            {
                insertCommand.Parameters.AddWithValue("@PackageImageLocation", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@PackageImageLocation", PackageImageLocation);
            }
            try
            {
                conn.Open();
                //int count = insertCommand.ExecuteNonQuery();
                int modified = (int)insertCommand.ExecuteScalar();
                conn.Close();

                for (int i = 0; i < productsList.Count; i++)
                {
                    string insertProductStatement =
                        @"INSERT INTO Packages_Products_Suppliers
                        VALUES (@PackageId, @ProductSupplierId)";
                    SqlCommand insertProductCommand = new SqlCommand(insertProductStatement, conn);
                    insertProductCommand.Parameters.AddWithValue("@PackageId", modified);
                    insertProductCommand.Parameters.AddWithValue("@ProductSupplierId", i);
                    try
                    {
                        conn.Open();
                        insertProductCommand.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

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
        public List<ProductListViewModel> GetProductSuppliers()
        {
            string selectStatement =
                @"SELECT s.SupName, p.ProdName, ps.ProductSupplierId FROM Suppliers s
                JOIN Products_Suppliers ps ON s.SupplierId = ps.SupplierId
                JOIN Products p ON ps.ProductId = p.ProductId;";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
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
                    p.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);
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
    }
}

