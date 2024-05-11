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
    public class PersonnelManager
    {
        private readonly IPersonnelRepository _personnelRepository;

        // Constructor, bir IPersonnelRepository örneği oluşturur
        // ve _personnelRepository alanına atar.
        public PersonnelManager()
        {
            _personnelRepository = new PersonnelRepository();
        }

        // Yeni bir personel ekler.
        // Parametre olarak bir Personnel nesnesi alır.
        public void AddPersonnel(Personnel personnel)
        {
            try
            {
                _personnelRepository.AddPersonnel(personnel);
            }
            // Hata durumunda loglama yapar ve kullanıcıya bir hata kutusu gösterir.
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        // Tüm personelleri getirir.
        // Geriye bir Liste<Personnel> döndürür.
        public List<Personnel> GetAllPersonnel()
        {
            try
            {
                return _personnelRepository.GetAllPersonnel();
            }
            // Hata durumunda loglama yapar, kullanıcıya bir hata kutusu gösterir ve null döndürür.
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Belirli bir personeli id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Personnel nesnesi döndürür veya null döndürür.
        public Personnel GetPersonnelById(int id)
        {
            try
            {
                return _personnelRepository.GetPersonnelById(id);
            }
            // Hata durumunda loglama yapar, kullanıcıya bir hata kutusu gösterir ve null döndürür.
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Kullanıcı adına göre bir personel getirir.
        // Parametre olarak bir kullanıcı adı alır.
        // Geriye bir Personnel nesnesi döndürür veya null döndürür.
        public Personnel GetPersonnelByUsername(string username)
        {
            try
            {
                return _personnelRepository.GetPersonnelByUsername(username);
            }
            // Hata durumunda loglama yapar, kullanıcıya bir hata kutusu gösterir ve null döndürür.
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }
    }
}

