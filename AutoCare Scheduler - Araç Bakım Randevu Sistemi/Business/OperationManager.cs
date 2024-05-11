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
    public class OperationManager
    {
        private readonly IOperationRepository _operationRepository;

        // Constructor, bir IOperationRepository örneği oluşturur
        // ve _operationRepository alanına atar.
        public OperationManager()
        {
            _operationRepository = new OperationRepository();
        }

        // Yeni bir işlem (operation) ekler.
        // Parametre olarak bir Operation nesnesi alır.
        public void AddOperation(Operation operation)
        {
            try
            {
                _operationRepository.AddOperation(operation);
            }
            // Hata durumunda loglama yapar ve kullanıcıya bir hata kutusu gösterir.
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        // Tüm işlemleri (operations) getirir.
        // Geriye bir Liste<Operation> döndürür.
        public List<Operation> GetAllOperation()
        {
            try
            {
                return _operationRepository.GetAllOperation();
            }
            // Hata durumunda loglama yapar, kullanıcıya bir hata kutusu gösterir ve null döndürür.
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // Belirli bir işlemi (operation) id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Operation nesnesi döndürür veya null döndürür.
        public Operation GetOperationById(int id)
        {
            try
            {
                return _operationRepository.GetOperationById(id);
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

