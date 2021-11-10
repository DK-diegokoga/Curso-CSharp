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
    public partial class Form_ComboBox : Form
    {
        public Form_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_trasportes.Text);
        }

        private void btn_limparElementos_Click(object sender, EventArgs e)
        {
            cb_trasportes.Items.Clear();
        }

        private void btn_resetarElementos_Click(object sender, EventArgs e)
        {
            cb_trasportes.Items.Clear();
            List<string> lista = new List<string>();
            lista.Add("Carro");
            lista.Add("Avião");
            lista.Add("Navio");
            lista.Add("Ônibus");
            lista.Add("Trem");

            cb_trasportes.Items.AddRange(lista.ToArray());
        }

        private void cb_trasportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_transporte.Text = cb_trasportes.Text;
        }

        private void btn_adicionarTransporte_Click(object sender, EventArgs e)
        {
            if (txt_transporte.Text != "")
            {
                if (cb_trasportes.FindString(txt_transporte.Text) < 0)
                {
                    cb_trasportes.Items.Add(txt_transporte.Text);
                }                       
            }
        }
    }
}
