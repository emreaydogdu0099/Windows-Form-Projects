using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace HospitalManagementSystem
{
    public class PersonData
    {
        SQLiteConnection sqLiteConnection = new SQLiteConnection(@"Data Source=D:\projects\HospitalManagementSystem\Hastane.db");
        public List<Person> Listele(string bolum)
        {
            List<Person> personList = new List<Person>();
            sqLiteConnection.Open();
            string query = "SELECT * FROM Personel WHERE Bolum = '" + bolum + "'";
            SQLiteCommand sqLiteCommand = new SQLiteCommand(query, sqLiteConnection);
            SQLiteDataReader sqLiteDataReader = sqLiteCommand.ExecuteReader();
            while (sqLiteDataReader.Read())
            {
                Person person = new Person();
                person.Id = Convert.ToInt32(sqLiteDataReader["Id"]);
                person.Ad = sqLiteDataReader["Ad"].ToString();
                person.Soyad = sqLiteDataReader["Soyad"].ToString();
                person.Cinsiyet = sqLiteDataReader["Cinsiyet"].ToString();
                person.Dogum = Convert.ToInt32(sqLiteDataReader["Dogum"]);
                person.Tur = sqLiteDataReader["Tur"].ToString();
                person.Maas = Convert.ToDecimal(sqLiteDataReader["Maas"]);
                person.Izin = sqLiteDataReader["Izin"].ToString();
                person.Bolum = sqLiteDataReader["Bolum"].ToString();
                personList.Add(person);
            }
            sqLiteConnection.Close();
            return personList;
        }

        public void Ekle(Person person)
        {
            sqLiteConnection.Open();
            string query = "INSERT INTO Personel (Ad, Soyad, Cinsiyet, Dogum, Tur, Maas, Izin, Bolum) VALUES (@Ad, @Soyad, @Cinsiyet, @Dogum, @Tur, @Maas, @Izin, @Bolum)";
            SQLiteCommand sqLiteCommand = new SQLiteCommand(query, sqLiteConnection);
            sqLiteCommand.Parameters.AddWithValue("@Ad", person.Ad);
            sqLiteCommand.Parameters.AddWithValue("@Soyad", person.Soyad);
            sqLiteCommand.Parameters.AddWithValue("@Cinsiyet", person.Cinsiyet);
            sqLiteCommand.Parameters.AddWithValue("@Dogum", person.Dogum);
            sqLiteCommand.Parameters.AddWithValue("@Tur", person.Tur);
            sqLiteCommand.Parameters.AddWithValue("@Maas", person.Maas);
            sqLiteCommand.Parameters.AddWithValue("@Izin", person.Izin);
            sqLiteCommand.Parameters.AddWithValue("@Bolum", person.Bolum);
            sqLiteCommand.ExecuteNonQuery();
            sqLiteConnection.Close();
        }

        public void Sil(int id)
        {
            sqLiteConnection.Open();
            string query = "DELETE FROM Personel WHERE Id = @Id";
            SQLiteCommand sqLiteCommand = new SQLiteCommand(query, sqLiteConnection);
            sqLiteCommand.Parameters.AddWithValue("@Id", id);
            sqLiteCommand.ExecuteNonQuery();
            sqLiteConnection.Close();
        }

        public void Guncelle(Person person)
        {
            sqLiteConnection.Open();
            string query = "UPDATE Personel SET Ad = @Ad, Soyad = @Soyad, Cinsiyet = @Cinsiyet, Dogum = @Dogum, Tur = @Tur, Maas = @Maas, Izin = @Izin, Bolum = @Bolum WHERE Id = @Id";
            SQLiteCommand sqLiteCommand = new SQLiteCommand(query, sqLiteConnection);
            sqLiteCommand.Parameters.AddWithValue("@Id", person.Id);
            sqLiteCommand.Parameters.AddWithValue("@Ad", person.Ad);
            sqLiteCommand.Parameters.AddWithValue("@Soyad", person.Soyad);
            sqLiteCommand.Parameters.AddWithValue("@Cinsiyet", person.Cinsiyet);
            sqLiteCommand.Parameters.AddWithValue("@Dogum", person.Dogum);
            sqLiteCommand.Parameters.AddWithValue("@Tur", person.Tur);
            sqLiteCommand.Parameters.AddWithValue("@Maas", person.Maas);
            sqLiteCommand.Parameters.AddWithValue("@Izin", person.Izin);
            sqLiteCommand.Parameters.AddWithValue("@Bolum", person.Bolum);
            sqLiteCommand.ExecuteNonQuery();
            sqLiteConnection.Close();
        }
    }
}

