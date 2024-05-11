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
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Forms
{
    public partial class PanelPage : Form
    {
        public PanelPage()
        {
            InitializeComponent();
        }


        private void add_customer_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerManager customerManager = new CustomerManager();

                string namesurname = customer_name_surname.Text;
                string phonenumber = customer_phone_number.Text;
                string emailaddress = customer_email.Text;
                bool isValidEmail = Regex.IsMatch(emailaddress, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                string address = customer_address.Text;

                if (string.IsNullOrEmpty(namesurname) || string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                if ((!isValidEmail))
                {
                    MessageBox.Show("E-posta formatınızı kontrol ediniz.");
                    Logger.LogError("E-posta formatı hatalı.");
                    return;
                }

                Customer newCustomer = new Customer
                {
                    NameSurname = namesurname,
                    PhoneNumber = phonenumber,
                    EmailAddress = emailaddress,
                    Address = address
                };

                customerManager.AddCustomer(newCustomer);

                ClearFields();

                MessageBox.Show("Müşteri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri eklenirken bir hata oluştu. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogError("Müşteri eklenirken bir hata oluştu. Hata: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            customer_name_surname.Clear();
            customer_phone_number.Clear();
            customer_email.Clear();
            customer_address.Clear();
            personnel_name_surname.Clear();
            personnel_username.Clear();
            personnel_password.Clear();
            personnel_department.Clear();
            service_name.Clear();
            service_address.Clear();
            operation_name.Clear();
            operation_price.Clear();
            detailed_information.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                personnel_password.PasswordChar = '\0';
            }
            else
            {
                personnel_password.PasswordChar = '*';
            }
        }

        private void PanelPage_Load(object sender, EventArgs e)
        {
            personnel_password.PasswordChar = '*';
        }

        private void add_personnel_Click(object sender, EventArgs e)
        {
            try
            {
                PersonnelManager personnelManager = new PersonnelManager();

                string namesurname = personnel_name_surname.Text;
                string username = personnel_username.Text;
                string password = personnel_password.Text;
                string HashedPassword = HashPassword(password);
                string department = personnel_department.Text;

                if (string.IsNullOrEmpty(namesurname) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(department))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                Personnel newpersonnel = new Personnel
                {
                    NameSurname = namesurname,
                    Username = username,
                    Password = HashedPassword,
                    Department = department
                };

                personnelManager.AddPersonnel(newpersonnel);

                ClearFields();

                MessageBox.Show("Personel başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel eklenirken bir hata oluştu. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogError("Personel eklenirken bir hata oluştu. Hata: " + ex.Message);
            }
        }

        static string HashPassword(string password)
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

        private void personnel_username_TextChanged(object sender, EventArgs e)
        {
            personnel_username.Text = personnel_username.Text.ToLower();
            personnel_username.SelectionStart = personnel_username.Text.Length;

            string newText = string.Empty;
            foreach (char c in personnel_username.Text.ToLower())
            {
                if (!IsTurkishCharacter(c) && c != ' ')
                {
                    newText += c;
                }
            }
            personnel_username.Text = newText;
            personnel_username.SelectionStart = personnel_username.Text.Length;
        }

        private bool IsTurkishCharacter(char c)
        {
            return "çğıöşüÇĞİÖŞÜ".Contains(c);
        }

        private void personnel_password_TextChanged(object sender, EventArgs e)
        {
            personnel_password.Text = HashHelper.PasswordController(personnel_password.Text);
            personnel_password.Text = personnel_password.Text.ToLower();
            personnel_password.SelectionStart = personnel_password.Text.Length;
        }

        private void add_service_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceManager serviceManager = new ServiceManager();

                string servicename = service_name.Text;
                string serviceaddress = service_address.Text;

                if (string.IsNullOrEmpty(servicename) || string.IsNullOrEmpty(serviceaddress))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                Service newService = new Service
                {
                    Name = servicename,
                    Address = serviceaddress
                };

                serviceManager.AddService(newService);

                ClearFields();

                MessageBox.Show("Servis başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servis eklenirken bir hata oluştu. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogError("Servis eklenirken bir hata oluştu. Hata: " + ex.Message);
            }
        }

        private void add_typeofsevice_Click(object sender, EventArgs e)
        {
            try
            {
                OperationManager operationManager = new OperationManager();

                string operationname = operation_name.Text;
                string operationprice = operation_price.Text;
                string operationdescription = detailed_information.Text;

                if (string.IsNullOrEmpty(operationname) || string.IsNullOrEmpty(operationprice) || string.IsNullOrEmpty(operationdescription))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                Operation newOperation = new Operation
                {
                    Name = operationname,
                    Price = (double)Convert.ToDecimal(operationprice),
                    Description = operationdescription
                };

                operationManager.AddOperation(newOperation);

                ClearFields();

                MessageBox.Show("Hizmet Tipi başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hizmet Tipi eklenirken bir hata oluştu. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogError("Hizmet Tipi eklenirken bir hata oluştu. Hata: " + ex.Message);
            }
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 homePage = new Form1();
            homePage.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginUser.SetUserName(null);

            this.Hide();

            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }
    }
}
