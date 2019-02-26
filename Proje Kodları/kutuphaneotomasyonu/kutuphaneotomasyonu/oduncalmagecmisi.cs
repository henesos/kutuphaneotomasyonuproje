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
    public partial class oduncalmagecmisi : Form
    {
        public oduncalmagecmisi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oduncalmagecmisi formkapa = new oduncalmagecmisi();
            formkapa.Close();
            kullanicimenu form = new kullanicimenu();
            form.Show();
            this.Hide();
        }

        private void oduncalmagecmisi_FormClosing(object sender, FormClosingEventArgs e)
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

        public OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MCagr\Desktop\kutuphaneveritabani.mdb");

        public void verilerigoster(string veriler)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        static public string girenkisi4;
        private void oduncalmagecmisi_Load(object sender, EventArgs e)
        {

            verilerigoster("Select * from oduncgecmisi where alankisitcnosu='"+girenkisi4+"'");
        }
    }
}
