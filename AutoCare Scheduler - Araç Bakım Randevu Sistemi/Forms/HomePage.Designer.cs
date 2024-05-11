namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customers_list = new ListView();
            Id = new ColumnHeader();
            NameSurname = new ColumnHeader();
            PhoneNumber = new ColumnHeader();
            EmailAddress = new ColumnHeader();
            Address = new ColumnHeader();
            operations_list = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            customers_lb = new Label();
            services_lb = new Label();
            typeofservice_lb = new Label();
            appointment_date = new MonthCalendar();
            appointment_time = new ComboBox();
            appointment_minutes = new ComboBox();
            add_appointments = new Button();
            appointment_list = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            appointment_lb = new Label();
            remove_appointments = new Button();
            update_appointments = new Button();
            appointment_date_lb = new Label();
            appointment_time_lb = new Label();
            menuStrip1 = new MenuStrip();
            panelSayfasıToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            services_list = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // customers_list
            // 
            customers_list.Columns.AddRange(new ColumnHeader[] { Id, NameSurname, PhoneNumber, EmailAddress, Address });
            customers_list.Location = new Point(12, 42);
            customers_list.Name = "customers_list";
            customers_list.Size = new Size(248, 230);
            customers_list.TabIndex = 4;
            customers_list.UseCompatibleStateImageBehavior = false;
            customers_list.View = View.Details;
            // 
            // Id
            // 
            Id.Tag = "Id";
            Id.Text = "Müşteri Id";
            // 
            // NameSurname
            // 
            NameSurname.Tag = "Name Surname";
            NameSurname.Text = "İsim Soyisim";
            // 
            // PhoneNumber
            // 
            PhoneNumber.Tag = "Phone Number";
            PhoneNumber.Text = "Telefon Numarası";
            // 
            // EmailAddress
            // 
            EmailAddress.Tag = "Email Address";
            EmailAddress.Text = "E-Posta Adresi";
            // 
            // Address
            // 
            Address.Tag = "Address";
            Address.Text = "Adres";
            // 
            // operations_list
            // 
            operations_list.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            operations_list.Location = new Point(520, 42);
            operations_list.Name = "operations_list";
            operations_list.Size = new Size(248, 230);
            operations_list.TabIndex = 7;
            operations_list.UseCompatibleStateImageBehavior = false;
            operations_list.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Hizmet Id";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Hizmet Adı";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tutar";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Açıklama";
            // 
            // customers_lb
            // 
            customers_lb.AutoSize = true;
            customers_lb.Location = new Point(12, 24);
            customers_lb.Name = "customers_lb";
            customers_lb.Size = new Size(60, 15);
            customers_lb.TabIndex = 8;
            customers_lb.Text = "Müşteriler";
            // 
            // services_lb
            // 
            services_lb.AutoSize = true;
            services_lb.Location = new Point(266, 24);
            services_lb.Name = "services_lb";
            services_lb.Size = new Size(50, 15);
            services_lb.TabIndex = 10;
            services_lb.Text = "Servisler";
            // 
            // typeofservice_lb
            // 
            typeofservice_lb.AutoSize = true;
            typeofservice_lb.Location = new Point(520, 24);
            typeofservice_lb.Name = "typeofservice_lb";
            typeofservice_lb.Size = new Size(80, 15);
            typeofservice_lb.TabIndex = 11;
            typeofservice_lb.Text = "Hizmet Tipleri";
            // 
            // appointment_date
            // 
            appointment_date.Location = new Point(780, 42);
            appointment_date.Name = "appointment_date";
            appointment_date.TabIndex = 12;
            appointment_date.DateSelected += appointment_date_DateSelected;
            // 
            // appointment_time
            // 
            appointment_time.FormattingEnabled = true;
            appointment_time.Items.AddRange(new object[] { "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18" });
            appointment_time.Location = new Point(780, 249);
            appointment_time.Name = "appointment_time";
            appointment_time.Size = new Size(114, 23);
            appointment_time.TabIndex = 13;
            appointment_time.Text = "08";
            // 
            // appointment_minutes
            // 
            appointment_minutes.DisplayMember = "00";
            appointment_minutes.FormattingEnabled = true;
            appointment_minutes.Items.AddRange(new object[] { "00", "30" });
            appointment_minutes.Location = new Point(900, 249);
            appointment_minutes.Name = "appointment_minutes";
            appointment_minutes.Size = new Size(114, 23);
            appointment_minutes.TabIndex = 14;
            appointment_minutes.Tag = "";
            appointment_minutes.Text = "00";
            // 
            // add_appointments
            // 
            add_appointments.Location = new Point(12, 278);
            add_appointments.Name = "add_appointments";
            add_appointments.Size = new Size(328, 23);
            add_appointments.TabIndex = 15;
            add_appointments.Text = "Randevu Ekle";
            add_appointments.UseVisualStyleBackColor = true;
            add_appointments.Click += add_appointments_Click;
            // 
            // appointment_list
            // 
            appointment_list.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17, columnHeader18, columnHeader19, columnHeader20 });
            appointment_list.Location = new Point(12, 326);
            appointment_list.Name = "appointment_list";
            appointment_list.Size = new Size(1002, 445);
            appointment_list.TabIndex = 16;
            appointment_list.UseCompatibleStateImageBehavior = false;
            appointment_list.View = View.Details;
            appointment_list.SelectedIndexChanged += appointment_list_SelectedIndexChanged;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Randevu Id";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Müşteri Bilgileri";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Müşteri Telefonu";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Müşteri E-Posta";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Müşteri Adresi";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Servis Adı";
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Servis Adresi";
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Hizmet Tipi";
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Personel Bilgileri";
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Departman";
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Randevu Tarihi";
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Toplam Tutar";
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Açıklama";
            // 
            // appointment_lb
            // 
            appointment_lb.AutoSize = true;
            appointment_lb.Location = new Point(12, 308);
            appointment_lb.Name = "appointment_lb";
            appointment_lb.Size = new Size(66, 15);
            appointment_lb.TabIndex = 17;
            appointment_lb.Text = "Randevular";
            // 
            // remove_appointments
            // 
            remove_appointments.Location = new Point(686, 278);
            remove_appointments.Name = "remove_appointments";
            remove_appointments.Size = new Size(328, 23);
            remove_appointments.TabIndex = 18;
            remove_appointments.Text = "Randevu İptal";
            remove_appointments.UseVisualStyleBackColor = true;
            remove_appointments.Click += remove_appointments_Click;
            // 
            // update_appointments
            // 
            update_appointments.Location = new Point(349, 278);
            update_appointments.Name = "update_appointments";
            update_appointments.Size = new Size(328, 23);
            update_appointments.TabIndex = 20;
            update_appointments.Text = "Randevu Düzenle";
            update_appointments.UseVisualStyleBackColor = true;
            update_appointments.Click += update_appointments_Click;
            // 
            // appointment_date_lb
            // 
            appointment_date_lb.AutoSize = true;
            appointment_date_lb.Location = new Point(780, 24);
            appointment_date_lb.Name = "appointment_date_lb";
            appointment_date_lb.Size = new Size(32, 15);
            appointment_date_lb.TabIndex = 21;
            appointment_date_lb.Text = "Tarih";
            // 
            // appointment_time_lb
            // 
            appointment_time_lb.AutoSize = true;
            appointment_time_lb.Location = new Point(780, 231);
            appointment_time_lb.Name = "appointment_time_lb";
            appointment_time_lb.Size = new Size(29, 15);
            appointment_time_lb.TabIndex = 22;
            appointment_time_lb.Text = "Saat";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { panelSayfasıToolStripMenuItem, çıkışYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1029, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // panelSayfasıToolStripMenuItem
            // 
            panelSayfasıToolStripMenuItem.Name = "panelSayfasıToolStripMenuItem";
            panelSayfasıToolStripMenuItem.Size = new Size(87, 20);
            panelSayfasıToolStripMenuItem.Text = "Panel Sayfası";
            panelSayfasıToolStripMenuItem.Click += panelSayfasıToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(66, 20);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // services_list
            // 
            services_list.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            services_list.Location = new Point(266, 42);
            services_list.Name = "services_list";
            services_list.Size = new Size(248, 230);
            services_list.TabIndex = 6;
            services_list.UseCompatibleStateImageBehavior = false;
            services_list.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Tag = "Id";
            columnHeader1.Text = "Servis Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Servis Adı";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Adres";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 779);
            Controls.Add(appointment_time_lb);
            Controls.Add(appointment_date_lb);
            Controls.Add(update_appointments);
            Controls.Add(remove_appointments);
            Controls.Add(appointment_lb);
            Controls.Add(appointment_list);
            Controls.Add(add_appointments);
            Controls.Add(appointment_minutes);
            Controls.Add(appointment_time);
            Controls.Add(appointment_date);
            Controls.Add(typeofservice_lb);
            Controls.Add(services_lb);
            Controls.Add(customers_lb);
            Controls.Add(operations_list);
            Controls.Add(services_list);
            Controls.Add(customers_list);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "AutoCare Scheduler - Araç Bakım Randevu Sistemi";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView customers_list;
        private ListView operations_list;
        private Label customers_lb;
        private Label services_lb;
        private Label typeofservice_lb;
        private MonthCalendar appointment_date;
        private ComboBox appointment_time;
        private ComboBox appointment_minutes;
        private Button add_appointments;
        private ListView appointment_list;
        private Label appointment_lb;
        private Button remove_appointments;
        private Button update_appointments;
        private Label appointment_date_lb;
        private Label appointment_time_lb;
        private ColumnHeader Id;
        private ColumnHeader NameSurname;
        private ColumnHeader PhoneNumber;
        private ColumnHeader EmailAddress;
        private ColumnHeader Address;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem panelSayfasıToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ListView services_list;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
    }
}
