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
    public interface ICustomerRepository
    {
        // Belirli bir müşteriyi id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Customer nesnesi döndürür veya null döndürür.
        Customer GetCustomerById(int id);

        // Tüm müşterileri getirir.
        // Geriye bir Liste<Customer> döndürür.
        List<Customer> GetAllCustomer();

        // Yeni bir müşteri ekler.
        // Parametre olarak bir Customer nesnesi alır.
        void AddCustomer(Customer customer);
    }
}

