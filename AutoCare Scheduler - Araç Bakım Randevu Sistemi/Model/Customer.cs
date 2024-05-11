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
    // Müşteri sınıfı, bir müşteriyi temsil eder.
    public class Customer
    {
        // Müşteri ID'si.
        public int Id { get; set; }

        // Müşterinin adı ve soyadı.
        public string NameSurname { get; set; }

        // Müşterinin telefon numarası.
        public string PhoneNumber { get; set; }

        // Müşterinin e-posta adresi.
        public string EmailAddress { get; set; }

        // Müşterinin adresi.
        public string Address { get; set; }
    }
}

