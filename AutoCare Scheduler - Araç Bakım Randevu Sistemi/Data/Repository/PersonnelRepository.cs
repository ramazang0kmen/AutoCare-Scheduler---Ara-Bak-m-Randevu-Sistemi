/****************************************************************************
** DÜZCE ÜNİVERSİTESİ
** Lisansüstü Eğitim Enstitüsü
** Yüksek Lisans Enstitüsü Anabilim Dalı Bilgisayar Mühendisliği BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2023-2024 BAHAR DÖNEMİ
**
**
** ÖĞRENCİ ADI............: RAMAZAN GÖKMEN
** ÖĞRENCİ NUMARASI.......: 2345007015
** DERSİN ALINDIĞI GRUP...:
****************************************************************************/

using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Contracts;
using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Helpers;
using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Model;
using System.Data.SqlClient;

namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Data.Repository
{
    public class PersonnelRepository : IPersonnelRepository
    {
        // Veritabanı bağlantı dizesini depolar.
        private readonly string _connectionString;

        public PersonnelRepository()
        {
            // Sınıfın kurucu metodunda veritabanı bağlantı dizesini alır ve atar.
            _connectionString = Config.GetConnectionString();
        }

        // Yeni bir personel ekler.
        // Parametre olarak bir Personnel nesnesi alır.
        // Geriye bir şey döndürmez.
        public void AddPersonnel(Personnel personnel)
        {
            try
            {
                // Veritabanına bağlanır ve yeni bir personel ekler.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                string query = "INSERT INTO Personnel (username, Password, NameSurname, Department) VALUES (@username, @Password, @NameSurname, @Department)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", personnel.Username);
                command.Parameters.AddWithValue("@Password", personnel.Password);
                command.Parameters.AddWithValue("@NameSurname", personnel.NameSurname);
                command.Parameters.AddWithValue("@Department", personnel.Department);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Hata durumunda log kaydı oluşturur.
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        // Tüm personelleri getirir.
        // Geriye bir Liste<Personnel> döndürür.
        public List<Personnel> GetAllPersonnel()
        {
            try
            {
                // Veritabanından tüm müşterileri alır ve listeler.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Personnel", connection);
                SqlDataReader reader = command.ExecuteReader();
                List<Personnel> personnels = new List<Personnel>();
                while (reader.Read())
                {
                    personnels.Add(new Personnel
                    {
                        Id = (int)reader["Id"],
                        Username = (string)reader["username"],
                        Password = (string)reader["Password"],
                        NameSurname = (string)reader["NameSurname"],
                        Department = (string)reader["Department"]
                    });
                }
                connection.Close();
                return personnels;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Belirli bir personeli id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Personnel nesnesi döndürür veya null döndürür.
        public Personnel GetPersonnelById(int id)
        {
            try
            {
                // Veritabanından belirli bir personeli id'ye göre getirir.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Personnel WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = command.ExecuteReader();
                Personnel personnel = new Personnel();
                while (reader.Read())
                {
                    personnel.Id = (int)reader["Id"];
                    personnel.Username = (string)reader["Username"];
                    personnel.Password = (string)reader["Password"];
                    personnel.NameSurname = (string)reader["NameSurname"];
                    personnel.Department = (string)reader["Department"];
                }
                connection.Close();
                return personnel;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Belirli bir personeli username'e göre getirir.
        // Parametre olarak bir username alır.
        // Geriye bir Personnel nesnesi döndürür veya null döndürür.
        public Personnel GetPersonnelByUsername(string username)
        {
            try
            {
                // Veritabanından belirli bir personeli username'e göre getirir.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Personnel WHERE username = @username", connection);
                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                Personnel personnel = new Personnel();
                while (reader.Read())
                {
                    personnel.Id = (int)reader["Id"];
                    personnel.Username = (string)reader["Username"];
                    personnel.Password = (string)reader["Password"];
                }
                connection.Close();
                return personnel;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }
    }
}
