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

        public PersonnelManager()
        {
            _personnelRepository = new PersonnelRepository();
        }

        public void AddPersonnel(Personnel personnel)
        {
            try
            {
                _personnelRepository.AddPersonnel(personnel);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        public List<Personnel> GetAllPersonnel()
        {
            try
            {
                return _personnelRepository.GetAllPersonnel();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        public Personnel GetPersonnelById(int id)
        {
            try
            {
                return _personnelRepository.GetPersonnelById(id);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        public Personnel GetPersonnelByUsername(string username)
        {
            try
            {
                return _personnelRepository.GetPersonnelByUsername(username);
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
