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
    public class CustomerRepository : ICustomerRepository
    {
        // Veritabanı bağlantı dizesini depolar.
        private readonly string _connectionString;

        // Sınıfın kurucu metodunda veritabanı bağlantı dizesini alır ve atar.
        public CustomerRepository()
        {
            _connectionString = Config.GetConnectionString();
        }

        // Yeni bir müşteri ekler.
        // Parametre olarak bir Customer nesnesi alır.
        // Geriye bir şey döndürmez.
        public void AddCustomer(Customer customer)
        {
            try
            {
                // Veritabanına bağlanır ve yeni bir müşteri ekler.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer (NameSurname, PhoneNumber, EmailAddress, Address) VALUES (@NameSurname, @PhoneNumber, @EmailAddress, @Address)", connection);
                cmd.Parameters.AddWithValue("@NameSurname", customer.NameSurname);
                cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                cmd.Parameters.AddWithValue("@EmailAddress", customer.EmailAddress);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Hata durumunda log kaydı oluşturur.
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        // Tüm müşterileri getirir.
        // Geriye bir Liste<Customer> döndürür.
        public List<Customer> GetAllCustomer()
        {
            try
            {
                // Veritabanından tüm müşterileri alır ve listeler.
                SqlConnection connection = new SqlConnection(_connectionString);
                List<Customer> customers = new List<Customer>();
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        NameSurname = reader["NameSurname"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        EmailAddress = reader["EmailAddress"].ToString(),
                        Address = reader["Address"].ToString()
                    };
                    customers.Add(customer);
                }
                return customers;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Belirli bir müşteriyi id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Customer nesnesi döndürür veya null döndürür.
        public Customer GetCustomerById(int id)
        {
            try
            {
                // Veritabanından belirli bir müşteriyi id'ye göre getirir.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE Id = @Id", connection);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                Customer customer = new Customer();
                while (reader.Read())
                {
                    customer.Id = Convert.ToInt32(reader["Id"]);
                    customer.NameSurname = reader["NameSurname"].ToString();
                    customer.PhoneNumber = reader["PhoneNumber"].ToString();
                    customer.EmailAddress = reader["EmailAddress"].ToString();
                    customer.Address = reader["Address"].ToString();
                }
                return customer;
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
