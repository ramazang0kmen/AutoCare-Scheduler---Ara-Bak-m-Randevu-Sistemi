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
        // LogError metodu, belirtilen hata mesajını bir log dosyasına kaydeder.
        // Parametre:
        //   - errorMessage: Kaydedilecek hata mesajını temsil eder.
        public static void LogError(string errorMessage)
        {
            // Hata mesajları, belirtilen log dosyasına yazılır.
            string logFilePath = "LogFiles/AutoCareSchedulerLog.txt";
            FileProcessing.WriteToFile(logFilePath, errorMessage);
        }

        // LogBox metodu, kullanıcıya hata mesajını bir MessageBox aracılığıyla gösterir.
        // Parametre:
        //   - message: Kullanıcıya gösterilecek hata mesajını temsil eder.
        public static void LogBox(string message)
        {
            // Kullanıcıya hata mesajı bir MessageBox içinde gösterilir.
            MessageBox.Show("Bir hata oluştu, lütfen daha sonra tekrar deneyiniz. Hata: " + message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
