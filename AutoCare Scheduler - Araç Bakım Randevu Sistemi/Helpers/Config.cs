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
    public class Config
    {
        public static string GetConnectionString()
        {
            return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AutoCareSchedulerDb;Integrated Security=True";
        }
    }
}
