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
    public partial class Form_Principal : Form
    {
        public int num;
        public Form_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(txt_veiculo.Text == "s")
            {
                MessageBox.Show("Digite um veículo");
                txt_veiculo.Focus();
                return;
            }

            //txt_listaVeiculos.Text = txt_veiculo.Text;
            txt_listaVeiculos.Text += txt_veiculo.Text;

            txt_veiculo.Clear();
            txt_veiculo.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_listaVeiculos.Clear();
            txt_veiculo.Clear();
            txt_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            Form_Lista_Veiculos form_Lista_Veiculos = new Form_Lista_Veiculos(txt_listaVeiculos.Text,this);
            form_Lista_Veiculos.ShowDialog();
        }

        private void btn_numero_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CheckBox form_CheckBox = new Form_CheckBox();
            form_CheckBox.ShowDialog();
        }

        private void checkedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CheckListBox form_CheckListBox = new Form_CheckListBox();
            form_CheckListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ComboBox form_ComboBox = new Form_ComboBox();
            form_ComboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DateTimePicker form_DateTimePicker = new Form_DateTimePicker();
            form_DateTimePicker.ShowDialog();
        }
    }
}
