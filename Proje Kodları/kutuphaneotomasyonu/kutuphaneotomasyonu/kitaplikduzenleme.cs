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
    public partial class kitaplikduzenleme : Form
    {
        public kitaplikduzenleme()
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
            private void kitaplikduzenleme_Load(object sender, EventArgs e)
        {
            verilerigoster("Select * from kitaplik");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kitaplikduzenleme formkapa = new kitaplikduzenleme();
            formkapa.Close();
            yoneticimenu form = new yoneticimenu();
            form.Show();
            this.Hide();
        }

        private void kitaplikduzenleme_FormClosing(object sender, FormClosingEventArgs e)
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
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into kitaplik (kitapismi,kitapyazari,kitapbasimyili,kitapsayfa,kitaptur) values (@adi,@yazari,@basimyili,@sayfa,@turu)", baglanti);
            komut.Parameters.AddWithValue("@adi", kitapadi.Text);
            komut.Parameters.AddWithValue("@yazari", kitapyazari.Text);
            komut.Parameters.AddWithValue("@basimyili", kitapbasimyili.Text);
            komut.Parameters.AddWithValue("@sayfa", kitapsayfasi.Text);
            komut.Parameters.AddWithValue("@turu", kitapturu.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * from kitaplik");
            baglanti.Close();

            kitapadi.Clear();
            kitapyazari.Clear();
            kitapbasimyili.Clear();
            kitapsayfasi.Clear();

            MessageBox.Show("Kitap başarı ile eklendi!", "Bilgi");


        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult x = MessageBox.Show("Bu kitabı silmek istediğinizden emin misiniz?", "Çıkış!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {



                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("delete from kitaplik where kitapid=@kitapid", baglanti);
                komut.Parameters.AddWithValue("@kitapid", kitapid.Text);
                komut.ExecuteNonQuery();
                verilerigoster("select * from kitaplik");
                baglanti.Close();
                MessageBox.Show("Kitap başarı ile silindi!", "Bilgi");


                kitapid.Clear();
                kitapadi.Clear();
                kitapyazari.Clear();
                kitapbasimyili.Clear();
                kitapsayfasi.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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

            kitapid.Text = id;
            kitapadi.Text = adi;
            kitapyazari.Text = yazari;
            kitapbasimyili.Text = yili;
            kitapsayfasi.Text = sayfasi;
            kitapturu.Text = turu; 

        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(" update kitaplik set kitapismi='"+kitapadi.Text+"',kitapyazari='"+kitapyazari.Text+"',kitapbasimyili='"+kitapbasimyili.Text+"',kitapsayfa ='"+kitapsayfasi.Text+"',kitaptur='"+kitapturu.Text+"' where kitapismi='"+kitapadi.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("select * from kitaplik");
            baglanti.Close();
            MessageBox.Show("Kitap bilgileri başarı ile güncellendi.", "Bilgi");
        }

        private void button6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void arabox_TextChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {


                OleDbCommand komut = new OleDbCommand("Select * from kitaplik where kitapismi like '%" + arabox.Text + "%'", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else if(radioButton2.Checked)
            {

                OleDbCommand komut = new OleDbCommand("Select * from kitaplik where kitapyazari like '%" + arabox.Text + "%'", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();

            }
            else if(radioButton3.Checked)

            {
                OleDbCommand komut = new OleDbCommand("Select * from kitaplik where kitaptur like '%" + arabox.Text + "%'", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void kitapid_TextChanged(object sender, EventArgs e)
        {

        }

        private void guncel_Click(object sender, EventArgs e)
        {
            verilerigoster("select * from kitaplik");
        }
    }
}
// kitapyazari like '%" + arabox.Text + "%' kitaptur like '%" + arabox.Text + "%'