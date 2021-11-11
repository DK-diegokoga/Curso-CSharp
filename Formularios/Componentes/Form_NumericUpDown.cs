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
    public partial class Form_NumericUpDown : Form
    {
        public Form_NumericUpDown()
        {
            InitializeComponent();
        }

        private void Form_NumericUpDown_Load(object sender, EventArgs e)
        {

        }

        private void btn_definir_Click(object sender, EventArgs e)
        {
            if ((Decimal.Parse(txt_numero.Text) >= n_up_down.Minimum)
                & (Decimal.Parse(txt_numero.Text) <= n_up_down.Minimum))
            {
                n_up_down.Value = Decimal.Parse(txt_numero.Text);
            }

        }
    }
}
