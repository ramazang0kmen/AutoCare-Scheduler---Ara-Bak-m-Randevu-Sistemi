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

namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Helpers
{
    // Config sınıfı, uygulamanın yapılandırma (config) ayarlarını sağlar.
    public class Config
    {
        // GetConnectionString metodu, uygulamanın veritabanına bağlanmak için gereken bağlantı dizesini döndürür.
        public static string GetConnectionString()
        {
            // Bu örnek bağlantı dizesi, lokal bir SQL Server veritabanına bağlanmayı sağlar.
            return "Data Source=DESKTOP-BHG0SFD;Initial Catalog=AutoCareSchedulerDb;Integrated Security=True";
        }
    }
}
