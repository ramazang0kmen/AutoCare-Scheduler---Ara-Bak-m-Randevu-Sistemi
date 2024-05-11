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

using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Model;

namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Contracts
{
    public interface IAppointmentRepository
    {
        // Belirli bir randevuyu id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Appointment nesnesi döndürür veya null döndürür.
        Appointment GetAppointmentById(int id);

        // Tüm randevuları getirir.
        // Geriye bir Liste<Appointment> döndürür.
        List<Appointment> GetAllAppointment();

        // Yeni bir randevu ekler.
        // Parametre olarak bir Appointment nesnesi alır.
        void AddAppointment(Appointment appointment);

        // Mevcut bir randevuyu günceller.
        // Parametre olarak bir Appointment nesnesi alır.
        void UpdateAppointment(Appointment appointment);

        // Belirli bir randevuyu id'ye göre kaldırır.
        // Parametre olarak bir id alır.
        void RemoveAppointment(int id);
    }
}
