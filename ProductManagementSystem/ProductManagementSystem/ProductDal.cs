using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection("Server=.;initial catalog=ProductDb;integrated security=true");

        // Eğer veritabanı bağlantısı açık değilse bu fonksiyon ile açılır.
        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        // Kategoriye göre ürünleri listeleme
        public List<Product> GetByCategory(string categoryName)
        {
            OpenConnection();
            // Veritabanında categories tablosundaki kategori isminden category id alınır ve products tablosundan bu id'ye göre ürün getirilir.
            SqlCommand command = new SqlCommand($"Select * from Products where CategoryId = (Select Id from Categories where Name = '{categoryName}')", _connection);
            // SqlDataReader ile veriler okunur.
            SqlDataReader reader = command.ExecuteReader();
            // Ürünlerin listesi oluşturulur.
            List<Product> products = new List<Product>();
            // Okunan verilerin listeye eklenmesi
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }

        // Sepete ürün ekleme
        public void AddToCart(string name, int count, decimal price)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand($"Insert into Cart (Name,Count,Price) values ('{name}','{count}','{price}')", _connection);
            // Ekleme işlemi gerçekleştirilir.
            command.ExecuteNonQuery();
            _connection.Close();
        }

        // Sepetteki ürünleri listeleme
        public List<CartProducts> GetCart()
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("Select * from Cart", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<CartProducts> carts = new List<CartProducts>();
            while (reader.Read())
            {
                CartProducts cart = new CartProducts
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Count = Convert.ToInt32(reader["Count"]),
                    Price = Convert.ToDecimal(reader["Price"]),
                };
                carts.Add(cart);
            }
            reader.Close();
            _connection.Close();
            return carts;
        }
        
        // Sepetteki ürünlerin toplam fiyatını hesaplama
        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            OpenConnection();
            SqlCommand command = new SqlCommand("Select SUM(Price*Count) from Cart", _connection);
            try
            {
                // Toplam fiyatı okur.
                totalPrice = Convert.ToDecimal(command.ExecuteScalar());
            }
            catch (System.Exception)
            {
                return 0;
            }
            _connection.Close();
            return totalPrice;
        }

        // Sepetten ürün silme
        public void DeleteFromCart(int id)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand($"Delete from Cart where Id = '{id}'", _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }
       
        // Sepetteki ürünlerin tamamını silme
        public void ClearCart()
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("Delete from Cart", _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}