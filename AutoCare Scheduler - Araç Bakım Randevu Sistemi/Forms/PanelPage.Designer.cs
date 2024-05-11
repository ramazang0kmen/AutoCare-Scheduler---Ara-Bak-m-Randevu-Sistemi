namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Forms
{
    partial class PanelPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            personnel_add_gB = new GroupBox();
            personnel_username = new MaskedTextBox();
            checkBox1 = new CheckBox();
            personnel_password = new TextBox();
            label2 = new Label();
            label1 = new Label();
            add_personnel = new Button();
            personnel_department = new TextBox();
            personnel_name_surname = new TextBox();
            job_title_lb = new Label();
            personnel_name_surname_lb = new Label();
            service_add_gB = new GroupBox();
            add_service = new Button();
            service_address = new RichTextBox();
            service_name = new TextBox();
            service_adress_lb = new Label();
            service_name_lb = new Label();
            operation_add_gB = new GroupBox();
            add_typeofsevice = new Button();
            detailed_information = new RichTextBox();
            operation_price = new TextBox();
            operation_name = new TextBox();
            detailed_information_lb = new Label();
            operation_price_lb = new Label();
            operation_name_lb = new Label();
            customer_add_gB = new GroupBox();
            customer_phone_number = new MaskedTextBox();
            add_customer = new Button();
            customer_address = new RichTextBox();
            customer_email = new TextBox();
            customer_name_surname = new TextBox();
            customer_adress_lb = new Label();
            customer_email_lb = new Label();
            customer_phone_number_lb = new Label();
            customer_name_surname_lb = new Label();
            menuStrip1 = new MenuStrip();
            anaSayfaToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            personnel_add_gB.SuspendLayout();
            service_add_gB.SuspendLayout();
            operation_add_gB.SuspendLayout();
            customer_add_gB.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // personnel_add_gB
            // 
            personnel_add_gB.Controls.Add(personnel_username);
            personnel_add_gB.Controls.Add(checkBox1);
            personnel_add_gB.Controls.Add(personnel_password);
            personnel_add_gB.Controls.Add(label2);
            personnel_add_gB.Controls.Add(label1);
            personnel_add_gB.Controls.Add(add_personnel);
            personnel_add_gB.Controls.Add(personnel_department);
            personnel_add_gB.Controls.Add(personnel_name_surname);
            personnel_add_gB.Controls.Add(job_title_lb);
            personnel_add_gB.Controls.Add(personnel_name_surname_lb);
            personnel_add_gB.Location = new Point(280, 27);
            personnel_add_gB.Name = "personnel_add_gB";
            personnel_add_gB.Size = new Size(262, 197);
            personnel_add_gB.TabIndex = 2;
            personnel_add_gB.TabStop = false;
            personnel_add_gB.Text = "Personel Ekleme";
            // 
            // personnel_username
            // 
            personnel_username.Location = new Point(114, 51);
            personnel_username.Name = "personnel_username";
            personnel_username.Size = new Size(135, 23);
            personnel_username.TabIndex = 10;
            personnel_username.TextChanged += personnel_username_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(154, 109);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Şifreyi Göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // personnel_password
            // 
            personnel_password.Location = new Point(114, 80);
            personnel_password.Name = "personnel_password";
            personnel_password.Size = new Size(135, 23);
            personnel_password.TabIndex = 8;
            personnel_password.TextChanged += personnel_password_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 83);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 54);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı:";
            // 
            // add_personnel
            // 
            add_personnel.Location = new Point(114, 163);
            add_personnel.Name = "add_personnel";
            add_personnel.Size = new Size(135, 23);
            add_personnel.TabIndex = 4;
            add_personnel.Text = "Personel Ekle";
            add_personnel.UseVisualStyleBackColor = true;
            add_personnel.Click += add_personnel_Click;
            // 
            // personnel_department
            // 
            personnel_department.Location = new Point(114, 134);
            personnel_department.Name = "personnel_department";
            personnel_department.Size = new Size(135, 23);
            personnel_department.TabIndex = 3;
            // 
            // personnel_name_surname
            // 
            personnel_name_surname.Location = new Point(114, 22);
            personnel_name_surname.Name = "personnel_name_surname";
            personnel_name_surname.Size = new Size(135, 23);
            personnel_name_surname.TabIndex = 2;
            // 
            // job_title_lb
            // 
            job_title_lb.AutoSize = true;
            job_title_lb.Location = new Point(52, 137);
            job_title_lb.Name = "job_title_lb";
            job_title_lb.Size = new Size(56, 15);
            job_title_lb.TabIndex = 1;
            job_title_lb.Text = "İş Tanımı:";
            // 
            // personnel_name_surname_lb
            // 
            personnel_name_surname_lb.AutoSize = true;
            personnel_name_surname_lb.Location = new Point(32, 25);
            personnel_name_surname_lb.Name = "personnel_name_surname_lb";
            personnel_name_surname_lb.Size = new Size(76, 15);
            personnel_name_surname_lb.TabIndex = 0;
            personnel_name_surname_lb.Text = "İsim Soyisim:";
            // 
            // service_add_gB
            // 
            service_add_gB.Controls.Add(add_service);
            service_add_gB.Controls.Add(service_address);
            service_add_gB.Controls.Add(service_name);
            service_add_gB.Controls.Add(service_adress_lb);
            service_add_gB.Controls.Add(service_name_lb);
            service_add_gB.Location = new Point(12, 281);
            service_add_gB.Name = "service_add_gB";
            service_add_gB.Size = new Size(262, 185);
            service_add_gB.TabIndex = 3;
            service_add_gB.TabStop = false;
            service_add_gB.Text = "Servis Ekleme";
            // 
            // add_service
            // 
            add_service.Location = new Point(114, 153);
            add_service.Name = "add_service";
            add_service.Size = new Size(135, 23);
            add_service.TabIndex = 4;
            add_service.Text = "Servis Ekle";
            add_service.UseVisualStyleBackColor = true;
            add_service.Click += add_service_Click;
            // 
            // service_address
            // 
            service_address.Location = new Point(114, 51);
            service_address.Name = "service_address";
            service_address.Size = new Size(135, 96);
            service_address.TabIndex = 3;
            service_address.Text = "";
            // 
            // service_name
            // 
            service_name.Location = new Point(114, 22);
            service_name.Name = "service_name";
            service_name.Size = new Size(135, 23);
            service_name.TabIndex = 2;
            // 
            // service_adress_lb
            // 
            service_adress_lb.AutoSize = true;
            service_adress_lb.Location = new Point(68, 54);
            service_adress_lb.Name = "service_adress_lb";
            service_adress_lb.Size = new Size(40, 15);
            service_adress_lb.TabIndex = 1;
            service_adress_lb.Text = "Adres:";
            // 
            // service_name_lb
            // 
            service_name_lb.AutoSize = true;
            service_name_lb.Location = new Point(47, 25);
            service_name_lb.Name = "service_name_lb";
            service_name_lb.Size = new Size(61, 15);
            service_name_lb.TabIndex = 0;
            service_name_lb.Text = "Servis Adı:";
            // 
            // operation_add_gB
            // 
            operation_add_gB.Controls.Add(add_typeofsevice);
            operation_add_gB.Controls.Add(detailed_information);
            operation_add_gB.Controls.Add(operation_price);
            operation_add_gB.Controls.Add(operation_name);
            operation_add_gB.Controls.Add(detailed_information_lb);
            operation_add_gB.Controls.Add(operation_price_lb);
            operation_add_gB.Controls.Add(operation_name_lb);
            operation_add_gB.Location = new Point(280, 252);
            operation_add_gB.Name = "operation_add_gB";
            operation_add_gB.Size = new Size(262, 214);
            operation_add_gB.TabIndex = 4;
            operation_add_gB.TabStop = false;
            operation_add_gB.Text = "Hizmet Tipi Ekleme";
            // 
            // add_typeofsevice
            // 
            add_typeofsevice.Location = new Point(114, 182);
            add_typeofsevice.Name = "add_typeofsevice";
            add_typeofsevice.Size = new Size(135, 23);
            add_typeofsevice.TabIndex = 6;
            add_typeofsevice.Text = "Hizmet Ekle";
            add_typeofsevice.UseVisualStyleBackColor = true;
            add_typeofsevice.Click += add_typeofsevice_Click;
            // 
            // detailed_information
            // 
            detailed_information.Location = new Point(114, 80);
            detailed_information.Name = "detailed_information";
            detailed_information.Size = new Size(135, 96);
            detailed_information.TabIndex = 5;
            detailed_information.Text = "";
            // 
            // operation_price
            // 
            operation_price.Location = new Point(114, 51);
            operation_price.Name = "operation_price";
            operation_price.Size = new Size(135, 23);
            operation_price.TabIndex = 4;
            // 
            // operation_name
            // 
            operation_name.Location = new Point(114, 22);
            operation_name.Name = "operation_name";
            operation_name.Size = new Size(135, 23);
            operation_name.TabIndex = 3;
            // 
            // detailed_information_lb
            // 
            detailed_information_lb.AutoSize = true;
            detailed_information_lb.Location = new Point(10, 83);
            detailed_information_lb.Name = "detailed_information_lb";
            detailed_information_lb.Size = new Size(98, 15);
            detailed_information_lb.TabIndex = 2;
            detailed_information_lb.Text = "Detaylı Açıklama:";
            // 
            // operation_price_lb
            // 
            operation_price_lb.AutoSize = true;
            operation_price_lb.Location = new Point(67, 54);
            operation_price_lb.Name = "operation_price_lb";
            operation_price_lb.Size = new Size(41, 15);
            operation_price_lb.TabIndex = 1;
            operation_price_lb.Text = "Ücreti:";
            // 
            // operation_name_lb
            // 
            operation_name_lb.AutoSize = true;
            operation_name_lb.Location = new Point(39, 25);
            operation_name_lb.Name = "operation_name_lb";
            operation_name_lb.Size = new Size(69, 15);
            operation_name_lb.TabIndex = 0;
            operation_name_lb.Text = "Hizmet Adı:";
            // 
            // customer_add_gB
            // 
            customer_add_gB.Controls.Add(customer_phone_number);
            customer_add_gB.Controls.Add(add_customer);
            customer_add_gB.Controls.Add(customer_address);
            customer_add_gB.Controls.Add(customer_email);
            customer_add_gB.Controls.Add(customer_name_surname);
            customer_add_gB.Controls.Add(customer_adress_lb);
            customer_add_gB.Controls.Add(customer_email_lb);
            customer_add_gB.Controls.Add(customer_phone_number_lb);
            customer_add_gB.Controls.Add(customer_name_surname_lb);
            customer_add_gB.Location = new Point(12, 27);
            customer_add_gB.Name = "customer_add_gB";
            customer_add_gB.Size = new Size(262, 248);
            customer_add_gB.TabIndex = 5;
            customer_add_gB.TabStop = false;
            customer_add_gB.Text = "Müşteri Ekleme";
            // 
            // customer_phone_number
            // 
            customer_phone_number.Location = new Point(114, 56);
            customer_phone_number.Mask = "(999) 000-0000";
            customer_phone_number.Name = "customer_phone_number";
            customer_phone_number.Size = new Size(135, 23);
            customer_phone_number.TabIndex = 9;
            // 
            // add_customer
            // 
            add_customer.Location = new Point(114, 216);
            add_customer.Name = "add_customer";
            add_customer.Size = new Size(135, 23);
            add_customer.TabIndex = 8;
            add_customer.Text = "Müşteri Ekle";
            add_customer.UseVisualStyleBackColor = true;
            add_customer.Click += add_customer_Click;
            // 
            // customer_address
            // 
            customer_address.Location = new Point(114, 114);
            customer_address.Name = "customer_address";
            customer_address.Size = new Size(135, 96);
            customer_address.TabIndex = 7;
            customer_address.Text = "";
            // 
            // customer_email
            // 
            customer_email.Location = new Point(114, 85);
            customer_email.Name = "customer_email";
            customer_email.Size = new Size(135, 23);
            customer_email.TabIndex = 6;
            // 
            // customer_name_surname
            // 
            customer_name_surname.Location = new Point(114, 27);
            customer_name_surname.Name = "customer_name_surname";
            customer_name_surname.Size = new Size(135, 23);
            customer_name_surname.TabIndex = 4;
            // 
            // customer_adress_lb
            // 
            customer_adress_lb.AutoSize = true;
            customer_adress_lb.Location = new Point(68, 117);
            customer_adress_lb.Name = "customer_adress_lb";
            customer_adress_lb.Size = new Size(40, 15);
            customer_adress_lb.TabIndex = 3;
            customer_adress_lb.Text = "Adres:";
            // 
            // customer_email_lb
            // 
            customer_email_lb.AutoSize = true;
            customer_email_lb.Location = new Point(22, 88);
            customer_email_lb.Name = "customer_email_lb";
            customer_email_lb.Size = new Size(86, 15);
            customer_email_lb.TabIndex = 2;
            customer_email_lb.Text = "E-Posta Adresi:";
            // 
            // customer_phone_number_lb
            // 
            customer_phone_number_lb.AutoSize = true;
            customer_phone_number_lb.Location = new Point(6, 59);
            customer_phone_number_lb.Name = "customer_phone_number_lb";
            customer_phone_number_lb.Size = new Size(102, 15);
            customer_phone_number_lb.TabIndex = 1;
            customer_phone_number_lb.Text = "Telefon Numarası:";
            // 
            // customer_name_surname_lb
            // 
            customer_name_surname_lb.AutoSize = true;
            customer_name_surname_lb.Location = new Point(32, 30);
            customer_name_surname_lb.Name = "customer_name_surname_lb";
            customer_name_surname_lb.Size = new Size(76, 15);
            customer_name_surname_lb.TabIndex = 0;
            customer_name_surname_lb.Text = "İsim Soyisim:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaSayfaToolStripMenuItem, çıkışYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(551, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            anaSayfaToolStripMenuItem.Size = new Size(71, 20);
            anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            anaSayfaToolStripMenuItem.Click += anaSayfaToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(66, 20);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // PanelPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 476);
            Controls.Add(customer_add_gB);
            Controls.Add(operation_add_gB);
            Controls.Add(service_add_gB);
            Controls.Add(personnel_add_gB);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "PanelPage";
            Text = "Panel";
            Load += PanelPage_Load;
            personnel_add_gB.ResumeLayout(false);
            personnel_add_gB.PerformLayout();
            service_add_gB.ResumeLayout(false);
            service_add_gB.PerformLayout();
            operation_add_gB.ResumeLayout(false);
            operation_add_gB.PerformLayout();
            customer_add_gB.ResumeLayout(false);
            customer_add_gB.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox personnel_add_gB;
        private Button add_personnel;
        private TextBox personnel_department;
        private TextBox personnel_name_surname;
        private Label job_title_lb;
        private Label personnel_name_surname_lb;
        private GroupBox service_add_gB;
        private Button add_service;
        private RichTextBox service_address;
        private TextBox service_name;
        private Label service_adress_lb;
        private Label service_name_lb;
        private GroupBox operation_add_gB;
        private Button add_typeofsevice;
        private RichTextBox detailed_information;
        private TextBox operation_price;
        private TextBox operation_name;
        private Label detailed_information_lb;
        private Label operation_price_lb;
        private Label operation_name_lb;
        private GroupBox customer_add_gB;
        private Button add_customer;
        private RichTextBox customer_address;
        private TextBox customer_email;
        private TextBox customer_name_surname;
        private Label customer_adress_lb;
        private Label customer_email_lb;
        private Label customer_phone_number_lb;
        private Label customer_name_surname_lb;
        private MaskedTextBox customer_phone_number;
        private TextBox personnel_password;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaSayfaToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private CheckBox checkBox1;
        private MaskedTextBox personnel_username;
    }
}