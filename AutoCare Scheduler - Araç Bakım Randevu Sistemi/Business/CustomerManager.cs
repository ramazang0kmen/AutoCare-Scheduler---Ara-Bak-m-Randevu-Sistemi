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
    public class CustomerManager
    {
        private readonly ICustomerRepository _customerRepository;

        // Constructor, bir ICustomerRepository örneği oluşturur
        // ve _customerRepository alanına atar.
        public CustomerManager()
        {
            _customerRepository = new CustomerRepository();
        }

        // Yeni bir müşteri ekler.
        // Parametre olarak bir Customer nesnesi alır.
        public void AddCustomer(Customer customer)
        {
            try
            {
                _customerRepository.AddCustomer(customer);
            }
            // Hata durumunda loglama yapar ve kullanıcıya bir hata kutusu gösterir.
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        // Tüm müşterileri getirir.
        // Geriye bir Liste<Customer> döndürür.
        public List<Customer> GetAllCustomer()
        {
            try
            {
                return _customerRepository.GetAllCustomer();
            }
            // Hata durumunda loglama yapar, kullanıcıya bir hata kutusu gösterir ve null döndürür.
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Belirli bir müşteriyi id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Customer nesnesi döndürür veya null döndürür.
        public Customer GetCustomerById(int id)
        {
            try
            {
                return _customerRepository.GetCustomerById(id);
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

