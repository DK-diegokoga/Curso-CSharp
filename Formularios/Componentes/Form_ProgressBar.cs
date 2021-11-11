using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Form_ProgressBar : Form
    {
        public Form_ProgressBar()
        {
            InitializeComponent();
        }

        private void Form_ProgressBar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox1.Text) >= progressBar1.Value) & (int.Parse(textBox1.Text) <= progressBar1.Value))
            {
                progressBar1.Value = int.Parse(textBox1.Text);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(textBox2.Text);
            for (int i = 0; i < int.Parse(textBox2.Text);i++)
            {
                progressBar1.Value = i;
                //Thread.Sleep(200);
            }
        }
    }
}
