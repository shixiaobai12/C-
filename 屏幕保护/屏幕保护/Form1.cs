using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 屏幕保护
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int deltX = 10;
        int deltY = 8;
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            this.label2.Left += deltX;
            this.label2.Top += deltY;
            if (this.label2.Top < 0 ||
                this.label2.Top + this.label2.Height > this.Height)
                deltY = -deltY;
            if (this.label2.Left < 0 ||
                this.label2.Left  + this.label2.Width > this.Width)
                deltX = -deltX;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
