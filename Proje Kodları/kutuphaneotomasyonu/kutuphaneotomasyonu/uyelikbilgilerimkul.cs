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
    public partial class uyelikbilgilerimkul : Form
    {
        public uyelikbilgilerimkul()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyelikbilgilerimkul formkapa = new uyelikbilgilerimkul();
            formkapa.Close();
            kullanicimenu form = new kullanicimenu();
            form.Show();
            this.Hide();
        }

        static public string girenkisi3;

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MCagr\Desktop\kutuphaneveritabani.mdb");

        private void uyelikbilgilerimkul_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM uye where tcno='" + girenkisi3 + "'", baglanti);
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                kulid.Text = dr["Kimlik"].ToString();
                kulisim.Text = dr["İsim"].ToString();
                kultc.Text = dr["tcno"].ToString();
                kultelno.Text = dr["telno"].ToString();
                kulmail.Text = dr["email"].ToString();
                kulsifre.Text = dr["sifre"].ToString();



            }
            baglanti.Close();
        }

        private void uyelikbilgilerimkul_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (kulsifre.Text == kulsifre1.Text)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand(" update uye set İsim='" + kulisim.Text + "',telno='" + kultelno.Text + "',email ='" + kulmail.Text + "',sifre='" + kulsifre.Text + "' where tcno='" + kultc.Text + "'", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kitap bilgileri başarı ile güncellendi.", "Bilgi");


                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("SELECT * FROM uye where tcno='" + girenkisi3 + "'", baglanti);
                komut1.Connection = baglanti;
                komut1.ExecuteNonQuery();
                OleDbDataReader dr = komut1.ExecuteReader();
                if (dr.Read())
                {
                    kulid.Text = dr["Kimlik"].ToString();
                    kulisim.Text = dr["İsim"].ToString();
                    kultc.Text = dr["tcno"].ToString();
                    kultelno.Text = dr["telno"].ToString();
                    kulmail.Text = dr["email"].ToString();
                    kulsifre.Text = dr["sifre"].ToString();



                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor!!", "Hata!");
            }
        }
    }
}

