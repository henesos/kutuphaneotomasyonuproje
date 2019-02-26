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
    public partial class oduncdurum : Form
    {
        public oduncdurum()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yoneticimenu gecis = new yoneticimenu();
            gecis.Show();
            oduncdurum kapat = new oduncdurum();
            kapat.Close();
            this.Close();
        }

        private void oduncdurum_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;

            string olay = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string id = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string adi = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string yazari = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string yili = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string sayfasi = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string turu = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();

            oduncolayno.Text = olay;
            kultcno.Text = id;
            kitapisim.Text = adi;
            kulodunctarih.Text = yazari;
            kulteslimtarih.Text = yili;
            kultelno.Text = sayfasi;
            kulodunconay.Text = turu;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            yoneticimenu form = new yoneticimenu();
            form.Show();
            oduncdurum formkapa = new oduncdurum();
            formkapa.Close();
            this.Hide();
        }

        public OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MCagr\Desktop\kutuphaneveritabani.mdb");

        public void verilerigoster(string veriler)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

            private void oduncdurum_Load(object sender, EventArgs e)
        {
            verilerigoster("Select * from odunc");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(" update odunc set onay='" + kulodunconay.Text + "' where kimlik=@kimlik1", baglanti);
            komut.Parameters.AddWithValue("@kimlik1", oduncolayno.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select * from odunc");
            baglanti.Close();
            MessageBox.Show("Ödünç verme işlemi başarı ile onaylanmıştır.", "Bilgi");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Kitap Teslimat Onayı", "Teslimat", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {



               

                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into oduncgecmisi (alankisitcnosu,aldigikitap)values (@atcno,@kitap)", baglanti);
                komut.Parameters.AddWithValue("@tcno", kultcno.Text);
                komut.Parameters.AddWithValue("@kitap", kitapisim.Text);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kitap Teslim Alındı.", "Bilgi");

                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("delete from odunc where kimlik=@oduncolayno", baglanti);
                komut1.Parameters.AddWithValue("@oduncolayno", oduncolayno.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();

                verilerigoster("Select * from odunc");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            oduncdurum formkapa = new oduncdurum();
            formkapa.Close();
            yoneticimenu form = new yoneticimenu();
            form.Show();
            this.Hide();
        }
    }
}
