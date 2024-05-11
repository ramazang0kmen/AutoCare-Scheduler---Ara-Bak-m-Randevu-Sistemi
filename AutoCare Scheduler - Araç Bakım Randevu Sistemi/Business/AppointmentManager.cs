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
    public class AppointmentManager
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentManager()
        {
            _appointmentRepository = new AppointmentRepository();
        }

        public void AddAppointment(Appointment appointment)
        {
            try
            {
                _appointmentRepository.AddAppointment(appointment);
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
                return _appointmentRepository.GetAllAppointment();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

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
