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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formkapa = new Form1();
            formkapa.Close();
            kayit form = new kayit();
            form.Show();
            this.Hide();
        }




        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MCagr\Desktop\kutuphaneveritabani.mdb");

        private void button1_Click(object sender, EventArgs e)
        {
			
                
            				baglanti.Open();
				OleDbCommand giris = new OleDbCommand("Select * from uye where tcno='" + textBox1.Text.ToString() + "'", baglanti);
				OleDbCommand giris2 = new OleDbCommand("Select * from uye where sifre='" + textBox2.Text.ToString() + "'", baglanti);
				OleDbCommand giris3 = new OleDbCommand("Select * from uye where uyelikTuru='" + Text.ToString() + "'", baglanti);
				OleDbDataReader okuyucu = giris.ExecuteReader();
				String admin, normaluye,yetkisiz;
				admin = "yonetici";
				normaluye = "uye";
            yetkisiz = "yetkisiz";
				if (okuyucu.Read()==true)
				{

					if (textBox1.Text.ToString() == okuyucu["tcno"].ToString() && textBox2.Text.ToString() == okuyucu["sifre"].ToString() && okuyucu["uyelikTuru"].ToString() == admin)
					{
                        yoneticimenu.girenkisi = textBox1.Text;
                        uyelikbilgilerimyonet.girenkisi2 = textBox1.Text;

                    yoneticimenu form = new yoneticimenu();
						form.Show();
						Form1 formkapa = new Form1();
						formkapa.Close();
						this.Hide();
					}
					else if (textBox1.Text.ToString() == okuyucu["tcno"].ToString() && textBox2.Text.ToString() == okuyucu["sifre"].ToString() && okuyucu["uyelikTuru"].ToString() == normaluye)
					{
                    kullanicimenu.girenkisi1 = textBox1.Text;
                    uyelikbilgilerimkul.girenkisi3 = textBox1.Text;
                    oduncalmagecmisi.girenkisi4 = textBox1.Text;
                    kitaplik.alankisi5 = textBox1.Text;
                    kullanicimenu form = new kullanicimenu();
					form.Show();
					this.Hide();
					Form1 formkapa = new Form1();
					formkapa.Close();
					this.Hide();

				    }
                    else if (okuyucu["uyelikTuru"].ToString() == yetkisiz)
                {
                    MessageBox.Show("Lütfen kütüphane yetkilisi ile iletişime geçerek üyeliğinizi aktifleştirin!");
                }
					
				}
				else
				{
					MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış !!");
				}

				baglanti.Close();
			


		}
     

		private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
