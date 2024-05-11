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
    public class FileProcessing
    {
        // WriteToFile metodu, belirtilen dosyaya içerik ekler.
        // Parametreler:
        //   - filePath: İçerik eklenecek dosyanın yolunu belirtir.
        //   - content: Dosyaya eklenmek istenen içeriği temsil eder
        public static void WriteToFile(string filePath, string content)
        {
            //File.AppendAllText(filePath, content + Environment.NewLine);
            // Dosya yazma işlemi başlamadan önce kaydedilecek dizin oluşturulur.
            string directoryPath = Directory.GetCurrentDirectory() + "/LogFiles";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            try
            {
                // StreamWriter, dosyaya yazma işlemini gerçekleştirir.
                // 'using' bloğu, writer nesnesinin işi bittiğinde otomatik olarak kaynakları serbest bırakır.
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Belirtilen içeriği dosyaya yazılır.
                    writer.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                // Dosyaya yazma işleminde bir hata oluşursa, hata kaydedilir ve işlem sonlandırılır.
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return;
            }
        }
    }
}
