namespace Oyuncakci
{
    partial class LoginForm
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
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;

        private void InitializeComponent()
        {
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.Location = new Point(30, 30);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(100, 20);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.Location = new Point(30, 70);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(100, 20);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(140, 30);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(180, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(140, 70);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(180, 23);
            txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(140, 110);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(100, 30);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.Click += btnGiris_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(380, 180);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblSifre);
            Controls.Add(txtSifre);
            Controls.Add(btnGiris);
            Name = "LoginForm";
            Text = "Giriş Paneli";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}