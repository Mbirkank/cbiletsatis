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
    public partial class Form6 : Form
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






        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            Veritabani_Baglanti.Open();
            Veri_Komutu.Connection = Veritabani_Baglanti;
            Veri_Komutu.CommandText = "Insert into maclar (mac,mac_tarihi,stad) values " +
             "('" + Txt_Mac.Text + "','" + dateTimePicker1.Text + "','" + Txt_Stad.Text + "')";
            Veri_Komutu.ExecuteNonQuery();
            Veritabani_Baglanti.Close();
            MessageBox.Show("Maç Eklendi!");
        }
    }
}
