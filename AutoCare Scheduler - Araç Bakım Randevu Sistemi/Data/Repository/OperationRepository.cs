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
    public class OperationRepository : IOperationRepository
    {
        // Veritabanı bağlantı dizesini depolar.
        private readonly string _connectionString;

        // Sınıfın kurucu metodunda veritabanı bağlantı dizesini alır ve atar.
        public OperationRepository()
        {
            _connectionString = Config.GetConnectionString();
        }

        // Yeni bir operasyon ekler.
        // Parametre olarak bir Operation nesnesi alır.
        // Geriye bir şey döndürmez.
        public void AddOperation(Operation operation)
        {
            try
            {
                // Veritabanına bağlanır ve yeni bir operasyon ekler.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Operation (Name, Price, Description) VALUES (@Name, @Price, @Description)", connection);
                cmd.Parameters.AddWithValue("@Name", operation.Name);
                cmd.Parameters.AddWithValue("@Price", operation.Price);
                cmd.Parameters.AddWithValue("@Description", operation.Description);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Hata durumunda log kaydı oluşturur.
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        // Tüm operasyonları getirir.
        // Geriye bir Liste<Operation> döndürür.
        public List<Operation> GetAllOperation()
        {
            try
            {
                // Veritabanından tüm operasyonları alır ve listeler.
                SqlConnection connection = new SqlConnection(_connectionString);
                List<Operation> operations = new List<Operation>();
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Operation", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Operation operation = new Operation
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Price = (double)Convert.ToDecimal(reader["Price"]),
                        Description = reader["Description"].ToString()
                    };
                    operations.Add(operation);
                }
                return operations;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Belirli bir operasyonu id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Operation nesnesi döndürür veya null döndürür.
        public Operation GetOperationById(int id)
        {
            try
            {
                // Veritabanından belirli bir operasyonu id'ye göre getirir.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Operation WHERE Id = @Id", connection);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                Operation operation = new Operation
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Price = (double)Convert.ToDecimal(reader["Price"]),
                    Description = reader["Description"].ToString()
                };
                return operation;
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
