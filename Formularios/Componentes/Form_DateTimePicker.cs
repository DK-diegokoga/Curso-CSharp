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
    public partial class Form_DateTimePicker : Form
    {
        public Form_DateTimePicker()
        {
            InitializeComponent();
        }

        private void Form_DateTimePicker_Load(object sender, EventArgs e)
        {

        }

        private void btn_obterData_Click(object sender, EventArgs e)
        {
            txt_dataCompleta.Text = dtp_data.Text;

            txt_dia.Text = dtp_data.Value.Day.ToString();
            txt_mes.Text = dtp_data.Value.Month.ToString();
            txt_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setarData_Click(object sender, EventArgs e)
        {
            int dia, mes, ano;
            dia = Int32.Parse(txt_dia.Text);
            mes = Int32.Parse(txt_mes.Text);
            ano = Int32.Parse(txt_ano.Text);

            DateTime dt = new DateTime(ano,mes,dia);

            dtp_data.Value = dt;
        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            dtp_data.Value = DateTime.Today;
        }
    }
}
