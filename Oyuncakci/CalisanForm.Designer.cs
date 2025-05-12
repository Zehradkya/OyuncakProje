namespace Oyuncakci
{
    partial class CalisanForm
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            txtPozisyon = new TextBox();
            cmbRol = new ComboBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            dgvCalisanlar = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(211, 32);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(120, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(495, 37);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(121, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(211, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(495, 84);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(121, 23);
            txtTelefon.TabIndex = 3;
            // 
            // txtPozisyon
            // 
            txtPozisyon.Location = new Point(495, 138);
            txtPozisyon.Name = "txtPozisyon";
            txtPozisyon.Size = new Size(121, 23);
            txtPozisyon.TabIndex = 4;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(211, 130);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 5;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(187, 186);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(294, 186);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(407, 186);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(508, 186);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 23);
            btnTemizle.TabIndex = 9;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // dgvCalisanlar
            // 
            dgvCalisanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalisanlar.Location = new Point(35, 228);
            dgvCalisanlar.Name = "dgvCalisanlar";
            dgvCalisanlar.Size = new Size(753, 197);
            dgvCalisanlar.TabIndex = 10;
            dgvCalisanlar.CellContentClick += dgvCalisanlar_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 35);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 11;
            label1.Text = "Çalışan Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 40);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 12;
            label2.Text = "Çalışan Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 87);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 13;
            label3.Text = "E-posta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 92);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 14;
            label4.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 138);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 15;
            label5.Text = "Rol Seç";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 138);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 16;
            label6.Text = "Pozisyon";
            // 
            // CalisanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCalisanlar);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(cmbRol);
            Controls.Add(txtPozisyon);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "CalisanForm";
            Text = "CalisanForm";
            Load += CalisanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private TextBox txtPozisyon;
        private ComboBox cmbRol;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private DataGridView dgvCalisanlar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}