using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progresbar20bilp0025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int karaktesayisi = textBox2.Text.Length;
            if(karaktesayisi>0 && karaktesayisi <4)
            {
                progressBar1.Value = 1;
                progressBar1.ForeColor = Color.Red;
                label4.Text = "Zayıf";
            }
            else if (karaktesayisi >=4 && karaktesayisi < 8)
            {
                progressBar1.Value = 2;
                progressBar1.ForeColor = Color.Yellow;
                label4.Text = "Orta";
            }
            else if (karaktesayisi >= 8)
            {
                progressBar1.Value = 3;
                progressBar1.ForeColor = Color.Green;
                label4.Text = "Güçlü";
            }
            else
            {
                progressBar1.Value = 0;
            }
                   
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
                label5.Text = "Şifreler Eşit Değil";
            else
                label5.Text = "";
        }
    }
}
