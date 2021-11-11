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
    public partial class Form_MaskedTextBox : Form
    {
        public Form_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void Form_MaskedTextBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                masked_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                masked_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;

            }
            String msg = masked_cpf.Text;
            MessageBox.Show(msg);
        }
    }
}
