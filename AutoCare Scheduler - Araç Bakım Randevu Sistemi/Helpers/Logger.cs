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
    public class Logger
    {
        public static void LogError(string errorMessage)
        {
            string logFilePath = "LogFiles/AutoCareSchedulerLog.txt";
            FileProcessing.WriteToFile(logFilePath, errorMessage);
        }

        public static void LogBox(string message)
        {
            MessageBox.Show("Bir hata oluştu, lütfen daha sonra tekrar deneyiniz. Hata: " + message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
