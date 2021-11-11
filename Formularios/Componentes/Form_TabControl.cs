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
    public partial class Form_TabControl : Form
    {
        public Form_TabControl()
        {
            InitializeComponent();
        }

        private void Form_TabControl_Load(object sender, EventArgs e)
        {
            DefinirMaximo();
        }

        private void btn_adicionarTab_Click(object sender, EventArgs e)
        {
            if(txt_nomePagina.Text != "")
            {
                TabPage pagina = new TabPage();
                pagina.Text = txt_nomePagina.Text;
                pagina.Name = txt_nomePagina.Text;
                pagina.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(pagina);
                txt_nomePagina.Clear();
                DefinirMaximo();
            }
            else{
                MessageBox.Show("Digite o nome da nova Tab");
                txt_nomePagina.Focus();
            }
        }

        private void btn_removerTab_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            DefinirMaximo();
        }

        private void btn_posicionarTab_Click(object sender, EventArgs e)
        {
            DefinirMaximo();
/*            if (numericUpDown1.Value < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = Int32.Parse(numericUpDown1.Value.ToString());
            }*/
        }

        private void DefinirMaximo()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count;
        }
    }
}
