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
    public partial class Form_LinkLabel : Form
    {
        public Form_LinkLabel()
        {
            InitializeComponent();
            ll_diversos.Links.Add(0,6,"www.google.com.br");
            ll_diversos.Links.Add(9, 6, "www.github.com");
            ll_diversos.Links.Add(18, 7, "www.youtube.com");

            ll_diversos.Links[2].Enabled = false;
        }

        private void Form_LinkLabel_Load(object sender, EventArgs e)
        {

        }

        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DK-diegokoga/Curso-CSharp");
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

        }

        private void ll_diversos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
