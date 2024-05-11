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
        private readonly string _connectionString;

        public AppointmentRepository()
        {
            _connectionString = Config.GetConnectionString();
        }

        public void AddAppointment(Appointment appointment)
        {
            try
            {
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
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        public List<Appointment> GetAllAppointment()
        {
            try
            {
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

        public Appointment GetAppointmentById(int id)
        {
            try
            {
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

        public void RemoveAppointment(int id)
        {
            try
            {
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

        public void UpdateAppointment(Appointment appointment)
        {
            try
            {
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
