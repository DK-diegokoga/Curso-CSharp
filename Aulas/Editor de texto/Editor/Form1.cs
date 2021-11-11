using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Metodos
        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName,FileMode.OpenOrCreate,FileAccess.Write);
                    StreamWriter texto_streamWriter = new StreamWriter(arquivo);
                    texto_streamWriter.Flush();
                    texto_streamWriter.BaseStream.Seek(0,SeekOrigin.Begin);
                    texto_streamWriter.Write(this.richTextBox1.Text);
                    texto_streamWriter.Flush();
                    texto_streamWriter.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro na gravação! " + e.Message,"Erro ao gravar" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Abrir()
        {
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\LENOVO-EQP379\Desktop\Aulas\C#\Aulas de C#\Aulas\Editor de texto\Arquivos salvados";
            openFileDialog1.Filter = "(*.TXT)|*.TXT" + "Todos Arquivos(*.*)|*.*";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader texto_streamReader = new StreamReader(arquivo);
                    texto_streamReader.BaseStream.Seek(0,SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = texto_streamReader.ReadLine();
                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = texto_streamReader.ReadLine();
                    }
                    texto_streamReader.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show("Erro na Leitura! " + e.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void Colar()
        {
            richTextBox1.Paste();
        }

        private void Negrito()
        {
            string nomeFonte = "";
            float tamanho = 0;
            bool negrito,italico,sublinhado = false;

            nomeFonte = richTextBox1.Font.Name;
            tamanho = richTextBox1.Font.Size;
            negrito = richTextBox1.SelectionFont.Bold;
            italico = richTextBox1.SelectionFont.Italic;
            sublinhado = richTextBox1.SelectionFont.Underline;


            if (negrito == false)
            {
                if (italico == true & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold | FontStyle.Italic| FontStyle.Underline);
                }
                else if (italico == false & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold | FontStyle.Underline);

                }
                else if (italico == true & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold | FontStyle.Italic );

                }
                else if (italico == false & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold);
                }
            }
            else
            {
                if (italico == true & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Italic | FontStyle.Underline);
                }
                else if (italico == false & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Underline);

                }
                else if (italico == true & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Italic);

                }
            }
        }

        private void Italico()
        {
            string nomeFonte = "";
            float tamanho = 0;
            bool negrito, italico, sublinhado = false;

            nomeFonte = richTextBox1.Font.Name;
            tamanho = richTextBox1.Font.Size;
            negrito = richTextBox1.SelectionFont.Bold;
            italico = richTextBox1.SelectionFont.Italic;
            sublinhado = richTextBox1.SelectionFont.Underline;


            if (italico == false)
            {
                if (negrito == true & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (negrito == false & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Italic | FontStyle.Underline);

                }
                else if (negrito == true & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold | FontStyle.Italic);

                }
                else if (negrito == false & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Italic);
                }
            }
            else
            {
                if (negrito == true & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold | FontStyle.Underline);
                }
                else if (negrito == false & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Underline);

                }
                else if (negrito == true & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold);

                }
            }
        }

        private void Sublinhado()
        {
            string nomeFonte = "";
            float tamanho = 0;
            bool negrito, italico, sublinhado = false;

            nomeFonte = richTextBox1.Font.Name;
            tamanho = richTextBox1.Font.Size;
            negrito = richTextBox1.SelectionFont.Bold;
            italico = richTextBox1.SelectionFont.Italic;
            sublinhado = richTextBox1.SelectionFont.Underline;


            if (sublinhado == false)
            {
                if (negrito == true & italico == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (negrito == false & italico == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Italic | FontStyle.Underline);

                }
                else if (negrito == true & italico == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold | FontStyle.Underline);

                }
                else if (negrito == false & italico == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Underline);
                }
            }
            else
            {
                if (negrito == true & italico == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold | FontStyle.Italic);
                }
                else if (negrito == false & italico == true)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Italic);

                }
                else if (negrito == true & italico == false)
                {
                    richTextBox1.SelectionFont = new Font(nomeFonte, tamanho, FontStyle.Bold);

                }
            }
        }

        private void AlinhaEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlinhaDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void AlinhaCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        //Chamando os metodos nos botões
        private void menu_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void menu_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void menu_abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void menu_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void menu_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void menu_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void menu_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void menu_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhaCentro();
        }

        private void menu_alinhado_Click(object sender, EventArgs e)
        {
            AlinhaCentro();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhaEsquerda();
        }

        private void menu_esquerda_Click(object sender, EventArgs e)
        {
            AlinhaEsquerda();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhaDireita();
        }

        private void menu_direita_Click(object sender, EventArgs e)
        {
            AlinhaDireita();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPag = 0;
            float posY = 0;
            int cont = 0;
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;

            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }
            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }

            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPag = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            while(cont  < linhasPag)
            {
                posY = (margemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha,fonte,pincel,margemEsquerda,posY,new StringFormat());
                cont++;
                linha = leitura.ReadLine();
            }
            if(linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }
    }
}
