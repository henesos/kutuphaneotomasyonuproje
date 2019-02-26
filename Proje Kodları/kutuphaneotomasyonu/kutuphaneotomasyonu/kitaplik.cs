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
    public partial class kitaplik : Form
    {
        public kitaplik()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MCagr\Desktop\kutuphaneveritabani.mdb");


        

        public void verilerigoster(string veriler)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitaplik formkapa = new kitaplik();
            formkapa.Close();
            kullanicimenu form = new kullanicimenu();
            form.Show();
            this.Hide();
        }

        private void kitaplik_Load(object sender, EventArgs e)
        {
            verilerigoster("Select * from kitaplik");
        }

        private void kitaplik_FormClosing(object sender, FormClosingEventArgs e)
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

        private void kitapara_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;

            string olay = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string id = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
 

            kitapisim.Text = olay;
            kitapsayfa.Text = id;
          
        }
        static public string alankisi5;

        private void button1_Click(object sender, EventArgs e)
        {
            string oduncdurumu,onaydurumu;

            oduncdurumu = "Teslim Edilmedi";
            onaydurumu = "Onaylanmadi";

            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM uye where tcno='" + alankisi5 + "'", baglanti);
            komut1.Connection = baglanti;
            komut1.ExecuteNonQuery();
            OleDbDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
           
                telno.Text = dr["telno"].ToString();



            }
            baglanti.Close();

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into odunc (alankisitcno,alinankitap,alinmatarihi,sontarih,oduncdurumu,alankisitelno,onay) values (@alankisitcno,@alinankitap,@alinmatarihi,@sontarih,@oduncdurumu,@alankisitelno,@onay)", baglanti);
            komut.Parameters.AddWithValue("@alankisitcno", alankisi5);
            komut.Parameters.AddWithValue("@alinankitap",kitapisim.Text);
            komut.Parameters.AddWithValue("@alinmatarihi", alinantarih.Text);
            komut.Parameters.AddWithValue("@sontarih", sontarih.Text);
            komut.Parameters.AddWithValue("@oduncdurumu", oduncdurumu);
            komut.Parameters.AddWithValue("@alankisitelno",telno.Text);
            komut.Parameters.AddWithValue("@onay", onaydurumu);
          
            komut.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("Kitabı Ödünç Almak için Lütfen Yöneticinden Onay İsteyiniz !", "Bilgi");
        }
    }
}
