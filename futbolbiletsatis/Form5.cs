using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futbolbiletsatis
{
    public partial class Form5 : Form
    {

        OleDbConnection Veritabani_Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data source=futbol.mdb");
        OleDbDataAdapter Veri_Adaptor;
        OleDbCommand Veri_Komutu;
        OleDbDataReader Veri_Oku;
        DataSet Veri_Seti;

        void Tablo_Ac(string tablo)
        {
            Veri_Adaptor = new OleDbDataAdapter("Select * from " + tablo, Veritabani_Baglanti);
            Veri_Seti = new DataSet();
            Veritabani_Baglanti.Open();
        }

        void Tablo_Kapat()
        {
            Veritabani_Baglanti.Close();
        }

        void Tablo_Veri_Getir(string s)
        {
            Tablo_Ac(s);
            Veri_Adaptor.Fill(Veri_Seti, s);
            dataGridView1.DataSource = Veri_Seti.Tables[s];
            Tablo_Kapat();
        }



        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Tablo_Veri_Getir("kullanici_biletleri");
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
