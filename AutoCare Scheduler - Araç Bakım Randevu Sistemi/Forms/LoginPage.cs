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
                string username = username_tb.Text;
                string password = password_tb.Text;
                string hash_password = HashHelper.HashPassword(password);
                string personnel_id = string.Empty;

                PersonnelManager personnelManager = new PersonnelManager();
                Personnel personnel = personnelManager.GetPersonnelByUsername(username);

                if (personnel != null && username == personnel.Username && hash_password == personnel.Password)
                {
                    personnel_id = personnel.Id.ToString();
                    LoginUser.SetUserName(username);

                    this.Hide();

                    PanelPage panelPage = new PanelPage();
                    panelPage.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Logger.LogError("Giriş yapılırken bir hata oluştu. Hata: " + ex.Message);
                MessageBox.Show("Giriş yapılırken bir hata oluştu. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            password_tb.PasswordChar = '*';
        }
    }
}
