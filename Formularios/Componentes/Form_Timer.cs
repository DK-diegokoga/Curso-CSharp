using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Form_Timer : Form
    {
        int num;
        int px;
        int py;

        public Form_Timer()
        {
            InitializeComponent();
        }

        private void Form_Timer_Load(object sender, EventArgs e)
        {
            num = 0;
            px = pictureBox1.Location.X;
            py = pictureBox1.Location.Y;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            //timer1.Interval = 500;
            timer1.Start();
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            px+=10;
            if (px >= 620)
            {
                px = 13;
            }
            pictureBox1.Location = new Point(px,py);
            px = pictureBox1.Location.X;
        }

        private void btn_catshark_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btn_pararCat_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
    }
}
