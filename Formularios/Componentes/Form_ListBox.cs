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
    public partial class Form_ListBox : Form
    {

        List<string> Lista_de_carros = new List<string>();

        public Form_ListBox()
        {
            InitializeComponent();
            Lista_de_carros.Add("Golf");
            Lista_de_carros.Add("Uno");
            Lista_de_carros.Add("HRV");

            lb_carros.DataSource = (Lista_de_carros);
        }

        private void Form_ListBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(txt_carro.Text == "")
            {
                MessageBox.Show("Digite um carro");
                txt_carro.Focus();
            }
            else
            {
                Lista_de_carros.Add(txt_carro.Text);
                txt_carro.Clear();
                Atualizar(lb_carros, Lista_de_carros);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            Lista_de_carros.RemoveAt(lb_carros.SelectedIndex);
            Atualizar(lb_carros,Lista_de_carros);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            txt_carro.Text = Lista_de_carros[lb_carros.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Lista_de_carros.Clear();
            Atualizar(lb_carros,Lista_de_carros);
        }

        public void Atualizar(ListBox lb_carros,List<string>Lista_de_carros)
        {
            lb_carros.DataSource = null;
            lb_carros.DataSource = Lista_de_carros;
        }
    }
}
