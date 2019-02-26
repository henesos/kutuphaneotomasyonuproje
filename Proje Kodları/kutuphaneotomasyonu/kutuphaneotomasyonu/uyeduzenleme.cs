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
    public partial class uyeduzenleme : Form
    {
        public uyeduzenleme()
        {
            InitializeComponent();
        }

        public OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MCagr\Desktop\kutuphaneveritabani.mdb");

        public void verilerigoster(string veriler)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

            private void uyeduzenleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneveritabaniDataSet.uye' table. You can move, or remove it, as needed.
            this.uyeTableAdapter.Fill(this.kutuphaneveritabaniDataSet.uye);

            verilerigoster("Select * from uye");



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            uyeduzenleme formkapa = new uyeduzenleme();
            formkapa.Close();
            yoneticimenu form = new yoneticimenu();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string adi = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string yazari = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string yili = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string sayfasi = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string turu = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string uyeturu = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();

            kulid.Text = id;
            kulisim.Text = adi;
            kultelno.Text = yazari;
            kultcno.Text = yili;
            kulsifre.Text = sayfasi;
            kulmail.Text = turu;
            kulltur.Text = uyeturu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(" update uye set İsim='" + kulisim.Text + "',telno='" + kultelno.Text + "',tcno='" + kultcno.Text + "',sifre ='" + kulsifre.Text + "',email='" + kulmail.Text + "',uyelikTuru='"+kulltur.Text+"' where tcno='" + kultcno.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("select * from uye");
            baglanti.Close();
            MessageBox.Show("Üye bilgileri başarı ile güncellendi.", "Bilgi");
        }

        private void uyeduzenleme_FormClosing(object sender, FormClosingEventArgs e)
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

        private void arabox_TextChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {


                OleDbCommand komut = new OleDbCommand("Select * from uye where İsim like '%" + arabox.Text + "%'", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else if (radioButton2.Checked)
            {

                OleDbCommand komut = new OleDbCommand("Select * from uye where tcno like '%" + arabox.Text + "%'", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            verilerigoster("select * from uye");
        }
    }
}
