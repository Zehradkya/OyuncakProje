namespace Oyuncakci
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("f");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("f");
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            new MusteriForm().ShowDialog();
        }
        

        private void btnOyuncak_Click(object sender, EventArgs e)
        {
            new OyuncakForm().ShowDialog();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            new SiparisForm().ShowDialog();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            new OdemeForm().ShowDialog();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            new StokGirisForm().ShowDialog();
        }

        private void btnCalisan_Click(object sender, EventArgs e)
        {
            new CalisanForm().ShowDialog();
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            new GecmisSiparisForm().ShowDialog();
        }
      

        
    }
}
