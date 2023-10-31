using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme29
{
    public partial class Form1 : Form
    {
        byte sure;
        byte ucret;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sure = Convert.ToByte(textBox1.Text);
            if (sure < 0 )
            {
                ucret = 0;
            }
            if (sure > 24)
            {
                ucret = 50;
            }
            if (sure > 16 && sure <= 24)
            {
                ucret = 30;
            }
            if (sure > 10 && sure <= 16)
            {
                ucret = 20;
            }
            if (sure > 6 && sure <= 10)
            {
                ucret = 15;
            }
            if (sure > 3 && sure <= 6)
            {
                ucret = 8;
            }
            if (sure > 1 && sure <= 3)
            {
                ucret = 4;
            }
            if (sure > 0 && sure <= 1)
            {
                ucret = 2;
            }
            label3.Text = ucret.ToString() + "₺";
        }
    }
}
