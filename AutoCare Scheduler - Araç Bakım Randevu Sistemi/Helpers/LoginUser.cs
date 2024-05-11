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
    public static class LoginUser
    {
        // Username özelliği, oturum açmış kullanıcının adını temsil eder.
        // Kullanıcı adı, oturum açıldığında burada saklanır ve erişilebilir.
        public static string Username { get; private set; }

        // SetUserName metodu, oturum açmış kullanıcının adını ayarlar.
        // Parametre:
        //   - username: Ayarlanacak kullanıcı adını temsil eder.
        public static void SetUserName(string username)
        {
            // Kullanıcı adı, belirtilen parametreye göre ayarlanır.
            Username = username;
        }
    }
}
