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

using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Model;
using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Business;
using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Helpers;
using AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Forms;

namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager();
        ServiceManager serviceManager = new ServiceManager();
        OperationManager operationManager = new OperationManager();
        PersonnelManager personnelManager = new PersonnelManager();
        AppointmentManager appointmentManager = new AppointmentManager();

        int customerId = -1;
        int serviceId = -1;
        int operationId = -1;
        private void Form1_Load(object sender, EventArgs e)
        {
            update_list();
            customers_list.FullRowSelect = true;
            services_list.FullRowSelect = true;
            operations_list.FullRowSelect = true;
            appointment_list.FullRowSelect = true;
        }

        private void add_appointments_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(customers_list.SelectedItems[0].SubItems[0].Text) == null || Convert.ToInt32(services_list.SelectedItems[0].SubItems[0].Text) == null || Convert.ToInt32(operations_list.SelectedItems[0].SubItems[0].Text) == null || appointment_date.SelectionRange.Start.Date < DateTime.Today)
                {
                    MessageBox.Show("Lütfen tablolardan gerekli bilgileri, tarihi ve saati seçiniz.");
                    return;
                }

                customerId = Convert.ToInt32(customers_list.SelectedItems[0].SubItems[0].Text);
                serviceId = Convert.ToInt32(services_list.SelectedItems[0].SubItems[0].Text);
                operationId = Convert.ToInt32(operations_list.SelectedItems[0].SubItems[0].Text);
                DateTime selecteddate = appointment_date.SelectionRange.Start.Date;
                int appointmenthour = int.Parse(appointment_time.SelectedItem.ToString());
                int appointmentminute = int.Parse(appointment_minutes.SelectedItem.ToString());
                DateTime appointmentdate = new DateTime(selecteddate.Year, selecteddate.Month, selecteddate.Day, appointmenthour, appointmentminute, 0);

                Operation operation = operationManager.GetOperationById(operationId);
                Personnel personnel = personnelManager.GetPersonnelByUsername(LoginUser.Username);

                Appointment appointment = new Appointment
                {
                    CustomerId = customerId,
                    ServiceId = serviceId,
                    OperationId = operationId,
                    PersonnelId = personnel.Id,
                    Date = appointmentdate,
                    TotalPrice = Convert.ToDecimal(operation.Price),
                    Description = operation.Description
                };

                appointmentManager.AddAppointment(appointment);

                update_list();

                MessageBox.Show("Randevu başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu eklenirken bir hata oluştu. Lütfen tablolardan gerekli bilgileri, tarihi ve saati kontrol ederek tekrar deneyiniz. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogError("Randevu eklenirken bir hata oluştu. Hata: " + ex.Message);
            }
        }

        private void appointment_date_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = appointment_date.SelectionRange.Start;

            if (selectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("Lütfen bugünden sonra bir tarih seçiniz.");
                appointment_date.SetDate(DateTime.Today);
            }
        }

        private void update_list()
        {
            try
            {
                List<Appointment> appointments = appointmentManager.GetAllAppointment();

                appointment_list.Items.Clear();
                foreach (var appointment in appointments)
                {
                    Customer customer = customerManager.GetCustomerById(appointment.CustomerId);
                    Service service = serviceManager.GetServiceById(appointment.ServiceId);
                    Operation operation = operationManager.GetOperationById(appointment.OperationId);
                    Personnel personnel = personnelManager.GetPersonnelById(appointment.PersonnelId);
                    ListViewItem item = new ListViewItem();
                    item.Text = appointment.Id.ToString();
                    item.SubItems.Add(customer.NameSurname.ToString());
                    item.SubItems.Add(customer.PhoneNumber);
                    item.SubItems.Add(customer.EmailAddress);
                    item.SubItems.Add(customer.Address);
                    item.SubItems.Add(service.Name);
                    item.SubItems.Add(service.Address);
                    item.SubItems.Add(operation.Name); // İşlem Id
                    item.SubItems.Add(personnel.NameSurname);
                    item.SubItems.Add(personnel.Department);
                    item.SubItems.Add(appointment.Date.ToString()); // Tarih
                    item.SubItems.Add(appointment.TotalPrice.ToString()); // Toplam Fiyat
                    item.SubItems.Add(appointment.Description.ToString()); // Açıklama
                    appointment_list.Items.Add(item);
                }

                appointment_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                List<Customer> customers = customerManager.GetAllCustomer();

                customers_list.Items.Clear();
                foreach (var customer in customers)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = customer.Id.ToString(); // Id
                    item.SubItems.Add(customer.NameSurname); // İsim Soyisim
                    item.SubItems.Add(customer.PhoneNumber); // Telefon Numarası
                    item.SubItems.Add(customer.EmailAddress); // E-posta Adresi
                    item.SubItems.Add(customer.Address); // Adres
                    customers_list.Items.Add(item);
                }

                customers_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                List<Service> services = serviceManager.GetAllServices();

                services_list.Items.Clear();
                foreach (var service in services)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = service.Id.ToString(); // Id
                    item.SubItems.Add(service.Name); // İsim
                    item.SubItems.Add(service.Address); // Adres
                    services_list.Items.Add(item);
                }

                services_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                List<Operation> operations = operationManager.GetAllOperation();

                operations_list.Items.Clear();
                foreach (var operation in operations)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = operation.Id.ToString(); // Id
                    item.SubItems.Add(operation.Name.ToString()); // Servis Id
                    item.SubItems.Add(operation.Price.ToString()); // İşlem Tarihi
                    item.SubItems.Add(operation.Description.ToString()); // İşlem Saati
                    operations_list.Items.Add(item);
                }

                operations_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        private void appointment_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string customername = null;
                string servicename = null;
                string operationname = null;
                string date = null;
                int selectedHour = 08;
                int selectedMinute = 00;

                // sender den seçili olanı al

                //customername = appointment_list.SelectedItems[0].SubItems[1].Text;
                //servicename = appointment_list.SelectedItems[0].SubItems[5].Text;
                //operationname = appointment_list.SelectedItems[0].SubItems[7].Text;
                //date = appointment_list.SelectedItems[0].SubItems[10].Text;


                customername = (sender as ListView).SelectedItems[0].SubItems[1].Text;
                servicename = (sender as ListView).SelectedItems[0].SubItems[5].Text;
                operationname = (sender as ListView).SelectedItems[0].SubItems[7].Text;
                date = (sender as ListView).SelectedItems[0].SubItems[10].Text;

                foreach (ListViewItem item in customers_list.Items)
                {
                    item.Selected = false;
                }

                foreach (ListViewItem item in services_list.Items)
                {
                    item.Selected = false;
                }

                foreach (ListViewItem item in operations_list.Items)
                {
                    item.Selected = false;
                }

                foreach (ListViewItem item in customers_list.Items)
                {
                    if (item.SubItems[1].Text == customername)
                    {
                        item.Selected = true;
                        break;
                    }
                }

                foreach (ListViewItem item in services_list.Items)
                {
                    if (item.SubItems[1].Text == servicename)
                    {
                        item.Selected = true;
                        break;
                    }
                }

                foreach (ListViewItem item in operations_list.Items)
                {
                    if (item.SubItems[1].Text == operationname)
                    {
                        item.Selected = true;
                        break;
                    }
                }

                appointment_date.SetDate(DateTime.Parse(date));

                selectedHour = DateTime.Parse(date).Hour;
                selectedMinute = DateTime.Parse(date).Minute;

                appointment_time.SelectedItem = selectedHour.ToString();
                appointment_minutes.SelectedItem = selectedMinute.ToString();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginUser.SetUserName(null);

            this.Hide();

            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void panelSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            PanelPage panelPage = new PanelPage();
            panelPage.Show();
        }

        private void remove_appointments_Click(object sender, EventArgs e)
        {
            try
            {
                int removeid = Convert.ToInt32(appointment_list.SelectedItems[0].SubItems[0].Text);
                appointmentManager.RemoveAppointment(removeid);
                update_list();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                Logger.LogBox(ex.Message);
            }

        }

        private void update_appointments_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(customers_list.SelectedItems[0].SubItems[0].Text) == null || Convert.ToInt32(services_list.SelectedItems[0].SubItems[0].Text) == null || Convert.ToInt32(operations_list.SelectedItems[0].SubItems[0].Text) == null || appointment_date.SelectionRange.Start.Date < DateTime.Today)
                {
                    MessageBox.Show("Lütfen tablolardan gerekli bilgileri, tarihi ve saati seçiniz.");
                    return;
                }

                int appointmentId = Convert.ToInt32(appointment_list.SelectedItems[0].SubItems[0].Text);
                customerId = Convert.ToInt32(customers_list.SelectedItems[0].SubItems[0].Text);
                serviceId = Convert.ToInt32(services_list.SelectedItems[0].SubItems[0].Text);
                operationId = Convert.ToInt32(operations_list.SelectedItems[0].SubItems[0].Text);
                DateTime selecteddate = appointment_date.SelectionRange.Start.Date;
                int appointmenthour = int.Parse(appointment_time.SelectedItem.ToString());
                int appointmentminute = int.Parse(appointment_minutes.SelectedItem.ToString());
                DateTime appointmentdate = new DateTime(selecteddate.Year, selecteddate.Month, selecteddate.Day, appointmenthour, appointmentminute, 0);

                Operation operation = operationManager.GetOperationById(operationId);
                Personnel personnel = personnelManager.GetPersonnelByUsername(LoginUser.Username);

                Appointment appointment = new Appointment
                {
                    Id = appointmentId,
                    CustomerId = customerId,
                    ServiceId = serviceId,
                    OperationId = operationId,
                    PersonnelId = personnel.Id,
                    Date = appointmentdate,
                    TotalPrice = Convert.ToDecimal(operation.Price),
                    Description = operation.Description
                };

                appointmentManager.UpdateAppointment(appointment);

                update_list();

                MessageBox.Show("Randevu başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                MessageBox.Show("Randevu güncellenirken bir hata oluştu. Lütfen tablolardan gerekli bilgileri, tarihi ve saati kontrol ederek tekrar deneyiniz. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
