﻿using System;
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
    public partial class Form_ToolStripContainer : Form
    {
        public Form_ToolStripContainer()
        {
            InitializeComponent();
        }

        private void Form_ToolStripContainer_Load(object sender, EventArgs e)
        {
            List<ToolStrip> barra = new List<ToolStrip>();
            int num = toolStripContainer1.TopToolStripPanel.Controls.Count;

            for(int i = 0; i < num; i++)
            {
                checkedListBox1.Items.Add(toolStripContainer1.TopToolStripPanel.Controls[i]);
                checkedListBox1.SetItemChecked(i, true);
            }
            
        }
    }
}
