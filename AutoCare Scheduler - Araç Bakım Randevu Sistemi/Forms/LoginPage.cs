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

using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Business;
using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Helpers;
using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Model;

namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Forms
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcı adı ve şifreyi alır.
                string username = username_tb.Text;
                string password = password_tb.Text;
                // Şifreyi hashleyerek kontrol edilebilir hale getirir.
                string hash_password = HashHelper.HashPassword(password);
                string personnel_id = string.Empty;

                // Personel yöneticisini oluşturur.
                PersonnelManager personnelManager = new PersonnelManager();
                // Kullanıcı adına göre personeli getirir.
                Personnel personnel = personnelManager.GetPersonnelByUsername(username);

                // Kullanıcı adı ve şifre kontrolü yapar.
                if (personnel != null && username == personnel.Username && hash_password == personnel.Password)
                {
                    // Kullanıcı adını ve personel kimliğini ayarlar.
                    personnel_id = personnel.Id.ToString();
                    LoginUser.SetUserName(username);

                    // Giriş formunu gizler ve panel sayfasını gösterir.
                    this.Hide();

                    PanelPage panelPage = new PanelPage();
                    panelPage.Show();
                }
                else
                {
                    // Hatalı giriş durumunda kullanıcıya bilgi verir.
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                // Hata durumunda log kaydı oluşturur ve kullanıcıya bilgi verir.
                Logger.LogError("Giriş yapılırken bir hata oluştu. Hata: " + ex.Message);
                MessageBox.Show("Giriş yapılırken bir hata oluştu. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Şifre kutusunun karakterlerini gizler.
            password_tb.PasswordChar = '*';
        }
    }
}
