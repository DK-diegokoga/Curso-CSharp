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
    public partial class Form_TrackBar : Form
    {
        public Form_TrackBar()
        {
            InitializeComponent();
        }

        private void Form_TrackBar_Load(object sender, EventArgs e)
        {
            txt_valor.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txt_valor.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }

        private void btn_definir_Click(object sender, EventArgs e)
        {
            if(int.Parse(txt_valor.Text) < trackBar1.Minimum)
            {
                MessageBox.Show("Valor muito baixo");
                return;
            }
            if (int.Parse(txt_valor.Text) > trackBar1.Maximum)
            {
                MessageBox.Show("Valor muito grande");
                return;
            }
            trackBar1.Value = int.Parse(txt_valor.Text);
        }
    }
}
