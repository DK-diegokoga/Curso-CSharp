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
    public partial class Form_Lista_Veiculos : Form
    {
        Form_Principal fp;
        public Form_Lista_Veiculos(String v, Form_Principal f)
        {
            InitializeComponent();

            txt_listaVeiculos.Text = v;
            fp = f;
            f.num = 10;
        }

        private void Form_Lista_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.txt_listaVeiculos.Text = txt_listaVeiculos.Text;
        }
    }
}
