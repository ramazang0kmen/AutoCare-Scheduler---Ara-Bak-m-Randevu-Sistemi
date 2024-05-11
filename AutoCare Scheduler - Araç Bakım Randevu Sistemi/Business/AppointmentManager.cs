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
using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Data.Repository;
using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Helpers;
using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Model;

namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Business
{
    // Constructor, bir IAppointmentRepository örneği oluşturur
    // ve _appointmentRepository alanına atar.
    public class AppointmentManager
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentManager()
        {
            _appointmentRepository = new AppointmentRepository();
        }

        // Yeni bir randevu ekler.
        // Parametre olarak bir Appointment nesnesi alır.
        public void AddAppointment(Appointment appointment)
        {
            try
            {
                _appointmentRepository.AddAppointment(appointment);
            }
            // Hata durumunda loglama yapar ve kullanıcıya bir hata kutusu gösterir.
            catch (Exception ex)
            {
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
                return _appointmentRepository.GetAllAppointment();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Bir randevuyu günceller.
        // Parametre olarak bir Appointment nesnesi alır.
        public void UpdateAppointment(Appointment appointment)
        {
            try
            {
                _appointmentRepository.UpdateAppointment(appointment);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return;
            }
        }

        // Bir randevuyu kaldırır.
        // Parametre olarak bir id alır.
        public void RemoveAppointment(int id)
        {
            try
            {
                _appointmentRepository.RemoveAppointment(id);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        // Belirli bir randevuyu id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Appointment nesnesi döndürür veya null döndürür.
        public Appointment GetAppointmentById(int id)
        {
            try
            {
                return _appointmentRepository.GetAppointmentById(id);
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
