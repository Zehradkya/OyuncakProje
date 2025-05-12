namespace Oyuncakci
{
    partial class KategoriEkleForm
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
            label1 = new Label();
            txtKategoriAdi = new TextBox();
            label2 = new Label();
            txtAciklama = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(160, 94);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Kategori Adı:";
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(321, 97);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(187, 23);
            txtKategoriAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(160, 144);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(321, 146);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(187, 23);
            txtAciklama.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(433, 197);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // KategoriEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(txtAciklama);
            Controls.Add(label2);
            Controls.Add(txtKategoriAdi);
            Controls.Add(label1);
            Name = "KategoriEkleForm";
            Text = "KategoriEkleForm";
            Load += KategoriEkleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKategoriAdi;
        private Label label2;
        private TextBox txtAciklama;
        private Button btnKaydet;
    }
}