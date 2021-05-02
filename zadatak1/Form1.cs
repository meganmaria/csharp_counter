using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int br1;
        private void button1_Click(object sender, EventArgs e)
        {
            br1++;
            label1.Text = ("Tipka 1 je stisnuta " + br1 + " puta.");
        }

        int br2;
        private void button2_Click(object sender, EventArgs e)
        {
            br2++;
            label2.Text = ("Tipka 2 je stisnuta " + br2 + " puta.");
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (br2 != 0)
                label3.Text = "Pritisnula se tipka 1";
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            if (br1 != 0)
                label3.Text = "Pritisnula se tipka 2";
        }
    }
}
