namespace AutoCare_Scheduler___Araç_Bakım_Randevu_Sistemi.Forms
{
    partial class LoginPage
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
            username_lb = new Label();
            Password_lb = new Label();
            username_tb = new TextBox();
            password_tb = new MaskedTextBox();
            login_bt = new Button();
            SuspendLayout();
            // 
            // username_lb
            // 
            username_lb.AutoSize = true;
            username_lb.Location = new Point(12, 15);
            username_lb.Name = "username_lb";
            username_lb.Size = new Size(76, 15);
            username_lb.TabIndex = 0;
            username_lb.Text = "Kullanıcı Adı:";
            // 
            // Password_lb
            // 
            Password_lb.AutoSize = true;
            Password_lb.Location = new Point(55, 44);
            Password_lb.Name = "Password_lb";
            Password_lb.Size = new Size(33, 15);
            Password_lb.TabIndex = 1;
            Password_lb.Text = "Şifre:";
            // 
            // username_tb
            // 
            username_tb.Location = new Point(94, 12);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(135, 23);
            username_tb.TabIndex = 3;
            // 
            // password_tb
            // 
            password_tb.Location = new Point(94, 41);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(135, 23);
            password_tb.TabIndex = 4;
            // 
            // login_bt
            // 
            login_bt.Location = new Point(12, 70);
            login_bt.Name = "login_bt";
            login_bt.Size = new Size(217, 23);
            login_bt.TabIndex = 5;
            login_bt.Text = "Giriş Yap";
            login_bt.UseVisualStyleBackColor = true;
            login_bt.Click += login_bt_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 101);
            Controls.Add(login_bt);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(Password_lb);
            Controls.Add(username_lb);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoCare Scheduler - Giriş";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username_lb;
        private Label Password_lb;
        private TextBox username_tb;
        private MaskedTextBox password_tb;
        private Button login_bt;
    }
}