using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futbolbiletsatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TransparencyKey = Color.Gray;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
