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
    public partial class Form_ListView : Form
    {
        public Form_ListView()
        {
            InitializeComponent();
        }

        private void Form_ListView_Load(object sender, EventArgs e)
        {

        }


        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            if(txt_id.Text == "")
            {
                MessageBox.Show("Campo de Id não pode estar vazio!");
                txt_id.Focus();
                return;
            }
            if(txt_produto.Text == "")
            {
                MessageBox.Show("Campo de Produto não pode estar vazio!");
                txt_produto.Focus();
                return;
            }
            if (txt_quantidade.Text == "")
            {
                MessageBox.Show("Campo de Quantidade não pode estar vazio!");
                txt_quantidade.Focus();
                return;
            }
            if (txt_preco.Text == "")
            {
                MessageBox.Show("Campo de Preço não pode estar vazio!");
                txt_preco.Focus();
                return;
            }


            string[] produto = new string[4];
            produto[0] = lbl_id.Text;
            produto[1] = txt_produto.Text;
            produto[2] = txt_quantidade.Text;
            produto[3] = txt_preco.Text;

            ListViewItem item = new ListViewItem(produto);

            lv_produtos.Items.Add(item);
            Limpar();
        }


        private void Limpar()
        {
            txt_id.Clear();
            txt_produto.Clear();
            txt_quantidade.Clear();
            txt_preco.Clear();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            Obter();

        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( lv_produtos.SelectedItems.Count > 0) {
                Obter();
            }   
        }

        public void Obter()
        {
            txt_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            txt_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            txt_quantidade.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            txt_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }
    }
}
