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
        // Veritabanı bağlantı dizesini depolar.
        private readonly string _connectionString;

        // Sınıfın kurucu metodunda veritabanı bağlantı dizesini alır ve atar.
        public ServiceRepository()
        {
            _connectionString = Config.GetConnectionString();
        }

        // Yeni bir servis ekler.
        // Parametre olarak bir Service nesnesi alır.
        // Geriye bir şey döndürmez.
        public void AddService(Service service)
        {
            try
            {
                // Veritabanına bağlanır ve yeni bir servis ekler.
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
                // Hata durumunda log kaydı oluşturur.
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        // Tüm servisleri getirir.
        // Geriye bir Liste<Service> döndürür.
        public List<Service> GetAllService()
        {
            try
            {
                // Veritabanından tüm servisleri alır ve listeler.
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

        // Belirli bir servisleri id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Service nesnesi döndürür veya null döndürür.
        public Service GetServiceById(int id)
        {
            try
            {
                // Veritabanından belirli bir servisleri id'ye göre getirir.
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
