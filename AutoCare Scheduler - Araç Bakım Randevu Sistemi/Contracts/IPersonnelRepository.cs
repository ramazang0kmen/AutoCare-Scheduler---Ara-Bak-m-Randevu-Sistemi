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
    public interface IPersonnelRepository
    {
        // Belirli bir personeli id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Personnel nesnesi döndürür veya null döndürür.
        Personnel GetPersonnelById(int id);

        // Belirli bir personeli kullanıcı adına göre getirir.
        // Parametre olarak bir kullanıcı adı alır.
        // Geriye bir Personnel nesnesi döndürür veya null döndürür.
        Personnel GetPersonnelByUsername(string username);

        // Tüm personelleri getirir.
        // Geriye bir Liste<Personnel> döndürür.
        List<Personnel> GetAllPersonnel();

        // Yeni bir personel ekler.
        // Parametre olarak bir Personnel nesnesi alır.
        void AddPersonnel(Personnel personnel);
    }
}

