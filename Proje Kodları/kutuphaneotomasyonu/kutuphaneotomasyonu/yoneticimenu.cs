using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace kutuphaneotomasyonu
{
    public partial class yoneticimenu : Form
    {
        public yoneticimenu()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MCagr\Desktop\kutuphaneveritabani.mdb");

        private void button1_Click(object sender, EventArgs e)
        {
            yoneticimenu formkapa = new yoneticimenu();
            formkapa.Close();
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Oturumunuzu kapatmak istediğinize emin misiniz?", "Oturumu Kapat", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {


                yoneticimenu formkapa = new yoneticimenu();
                formkapa.Close();
                Form1 form = new Form1();
                form.Show();
                this.Hide();

            }
         

        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            yoneticimenu formkapa = new yoneticimenu();
            formkapa.Close();
            kitaplik form = new kitaplik();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yoneticimenu formkapa = new yoneticimenu();
            formkapa.Close();
            kitaplikduzenleme form = new kitaplikduzenleme();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            yoneticimenu kapat = new yoneticimenu();
            kapat.Close();
            oduncdurum gecis = new oduncdurum();
            gecis.Show();
            this.Hide();
        }

        static public string girenkisi;
       

        private void yoneticimenu_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select İsim from uye where tcno='"+girenkisi+"'";
            string deger;
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            
            deger = (string)komut.ExecuteScalar();
            baglanti.Close();
            girenisim.Text = deger;
            




        }
        System.Drawing.Point baslangicKonumu;

        protected override void WndProc(ref Message msj)
        {
            const int WM_SYSCOMMAND = 0X0112;
            const int SC_MOVE = 0xF010;

            switch (msj.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = msj.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref msj);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yoneticimenu_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {

                Application.ExitThread();

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            yoneticimenu formkapa = new yoneticimenu();
            formkapa.Close();
            uyelikbilgilerimyonet form = new uyelikbilgilerimyonet();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            yoneticimenu formkapa = new yoneticimenu();
            formkapa.Close();
            uyeduzenleme form = new uyeduzenleme();
            form.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label8.Text = dt.ToLongDateString();
            label7.Text = dt.ToLongTimeString();
             
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
