using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uzunkenar = 0;
            int kısakenar=0;
            int sonuc = 0;
            kısakenar= Convert.ToInt32(textBox1.Text);
            uzunkenar = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked)
            {
                sonuc = kısakenar * uzunkenar;
            }
            else if (radioButton2.Checked)
            {
                sonuc=(kısakenar*2)+(uzunkenar*2);
            }
            else
            {
                MessageBox.Show("lütfen seçim yapınız");
            }

            label3.Text = sonuc.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
