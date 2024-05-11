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
    public interface IOperationRepository
    {
        // Belirli bir işlemi id'ye göre getirir.
        // Parametre olarak bir id alır.
        // Geriye bir Operation nesnesi döndürür veya null döndürür.
        Operation GetOperationById(int id);

        // Tüm işlemleri getirir.
        // Geriye bir Liste<Operation> döndürür.
        List<Operation> GetAllOperation();

        // Yeni bir işlem ekler.
        // Parametre olarak bir Operation nesnesi alır.
        void AddOperation(Operation operation);
    }
}

