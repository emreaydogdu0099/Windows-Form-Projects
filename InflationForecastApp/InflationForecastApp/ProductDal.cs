using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace InflationForecastApp
{
    public class ProductDal
    {
        readonly MySqlConnection _connection = new MySqlConnection(@"server=localhost;port=3306;database=InflationForecastDb;uid=root");
        double _inflationRate;
        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Product> GetAll()
        {
            OpenConnection();
            MySqlCommand command = new MySqlCommand("Select * from Products", _connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Category = reader["Category"].ToString(),
                    OldPrice = Convert.ToDouble(reader["OldPrice"]),
                    NewPrice = Convert.ToDouble(reader["NewPrice"]),
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }
        public void Add(Product product)
        {
            OpenConnection();
            MySqlCommand command = new MySqlCommand("Insert into Products (Name, Category, OldPrice, NewPrice) values (@name, @category, @oldPrice, @newPrice)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@category", product.Category);
            command.Parameters.AddWithValue("@oldPrice", product.OldPrice);
            command.Parameters.AddWithValue("@newPrice", product.NewPrice);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Update(Product product)
        {
            OpenConnection();
            MySqlCommand command = new MySqlCommand("Update Products set Name=@name, Category=@category, OldPrice=@oldPrice, NewPrice=@newPrice where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@category", product.Category);
            command.Parameters.AddWithValue("@oldPrice", product.OldPrice);
            command.Parameters.AddWithValue("@newPrice", product.NewPrice);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Delete(int id)
        {
            OpenConnection();
            MySqlCommand command = new MySqlCommand("Delete from Products where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public double GetInflationRate()
        {
            OpenConnection();
            MySqlCommand command = new MySqlCommand("Select * from Products", _connection);
            MySqlDataReader reader = command.ExecuteReader();
            // Ürünlerin newPrice değerlerinin toplamı
            double newPriceSum = 0;
            // Ürünlerin oldPrice değerlerinin toplamı
            double oldPriceSum = 0;
            while (reader.Read())
            {
                newPriceSum += Convert.ToDouble(reader["NewPrice"]);
                oldPriceSum += Convert.ToDouble(reader["OldPrice"]);
            }
            reader.Close();
            _connection.Close();
            // Enflasyon oranı hesaplanıyor
            _inflationRate = (newPriceSum - oldPriceSum) / oldPriceSum * 100;
            // virgülden sonra 2 basamak gösteriliyor
            _inflationRate = Math.Round(_inflationRate, 2);
            return _inflationRate;
        }
    }
    
}
