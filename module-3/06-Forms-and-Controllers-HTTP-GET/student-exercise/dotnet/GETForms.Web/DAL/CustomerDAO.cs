using GETForms.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.DAL
{
    public class CustomerDAO : ICustomerDAO
    {
        private string connectionString;

        public CustomerDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Searches for customers.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="sortBy"></param>
        /// <returns></returns>
        public IList<Customer> SearchForCustomers(string search, string sortBy)
        {
            IList<Customer> customers= new List<Customer>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT first_name, last_name, email FROM customer WHERE last_name LIKE @last_name ORDER BY last_name", conn);

                cmd.Parameters.AddWithValue("@last_name", "%" + search + "%");
               

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    
                    Customer customer = new Customer()
                    {
                        FirstName = Convert.ToString(reader["first_name"]),

                        LastName = Convert.ToString(reader["last_name"]),

                        Email = Convert.ToString(reader["email"])
                    };
                }
            }
                    return customers;

        }
    }
}
