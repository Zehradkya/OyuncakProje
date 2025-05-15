namespace Oyuncakci
{
    partial class OdemeForm
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
            cmbSiparis = new ComboBox();
            cmbOdemeTuru = new ComboBox();
            txtTutar = new TextBox();
            btnOdemeKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbSiparis
            // 
            cmbSiparis.AccessibleDescription = "";
            cmbSiparis.AccessibleName = "";
            cmbSiparis.FormattingEnabled = true;
            cmbSiparis.Location = new Point(282, 114);
            cmbSiparis.Name = "cmbSiparis";
            cmbSiparis.Size = new Size(436, 23);
            cmbSiparis.TabIndex = 0;
            cmbSiparis.Text = "Sipariş seçimi\n";
            cmbSiparis.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbOdemeTuru
            // 
            cmbOdemeTuru.FormattingEnabled = true;
            cmbOdemeTuru.Location = new Point(282, 159);
            cmbOdemeTuru.Name = "cmbOdemeTuru";
            cmbOdemeTuru.Size = new Size(436, 23);
            cmbOdemeTuru.TabIndex = 1;
            cmbOdemeTuru.Text = "Ödeme türü";
            cmbOdemeTuru.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(282, 205);
            txtTutar.Name = "txtTutar";
            txtTutar.ReadOnly = true;
            txtTutar.Size = new Size(436, 23);
            txtTutar.TabIndex = 2;
            txtTutar.Text = "Siparişin toplam tutarı";
            txtTutar.TextChanged += textBox1_TextChanged;
            // 
            // btnOdemeKaydet
            // 
            btnOdemeKaydet.Font = new Font("Segoe UI", 11F);
            btnOdemeKaydet.Location = new Point(578, 266);
            btnOdemeKaydet.Name = "btnOdemeKaydet";
            btnOdemeKaydet.Size = new Size(140, 30);
            btnOdemeKaydet.TabIndex = 3;
            btnOdemeKaydet.Text = "Ödemeyi kaydet";
            btnOdemeKaydet.UseVisualStyleBackColor = true;
            btnOdemeKaydet.Click += btnOdemeKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(152, 117);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 4;
            label1.Text = "Sipariş seçimi";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(163, 158);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 5;
            label2.Text = "Ödeme türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(95, 204);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 6;
            label3.Text = "Siparişin toplam tutarı";
            // 
            // OdemeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOdemeKaydet);
            Controls.Add(txtTutar);
            Controls.Add(cmbOdemeTuru);
            Controls.Add(cmbSiparis);
            Name = "OdemeForm";
            Text = "OdemeForm";
            Load += OdemeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSiparis;
        private ComboBox cmbOdemeTuru;
        private TextBox txtTutar;
        private Button btnOdemeKaydet;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}