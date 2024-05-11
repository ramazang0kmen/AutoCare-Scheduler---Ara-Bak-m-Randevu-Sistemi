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
        private readonly string _connectionString;

        public OperationRepository()
        {
            _connectionString = Config.GetConnectionString();
        }

        public void AddOperation(Operation operation)
        {
            try
            {
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
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        public List<Operation> GetAllOperation()
        {
            try
            {
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

        public Operation GetOperationById(int id)
        {
            try
            {
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
