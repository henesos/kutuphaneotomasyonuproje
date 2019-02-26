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
    public partial class kullanicimenu : Form
    {
        public kullanicimenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Oturumunuzu kapatmak istediğinize emin misiniz?", "Oturumu Kapat", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {


                kullanicimenu formkapa = new kullanicimenu();
                formkapa.Close();
                Form1 form = new Form1();
                form.Show();
                this.Hide();

            }
        }

        static public string girenkisi1;

        private void button2_Click(object sender, EventArgs e)
        {
            kullanicimenu formkapa = new kullanicimenu();
            formkapa.Close();
            kitaplik form = new kitaplik();
            form.Show();
            this.Hide();
        }

        private void kullanicimenu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label8.Text = dt.ToLongDateString();
            label4.Text = dt.ToLongTimeString();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MCagr\Desktop\kutuphaneveritabani.mdb");
        private void kullanicimenu_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select İsim from uye where tcno='" + girenkisi1 + "'";
            string deger;
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);

            deger = (string)komut.ExecuteScalar();
            baglanti.Close();
            label1.Text = deger;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanicimenu formkapa = new kullanicimenu();
            formkapa.Close();
            oduncalmagecmisi form = new oduncalmagecmisi();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullanicimenu formkapa = new kullanicimenu();
            formkapa.Close();
            uyelikbilgilerimkul form = new uyelikbilgilerimkul();
            form.Show();
            this.Hide();
        }
    }
}
