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
    public class ServiceManager
    {
        private readonly IServiceRepository _serviceRepository;

        // Constructor, bir IServiceRepository örneği oluşturur
        // ve _serviceRepository alanına atar.
        public ServiceManager()
        {
            _serviceRepository = new ServiceRepository();
        }

        // Yeni bir hizmet ekler.
        // Parametre olarak bir Service nesnesi alır.
        public void AddService(Service service)
        {
            try
            {
                _serviceRepository.AddService(service);
            }
            // Hata durumunda loglama yapar ve kullanıcıya bir hata kutusu gösterir.
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        // Tüm hizmetleri getirir.
        // Geriye bir Liste<Service> döndürür.
        public List<Service> GetAllServices()
        {
            try
            {
                return _serviceRepository.GetAllService();
            }
            // Hata durumunda loglama yapar, kullanıcıya bir hata kutusu gösterir ve null döndürür.
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Belirli bir hizmeti id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Service nesnesi döndürür veya null döndürür.
        public Service GetServiceById(int id)
        {
            try
            {
                return _serviceRepository.GetServiceById(id);
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

