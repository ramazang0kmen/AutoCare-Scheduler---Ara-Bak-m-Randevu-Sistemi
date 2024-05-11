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
    // Personnel sınıfı, bir personeli temsil eder.
    public class Personnel
    {
        // Personel ID'si.
        public int Id { get; set; }

        // Personelin kullanıcı adı.
        public string Username { get; set; }

        // Personelin şifresi.
        public string Password { get; set; }

        // Personelin adı ve soyadı.
        public string NameSurname { get; set; }

        // Personelin çalıştığı departman.
        public string Department { get; set; }
    }
}

