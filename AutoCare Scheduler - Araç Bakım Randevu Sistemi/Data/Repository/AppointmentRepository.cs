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
    public class AppointmentRepository : IAppointmentRepository
    {
        // Veritabanı bağlantı dizesini depolar.
        private readonly string _connectionString;

        // Sınıfın kurucu metodunda veritabanı bağlantı dizesini alır ve atar.
        public AppointmentRepository()
        {
            _connectionString = Config.GetConnectionString();
        }

        // Yeni bir randevu ekler.
        // Parametre olarak bir Appointment nesnesi alır.
        // Geriye bir şey döndürmez.
        public void AddAppointment(Appointment appointment)
        {
            try
            {
                // Veritabanına bağlanır ve yeni bir randevu ekler.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Appointment (CustomerId, ServiceId, OperationId, PersonnelId, Date, TotalPrice, Description) VALUES (@CustomerId, @ServiceId, @OperationId, @PersonnelId, @Date, @TotalPrice, @Description)", connection);
                command.Parameters.AddWithValue("@CustomerId", appointment.CustomerId);
                command.Parameters.AddWithValue("@ServiceId", appointment.ServiceId);
                command.Parameters.AddWithValue("@OperationId", appointment.OperationId);
                command.Parameters.AddWithValue("@PersonnelId", appointment.PersonnelId);
                command.Parameters.AddWithValue("@Date", appointment.Date);
                command.Parameters.AddWithValue("@TotalPrice", appointment.TotalPrice);
                command.Parameters.AddWithValue("@Description", appointment.Description);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Hata durumunda log kaydı oluşturur.
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        // Tüm randevuları getirir.
        // Geriye bir Liste<Appointment> döndürür.
        public List<Appointment> GetAllAppointment()
        {
            try
            {
                // Veritabanından tüm randevuları alır ve listeler.
                List<Appointment> appointments = new List<Appointment>();
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Appointment", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Appointment appointment = new Appointment
                    {
                        Id = (int)reader["Id"],
                        CustomerId = (int)reader["CustomerId"],
                        ServiceId = (int)reader["ServiceId"],
                        PersonnelId = (int)reader["PersonnelId"],
                        OperationId = (int)reader["OperationId"],
                        Date = (DateTime)reader["Date"],
                        TotalPrice = (decimal)reader["TotalPrice"],
                        Description = reader["Description"].ToString()
                    };
                    appointments.Add(appointment);
                }
                return appointments;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Belirli bir randevuyu id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Appointment nesnesi döndürür veya null döndürür.
        public Appointment GetAppointmentById(int id)
        {
            try
            {
                // Veritabanından belirli bir randevuyu id'ye göre getirir.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Appointment WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Appointment appointment = new Appointment
                    {
                        Id = (int)reader["Id"],
                        CustomerId = (int)reader["CustomerId"],
                        ServiceId = (int)reader["ServiceId"],
                        PersonnelId = (int)reader["PersonnelId"],
                        OperationId = (int)reader["OperationId"],
                        Date = (DateTime)reader["Date"],
                        TotalPrice = (decimal)reader["TotalPrice"],
                        Description = reader["Description"].ToString()
                    };
                    return appointment;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Belirli bir randevuyu siler.
        // Parametre olarak bir id alır.
        // Geriye bir şey döndürmez.
        public void RemoveAppointment(int id)
        {
            try
            {
                // Veritabanından belirli bir randevuyu siler.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Appointment WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        // Bir randevuyu günceller.
        // Parametre olarak bir Appointment nesnesi alır.
        // Geriye bir şey döndürmez.
        public void UpdateAppointment(Appointment appointment)
        {
            try
            {
                // Veritabanında bir randevuyu günceller.
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Appointment SET CustomerId = @CustomerId, ServiceId = @ServiceId, PersonnelId = @PersonnelId, Date = @Date, TotalPrice = @TotalPrice, Description = @Description WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", appointment.Id);
                command.Parameters.AddWithValue("@CustomerId", appointment.CustomerId);
                command.Parameters.AddWithValue("@ServiceId", appointment.ServiceId);
                command.Parameters.AddWithValue("@PersonnelId", appointment.PersonnelId);
                command.Parameters.AddWithValue("@OperationId", appointment.OperationId);
                command.Parameters.AddWithValue("@Date", appointment.Date);
                command.Parameters.AddWithValue("@TotalPrice", appointment.TotalPrice);
                command.Parameters.AddWithValue("@Description", appointment.Description);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }
    }
}
