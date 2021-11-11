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
    public partial class Form_MonthCalendar : Form
    {
        public Form_MonthCalendar()
        {
            InitializeComponent();
        }

        private void Form_MonthCalendar_Load(object sender, EventArgs e)
        {

        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox3.Text = monthCalendar1.TodayDate.ToShortDateString();

        }
    }
}
