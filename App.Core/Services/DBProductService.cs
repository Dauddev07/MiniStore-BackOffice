using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace App.Core.Services
{
    public class DBProductService : IProductService
    {
        private readonly String _connectionString;
        public DBProductService(String connString)
        {
            _connectionString = connString;
        }
        Product IProductService.Add(Product product)
        {
            product.Id = "p-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string sql = "INSERT INTO Product(Id,Name,Category,Price,Stock,Status) VALUES (@Id, @Name, @Cat, @Price, @Stock, @Status)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Cat", product.Category.ToString());
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Status", product.Status.ToString());
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    return product;
                else
                    return null;
            }
        }

        bool IProductService.Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Product WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
        bool IProductService.Update(Product product)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "UPDATE Product SET Name=@Name, Category=@Cat, Price=@Price, Stock=@Stock, Status=@Status WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Cat", product.Category.ToString());
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Status", product.Status.ToString());
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
        Product IProductService.GetById(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Product WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Product prod = new Product();
                        prod.Id = reader.GetString(reader.GetOrdinal("Id"));
                        prod.Name = reader["Name"].ToString();

                        string catStr = reader["Category"].ToString();
                        prod.Category = Enum.TryParse<ProductCategoryEnum>(catStr, ignoreCase: true, out var catParsed) ? catParsed : ProductCategoryEnum.None;
                        prod.Price = Convert.ToDecimal(reader["Price"]);

                        prod.Stock = reader.GetInt32(reader.GetOrdinal("Stock"));
                        string statusStr = reader["Status"].ToString();
                        prod.Status = Enum.TryParse<ProductStatusEnum>(statusStr, ignoreCase: true, out var statusParsed) ? statusParsed : ProductStatusEnum.Active;
                        return prod;
                    }
                }
            }
            return null;
        }

        List<Product> IProductService.GetAll()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Product", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.Id = reader.GetString(reader.GetOrdinal("Id"));
                        prod.Name = reader["Name"].ToString();

                        string catStr = reader["Category"].ToString();
                        prod.Category = Enum.TryParse<ProductCategoryEnum>(catStr, ignoreCase: true, out var catParsed) ? catParsed : ProductCategoryEnum.None;
                        prod.Price = Convert.ToDecimal(reader["Price"]);

                        prod.Stock = reader.GetInt32(reader.GetOrdinal("Stock"));
                        string statusStr = reader["Status"].ToString();
                        prod.Status = Enum.TryParse<ProductStatusEnum>(statusStr, ignoreCase: true, out var statusParsed) ? statusParsed : ProductStatusEnum.Active;
                        products.Add(prod);
                    }

                }
            }
            return products;
        }

       

        //List<Product> IProductService.Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        async Task<List<Product>> IProductService.SearchAsync(string text, ProductCategoryEnum? category, ProductStatusEnum? status)

        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //conn.Open();
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string sql = "SELECT * FROM Product WHERE NAME LIKE @name";
                //cmd.CommandText = sql;
                //cmd.Parameters.AddWithValue

                if (category != null)
                {
                    sql += " AND Category=@cat";
                }

                if (status != null)
                {
                    sql += " AND Status=@status";
                }
                cmd.Connection = conn;
                cmd.CommandText = sql;


                cmd.Parameters.AddWithValue("@name", "%" + text.Trim() + "%");

                if (category != null)
                    cmd.Parameters.AddWithValue("@cat", category.ToString());

                if (status != null)
                    cmd.Parameters.AddWithValue("@status", status.ToString());
                // using (SqlDataReader reader = cmd.ExecuteReader())
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    // while (reader.Read())
                    while (await reader.ReadAsync())
                    {
                        Product prod = new Product();
                        prod.Id = reader.GetString(reader.GetOrdinal("Id"));
                        prod.Name = reader["Name"].ToString();

                        string catStr = reader["Category"].ToString();
                        prod.Category = Enum.TryParse<ProductCategoryEnum>(catStr, ignoreCase: true, out var catParsed) ? catParsed : ProductCategoryEnum.None;
                        prod.Price = Convert.ToDecimal(reader["Price"]);

                        prod.Stock = reader.GetInt32(reader.GetOrdinal("Stock"));
                        string statusStr = reader["Status"].ToString();
                        prod.Status = Enum.TryParse<ProductStatusEnum>(statusStr, ignoreCase: true, out var statusParsed) ? statusParsed : ProductStatusEnum.Active;
                        products.Add(prod);
                    }

                }


            }
            return products;

        }

        
    }
}