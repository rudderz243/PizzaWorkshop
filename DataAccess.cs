using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace PizzaFactory
{
    public class DataAccess
    {
        static string connectionString = "Data Source = <your_db_link>; Initial Catalog = <your_db_name>; User id = <your_sql_auth_username>; Password=<your_sql_auth_password>";
        static SqlConnection databaseConnection = new SqlConnection(connectionString);
        static SqlCommand command;

        public void SignUp(string email, string password, string name)
        {
            databaseConnection.Open();
            string sql = $"INSERT INTO Users(name, email, password, staff) VALUES (@name, @email, @password, @staff)";
            command = new SqlCommand(sql, databaseConnection);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@staff", "no");
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public User LoginUser(string email, string password)
        {
            databaseConnection.Open();
            string sql = "SELECT * FROM Users WHERE email = @email AND password = @password";
            command = new SqlCommand(sql, databaseConnection);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            databaseConnection.Close();
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                User temp = new User
                {
                    email = dataTable.Rows[0]["email"].ToString(),
                    name = dataTable.Rows[0]["name"].ToString(),
                    staff = dataTable.Rows[0]["staff"].ToString().Equals("yes"),
                    id = Convert.ToInt32(dataTable.Rows[0]["userID"].ToString())
                };
                return temp;
            }
        }

        public List<Pizza> GetAllPizzas()
        {
            List<Pizza> menu = new List<Pizza>();
            databaseConnection.Open();
            string sql = "SELECT * FROM Menu";
            command = new SqlCommand(sql, databaseConnection);
            command.ExecuteNonQuery();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            databaseConnection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                menu.Add(new Pizza
                {
                    pizzaID = Convert.ToInt32(row["pizzaID"].ToString()),
                    name = row["name"].ToString(),
                    description = row["description"].ToString(),
                    price = Convert.ToDouble(row["price"].ToString()),
                    imageURL = row["imageURL"].ToString()
                });
            }
            return menu;
        }

        public void SubmitOrder(List<Pizza> cart)
        {
            double total = 0;
            string orderString = "";
            foreach (Pizza item in cart)
            {
                total += item.price;
                orderString += $"{item.name},";
            }


            databaseConnection.Open();
            string sql = "INSERT INTO Orders VALUES (@orderTime, @orderTotal, @orderDetails, @userID, @status)";
            command = new SqlCommand(sql, databaseConnection);
            command.Parameters.AddWithValue("@orderTime", DateTime.Now);
            command.Parameters.AddWithValue("@orderTotal", total);
            command.Parameters.AddWithValue("@orderDetails", orderString);
            command.Parameters.AddWithValue("@userID", UserHolder.loggedInUser.id);
            command.Parameters.AddWithValue("@status", "open");
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            databaseConnection.Open();
            string sql = "SELECT * FROM Orders";
            command = new SqlCommand(sql, databaseConnection);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            databaseConnection.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                orders.Add(new Order
                {
                    orderID = Convert.ToInt32(row["orderID"].ToString()),
                    orderTime = DateTime.Parse(row["orderTime"].ToString()),
                    orderTotal = Double.Parse(row["orderTotal"].ToString()),
                    orderDetails = row["orderDetails"].ToString(),
                    userID = Convert.ToInt32(row["userID"].ToString()),
                    status = row["status"].ToString()

                });
            }
            return orders;
        }

        public List<Order> GetUserOrders(int userID)
        {
            List<Order> orders = new List<Order>();
            databaseConnection.Open();
            string sql = "SELECT * FROM Orders WHERE userID = @userID";
            command = new SqlCommand(sql, databaseConnection);
            command.Parameters.AddWithValue("@userID", userID);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            databaseConnection.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                orders.Add(new Order
                {
                    orderID = Convert.ToInt32(row["orderID"].ToString()),
                    orderTime = DateTime.Parse(row["orderTime"].ToString()),
                    orderTotal = Double.Parse(row["orderTotal"].ToString()),
                    orderDetails = row["orderDetails"].ToString(),
                    userID = Convert.ToInt32(row["userID"].ToString()),
                    status = row["status"].ToString()

                });
            }
            return orders;
        }

        public void UpdateOrder(int orderID, string updatedStatus)
        {
            databaseConnection.Open();
            string sql = "UPDATE Orders SET status = @updatedStatus WHERE orderid = @orderID";
            command = new SqlCommand(sql, databaseConnection);
            command.Parameters.AddWithValue("@updatedStatus", updatedStatus);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public void AddNewPizza(Pizza item)
        {
            databaseConnection.Open();
            string sql = "INSERT INTO Menu VALUES (@name, @description, @price, @imageURL)";
            command = new SqlCommand(sql, databaseConnection);
            command.Parameters.AddWithValue("@name", item.name);
            command.Parameters.AddWithValue("@description", item.description);
            command.Parameters.AddWithValue("@price", item.price);
            command.Parameters.AddWithValue("@imageURl", item.imageURL);
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }
    }
}