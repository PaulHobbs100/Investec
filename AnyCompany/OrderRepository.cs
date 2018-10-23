using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AnyCompany
{
    public class OrderRepository
    {
        private static string ConnectionString = @"Data Source=(local);Database=Investec;User Id=sa;Password=Hitman69;";

        public void Save(Order order)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO Orders VALUES (@OrderId, @Amount, @VAT)", connection);
            SqlCommand command = new SqlCommand("INSERT INTO Orders VALUES (@Amount, @VAT,@CustomerId)", connection);

            //command.Parameters.AddWithValue("@OrderId", order.OrderId);
            command.Parameters.AddWithValue("@Amount", order.Amount);
            command.Parameters.AddWithValue("@VAT", order.VAT);
            command.Parameters.AddWithValue("@CustomerId", order.CustomerId);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void LoadAll()
        {
           

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select CU.CustomerId,Country,DateOfBirth,OrderID, Amount,VAT,Name from Customers CU left join Orders OD on CU.CustomerID = OD.CustomerID order by CU.CustomerID",connection);
            SqlDataReader reader = command.ExecuteReader();

            List<CustomerOrders> allcustomerorders = new List<CustomerOrders>();
         
            while (reader.Read())
            {
   CustomerOrders item = new CustomerOrders();
            
                item.CustomerId = (int)reader["CustomerId"];
                item.Country = reader["Country"].ToString();
                item.DateOfBirth=DateTime.Parse("12/12/12");
                item.Name=reader["Name"].ToString();
                item.OrderId= (int)reader["orderid"];
                item.Amount = Convert.ToDouble(reader["Amount"]);
                item.VAT= Convert.ToDouble( reader["VAT"]);

                allcustomerorders.Add(item);
               
               
            }

            connection.Close();
            // just display test
            foreach(var items in allcustomerorders)
            {
                Console.Write($"{items.CustomerId}   {items.Country}  {items.DateOfBirth}   {items.Name}   {items.OrderId}   {items.Amount}    {items.VAT}");

                Console.WriteLine("");
            }
        }
    }
}
