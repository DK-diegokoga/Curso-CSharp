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

        private void labelLinkeLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_LinkLabel form_LinkLabel = new Form_LinkLabel();
            form_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListBox form_ListBox = new Form_ListBox();
            form_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListView form_ListView = new Form_ListView();
            form_ListView.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MaskedTextBox form_MaskedTextBox = new Form_MaskedTextBox();
            form_MaskedTextBox.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MonthCalendar form_MonthCalendar = new Form_MonthCalendar();
            form_MonthCalendar.ShowDialog();
        }

        private void MenuNotifica_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() == "tsmi_Fechar")
            {
                this.Close();
            }else if (e.ClickedItem.Name.ToString() == "tsmi_Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(e.ClickedItem.Name.ToString() == "tsmi_Mensagem")
            {
                MessageBox.Show("Messagem que tu clicou aqui");
            }

        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NumericUpDown form_NumericUpDown = new Form_NumericUpDown();
            form_NumericUpDown.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PictureBox form_PictureBox = new Form_PictureBox();
            form_PictureBox.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_ProgressBar form_ProgressBar = new Form_ProgressBar();
            form_ProgressBar.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_RadioButton form_RadioButton = new Form_RadioButton();
            form_RadioButton.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form_TrackBar form_TrackBar = new Form_TrackBar();
            form_TrackBar.ShowDialog();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_WebBrowser form_WebBrowser = new Form_WebBrowser();
            form_WebBrowser.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form_SplitContainer form_SplitContainer = new Form_SplitContainer();
            form_SplitContainer.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form_TabControl form_TabControl = new Form_TabControl();
            form_TabControl.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form_TableLayoutPanel form_TableLayoutPanel = new Form_TableLayoutPanel();
            form_TableLayoutPanel.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form_ToolStripContainer form_ToolStripContainer = new Form_ToolStripContainer();
            form_ToolStripContainer.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form_Backgroundworker form_Backgroundworker = new Form_Backgroundworker();
            form_Backgroundworker.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form_Timer form_Timer = new Form_Timer();
            form_Timer.ShowDialog();
        }

        private void sQLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SQLite form_SQLite = new Form_SQLite();
            form_SQLite.ShowDialog();
        }
    }
}
