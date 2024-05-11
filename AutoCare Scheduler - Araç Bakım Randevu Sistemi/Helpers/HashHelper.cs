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
        public static string HashPassword(string password)
        {
            try
            {
                SHA256 sha256Hash = SHA256.Create();
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                string hashedPassword = string.Empty;
                for (int i = 0; i < bytes.Length; i++)
                {
                    hashedPassword += bytes[i].ToString("x2");
                }
                return hashedPassword;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }
        private static bool IsTurkishCharacter(char c)
        {
            return "çğıöşüÇĞİÖŞÜ".Contains(c);
        }

        public static string PasswordController(string password)
        {
            try
            {
                string newText = string.Empty;
            foreach (char c in password.ToLower())
            {
                if (!IsTurkishCharacter(c) && c != ' ')
                {
                    newText += c;
                }
                else
                {
                    MessageBox.Show("Şifre alanına Türkçe karakter, büyük harf veya boşluk giremezsiniz.");
                }
            }
                return newText.ToLower(); 
            }
            catch (Exception ex) 
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
                return null;
            }
        }
        
    }
}
