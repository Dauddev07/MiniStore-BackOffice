using App.Core.Contracts;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class DBCustomerService : ICustomerService
    {
        private readonly string _connectionString;

        public DBCustomerService(string connString)
        {
            _connectionString = connString;
        }

        void ICustomerService.Add(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Customer (Id, Name, Phone, Email, Address)
                               VALUES (@Id, @Name, @Phone, @Email, @Address)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", customer.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", customer.Address ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }
        void ICustomerService.Update(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"UPDATE Customer
                               SET Name=@Name, Phone=@Phone, Email=@Email, Address=@Address
                               WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", customer.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", customer.Address ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }
        void ICustomerService.Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Customer WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        Customer ICustomerService.GetById(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Customer WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return MapCustomer(reader);
                }
            }
            return null;
        }
        List<Customer> ICustomerService.GetAll()
        {
            List<Customer> list = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(MapCustomer(reader));
                }
            }
            return list;
        }
        List<Customer> ICustomerService.Search(string query)
        {
            List<Customer> list = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"SELECT * FROM Customer
                               WHERE Name  LIKE @q
                                  OR Phone LIKE @q
                                  OR Email LIKE @q";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@q", "%" + query.Trim() + "%");
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(MapCustomer(reader));
                }
            }
            return list;
        }

    
        private Customer MapCustomer(SqlDataReader reader)
        {
            Customer c = new Customer();
            c.Id = reader["Id"].ToString();
            c.Name = reader["Name"].ToString();
            c.Phone = reader["Phone"] == DBNull.Value ? null : reader["Phone"].ToString();
            c.Email = reader["Email"] == DBNull.Value ? null : reader["Email"].ToString();
            c.Address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString();
            return c;
        }
    }
}
//main form=>button click=>products view=>db product service
//agr 1 method async to peechay tk async hoga
//10.2 section of notes
//implement atleast 1 method search or anyother..changes in interface(iproductservice),dbproductservice,productview
//& mainform
//sync=>screen freeze,async=>no freeze
//how to check delay=>where query is written(delay etc)add "WAITFOR DELAY 'time'"
//what are adv features of project,on what basis project is build