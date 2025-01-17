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
using System.IO;
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
            string selectStatement = "SELECT PackageId, PkgName, PkgStartDate FROM Packages ORDER BY PackageId";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                List<PackageListViewModel> data = new List<PackageListViewModel>();

                while (reader.Read())
                {
                    DateTime today = DateTime.Now;
                    PackageListViewModel p = new PackageListViewModel();
                    p.PackageId = Convert.ToInt32(reader["PackageId"]);
                    p.PkgName = reader["PkgName"].ToString();
                    DateTime PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);
                    if (PkgStartDate < today)
                    {
                        p.expired = true;
                    }
                    else
                    {
                        p.expired = false;
                    }
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
                @"SELECT pa.PackageId, p.ProdName, s.SupName, pps.ProductSupplierId FROM Products_Suppliers ps
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

        public void DeletePackage(int id)
        {
            string deleteStatement =
                @"DELETE FROM Packages_Products_Suppliers WHERE PackageId = @id;
                DELETE FROM Packages WHERE PackageId = @id;";
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
            double PkgBasePrice, double PkgAgencyCommission,
            string PackageImageLocation, List<int> productsList)
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
            insertCommand.Parameters.AddWithValue("@PkgStartDate", PkgStartDate.Date);
            insertCommand.Parameters.AddWithValue("@PkgEndDate", PkgEndDate.Date);
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
                    insertProductCommand.Parameters.AddWithValue("@ProductSupplierId", productsList[i]);
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

        public void UpdatePackage(int PackageId, string PkgName, DateTime PkgStartDate,
            DateTime PkgEndDate, string PkgDesc,
            double PkgBasePrice, double PkgAgencyCommission,
            string PackageImageLocation, List<int> productsList)
        {
            string updateStatement =
                @"UPDATE Packages
                SET
                    PkgName = @PkgName,
                    PkgStartDate = @PkgStartDate,
                    PkgEndDate = @PkgEndDate,
                    PkgDesc = @PkgDesc,
                    PkgBasePrice = @PkgBasePrice,
                    PkgAgencyCommission = @PkgAgencyCommission,
                    PackageImageLocation = @PackageImageLocation
                WHERE PackageId = @PackageId";
            string deleteStatement =
                @"DELETE FROM Packages_Products_Suppliers WHERE PackageId = @PackageId";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand updateCommand = new SqlCommand(updateStatement, conn);
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);
            updateCommand.Parameters.AddWithValue("@PackageId", PackageId);
            updateCommand.Parameters.AddWithValue("@PkgName", PkgName);
            updateCommand.Parameters.AddWithValue("@PkgStartDate", PkgStartDate.Date);
            updateCommand.Parameters.AddWithValue("@PkgEndDate", PkgEndDate.Date);
            updateCommand.Parameters.AddWithValue("@PkgDesc", PkgDesc);
            updateCommand.Parameters.AddWithValue("@PkgBasePrice", PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@PkgAgencyCommission", PkgAgencyCommission);
            deleteCommand.Parameters.AddWithValue("@PackageId", PackageId);
            if (PackageImageLocation == null)
            {
                updateCommand.Parameters.AddWithValue("@PackageImageLocation", DBNull.Value);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@PackageImageLocation", PackageImageLocation);
            }
            try
            {
                conn.Open();
                //int count = insertCommand.ExecuteNonQuery();
                updateCommand.ExecuteNonQuery();
                deleteCommand.ExecuteNonQuery();
                conn.Close();

                for (int i = 0; i < productsList.Count; i++)
                {
                    string updateProductStatement =
                        @"INSERT INTO Packages_Products_Suppliers
                        VALUES (@PackageId, @ProductSupplierId)";
                    SqlCommand updateProductCommand = new SqlCommand(updateProductStatement, conn);
                    updateProductCommand.Parameters.AddWithValue("@PackageId", PackageId);
                    updateProductCommand.Parameters.AddWithValue("@ProductSupplierId", productsList[i]);
                    try
                    {
                        conn.Open();
                        updateProductCommand.ExecuteNonQuery();
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

        public List<Product> GetProduct()
        {
            string selectStatement =
                @"SELECT * FROM Products";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                List<Product> data = new List<Product>();

                while (reader.Read())
                {
                    Product p = new Product();
                    p.ProductId = Convert.ToInt32(reader["ProductId"]);
                    p.ProdName = reader["ProdName"].ToString();
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

        public List<Supplier> GetSuppliers()
        {
            string selectStatement =
                @"SELECT * FROM Suppliers";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
                List<Supplier> data = new List<Supplier>();

                while (reader.Read())
                {
                    Supplier p = new Supplier();
                    p.SupplierId = Convert.ToInt32(reader["SupplierId"]);
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

        public void InsertProduct(string ProdName)
        {
            string insertStatement =
                @"INSERT INTO Products (ProdName)
                VALUES (@ProdName)";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
            insertCommand.Parameters.AddWithValue("@ProdName", ProdName);
            try
            {
                conn.Open();
                int count = insertCommand.ExecuteNonQuery();
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

        public void InsertSupplier(int SupplierId, string SupName, int ProductId)
        {
            string insertSupplierStatement =
                @"INSERT INTO Suppliers (SupplierId, SupName)
                VALUES (@SupplierId, @SupName)";
            string insertProductsSupplierStatement =
                @"INSERT INTO Products_Suppliers (ProductId, SupplierId)
                VALUES (@ProductId, @SupplierId)";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand insertSupplierCommand = new SqlCommand(insertSupplierStatement, conn);
            SqlCommand insertProductsSupplierCommand = new SqlCommand(insertProductsSupplierStatement, conn);
            insertSupplierCommand.Parameters.AddWithValue("@SupplierId", SupplierId);
            insertSupplierCommand.Parameters.AddWithValue("@SupName", SupName);
            insertProductsSupplierCommand.Parameters.AddWithValue("@ProductId", ProductId);
            insertProductsSupplierCommand.Parameters.AddWithValue("@SupplierId", SupplierId);
            try
            {
                conn.Open();
                int supplierCount = insertSupplierCommand.ExecuteNonQuery();
                int productsSupplierCount = insertProductsSupplierCommand.ExecuteNonQuery();
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

        public void DeleteProduct(int ProductId)
        {
            string deleteStatement =
                @"DELETE FROM Products WHERE ProductId = @ProductId;";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);
            deleteCommand.Parameters.AddWithValue("@ProductId", ProductId);

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

        public void DeleteSupplier(int SupplierId)
        {
            string deleteSupplierStatement =
                @"DELETE FROM Suppliers WHERE SupplierId = @SupplierId;";
            string deleteProductsSupplierStatement =
                @"DELETE FROM Products_Suppliers WHERE SupplierId = @SupplierId;";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand deleteSupplierCommand = new SqlCommand(deleteSupplierStatement, conn);
            SqlCommand deleteProductsSupplierCommand = new SqlCommand(deleteProductsSupplierStatement, conn);
            deleteSupplierCommand.Parameters.AddWithValue("@SupplierId", SupplierId);
            deleteProductsSupplierCommand.Parameters.AddWithValue("@SupplierId", SupplierId);

            try
            {
                conn.Open();
                deleteProductsSupplierCommand.ExecuteNonQuery();
                deleteSupplierCommand.ExecuteNonQuery();
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

