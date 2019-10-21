using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Model;

namespace StockManagement.Repository
{
    public class ProductRepository
    {
        public bool AddProduct(Product product)
        {
            string commandString = @"INSERT INTO Products (CategoryID, Code, Name, ReOrderLevel, Description) VALUES('"+product.CategoryID+"', '" + product.Code + "','" + product.Name + "', "+product.ReOrderLevel+", '"+product.Description+"')";
            SqlConnection sqlConnection = null;

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            sqlConnection.Open();

            bool isAdded = connection.ExecuteQueries(commandString);

            sqlConnection.Close();

            return isAdded;
        }

        public List<Category> Display()
        {
            List<Category> categories = new List<Category>();

            string commandString = @"SELECT * FROM Products";
            SqlConnection sqlConnection = null;

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();


            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Category category = new Category();

                category.ID = Convert.ToInt32(sqlDataReader["ID"]);
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();

                categories.Add(category);
            }

            sqlConnection.Close();

            return categories;
        }

     
    }
}
