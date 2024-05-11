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
    public class ServiceRepository : IServiceRepository
    {
        private readonly string _connectionString;

        public ServiceRepository()
        {
            _connectionString = Config.GetConnectionString();
        }

        public void AddService(Service service)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                string query = "INSERT INTO Service (Name, Address) VALUES (@Name, @Address)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", service.Name);
                command.Parameters.AddWithValue("@Address", service.Address);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        public List<Service> GetAllService()
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                string query = "SELECT * FROM Service";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<Service> services = new List<Service>();
                while (reader.Read())
                {
                    Service service = new Service
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString()
                    };
                    services.Add(service);
                }
                connection.Close();
                return services;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        public Service GetServiceById(int id)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                string query = "SELECT * FROM Service WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = command.ExecuteReader();
                Service service = new Service();
                while (reader.Read())
                {
                    service.Id = Convert.ToInt32(reader["Id"]);
                    service.Name = reader["Name"].ToString();
                    service.Address = reader["Address"].ToString();
                }
                connection.Close();
                return service;
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
