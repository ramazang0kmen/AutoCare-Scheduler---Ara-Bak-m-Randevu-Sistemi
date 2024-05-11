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
        private readonly string _connectionString;

        public PersonnelRepository()
        {
            _connectionString = Config.GetConnectionString();
        }

        public void AddPersonnel(Personnel personnel)
        {
            try
            {
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
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        public List<Personnel> GetAllPersonnel()
        {
            try
            {
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

        public Personnel GetPersonnelById(int id)
        {
            try
            {
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

        public Personnel GetPersonnelByUsername(string username)
        {
            try
            {
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
