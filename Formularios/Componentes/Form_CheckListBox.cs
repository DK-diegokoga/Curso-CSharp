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
    public partial class Form_CheckListBox : Form
    {
        public Form_CheckListBox()
        {
            InitializeComponent();
        }

        private void Form_CheckListBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (string t in cb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }

            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();       
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();


            List<String> lista = new List<string>();
            lista.Add("Carro");
            lista.Add("Avião");
            lista.Add("Navio");
            lista.Add("Ônibus");
            lista.Add("Trem");

            cb_transportes.Items.AddRange(lista.ToArray());
        }

        private void btn_adicionarTransporte_Click(object sender, EventArgs e)
        {
            if (txt_novoTransporte.Text != "")
            {
                cb_transportes.Items.Add(txt_novoTransporte.Text);
                txt_novoTransporte.Clear();
                txt_novoTransporte.Focus();
            }
        }
    }
}
