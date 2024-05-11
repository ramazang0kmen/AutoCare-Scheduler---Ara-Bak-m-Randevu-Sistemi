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

namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Model
{
    // Operation sınıfı, bir işlemi temsil eder.
    public class Operation
    {
        // İşlem ID'si.
        public int Id { get; set; }

        // İşlemin adı.
        public string Name { get; set; }

        // İşlemin fiyatı.
        public double Price { get; set; }

        // İşlemin açıklaması.
        public string Description { get; set; }
    }
}

