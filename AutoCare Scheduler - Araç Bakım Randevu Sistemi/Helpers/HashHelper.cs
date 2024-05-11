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

using System.Security.Cryptography;
using System.Text;

namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Helpers
{
    public class HashHelper
    {
        // HashPassword metodu, belirtilen şifreyi SHA-256 algoritmasıyla şifreler.
        // Parametre:
        //   - password: Şifrelenmek istenen metni temsil eder.
        // Dönüş Değeri:
        //   - Şifrelenmiş metni içeren bir dize döndürür.
        public static string HashPassword(string password)
        {
            try
            {
                // SHA256 algoritması kullanılarak şifrelenmiş hash oluşturulur.
                SHA256 sha256Hash = SHA256.Create();
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                string hashedPassword = string.Empty;
                // Her byte, hexadecimal formata dönüştürülerek hash oluşturulur.
                for (int i = 0; i < bytes.Length; i++)
                {
                    hashedPassword += bytes[i].ToString("x2");
                }
                return hashedPassword;
            }
            catch (Exception ex)
            {
                // Şifreleme işlemi sırasında bir hata oluşursa, hata kaydedilir ve null döndürülür.
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }

        // IsTurkishCharacter metodu, verilen karakterin Türkçe bir karakter olup olmadığını kontrol eder.
        // Parametre:
        //   - c: Kontrol edilecek karakteri temsil eder.
        // Dönüş Değeri:
        //   - Karakterin Türkçe bir karakter olup olmadığını belirten bir bool değer döndürür.
        private static bool IsTurkishCharacter(char c)
        {
            // Karakterin Türkçe bir karakter olup olmadığı kontrol edilir.
            return "çğıöşüÇĞİÖŞÜ".Contains(c);
        }

        // PasswordController metodu, Türkçe karakter ve büyük harf kontrolü yapar.
        // Parametre:
        //   - password: Kontrol edilecek şifreyi temsil eder.
        // Dönüş Değeri:
        //   - Türkçe karakter veya büyük harf içermeyen ve küçük harfle yazılmış olan şifreyi döndürür.
        public static string PasswordController(string password)
        {
            try
            {
                string newText = string.Empty;
                // Şifredeki her karakter için Türkçe karakter veya büyük harf kontrolü yapılır.
                foreach (char c in password.ToLower())
                {
                    if (!IsTurkishCharacter(c) && c != ' ')
                    {
                        newText += c;
                    }
                    else
                    {
                        // Şifrede Türkçe karakter veya büyük harf varsa hata mesajı gösterilir.
                        MessageBox.Show("Şifre alanına Türkçe karakter, büyük harf veya boşluk giremezsiniz.");
                    }
                }
                    return newText.ToLower(); 
            }
            catch (Exception ex) 
            {
                // Hata oluşması durumunda hata kaydedilir ve null döndürülür.
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }
        
    }
}
