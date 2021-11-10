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
    public partial class Form_FilhoCheckBox : Form
    {
        public Form_CheckBox form_CheckBox;
        public Form_FilhoCheckBox()
        {
            InitializeComponent();
            try 
            {
                form_CheckBox = Application.OpenForms["Form_CheckBox"] as Form_CheckBox;
                cb_carro.Checked = form_CheckBox.cb_carro.Checked;
                cb_aviao.Checked = form_CheckBox.cb_aviao.Checked;
                cb_navio.Checked = form_CheckBox.cb_navio.Checked;
                cb_onibus.Checked = form_CheckBox.cb_onibus.Checked;
            }
            catch
            {
                throw new Exception("Erro ao abrir formulario!");
            }

        }

        private void Form_FilhoCheckBox_Load(object sender, EventArgs e)
        {

        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.cb_navio.Checked = cb_navio.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}
