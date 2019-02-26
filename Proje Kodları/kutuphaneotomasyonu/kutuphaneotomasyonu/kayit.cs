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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }

        public OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MCagr\Desktop\kutuphaneveritabani.mdb");

        private void kayit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit formkapa = new kayit();
            formkapa.Close();
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
           
           
        }

        private void kayit_FormClosing(object sender, FormClosingEventArgs e)
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
            string sif1, sif2;
            sif1 = kayitsifre1.Text;
            sif2 = kayifsifre2.Text;

            
                if (sif1 == sif2)
                {
                baglanti.Open();
                    string a;
                    a = "yetkisiz";
                    OleDbCommand komut = new OleDbCommand("insert into uye (İsim,telno,tcno,sifre,email,uyelikTuru) values (@ismi,@telnosu,@tcnosu,@sifresi,@emaili,@uyelikturu)", baglanti);
                    komut.Parameters.AddWithValue("@ismi", kayitisim.Text);
                    komut.Parameters.AddWithValue("@telnosu", kayittelno.Text);
                    komut.Parameters.AddWithValue("@tcnosu", kayittcno.Text);
                    komut.Parameters.AddWithValue("@sifresi", kayitsifre1.Text);
                    komut.Parameters.AddWithValue("@emaili", kayitmail.Text);
                    komut.Parameters.AddWithValue("uyelikturu", a);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt başarı ile tamamlandı. Lütfen üyeliğinizi aktif etmek için kütüphane yöneticisi ile iletişime geçin!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kayit formkapa = new kayit();
                formkapa.Close();
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
                else
                {
                    MessageBox.Show("Şifreler Uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }
    }
    }
