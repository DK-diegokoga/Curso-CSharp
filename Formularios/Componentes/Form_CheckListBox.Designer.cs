
namespace Componentes
{
    partial class Form_CheckListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_limparLista = new System.Windows.Forms.Button();
            this.btn_resetarLista = new System.Windows.Forms.Button();
            this.txt_novoTransporte = new System.Windows.Forms.TextBox();
            this.btn_adicionarTransporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ôbinus ",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(13, 13);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(140, 229);
            this.cb_transportes.TabIndex = 0;
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(159, 13);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(227, 23);
            this.btn_mostrarSelecionados.TabIndex = 1;
            this.btn_mostrarSelecionados.Text = "Mostrar selecionados";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
            // 
            // btn_limparLista
            // 
            this.btn_limparLista.Location = new System.Drawing.Point(159, 42);
            this.btn_limparLista.Name = "btn_limparLista";
            this.btn_limparLista.Size = new System.Drawing.Size(227, 28);
            this.btn_limparLista.TabIndex = 2;
            this.btn_limparLista.Text = "Limpar Lista";
            this.btn_limparLista.UseVisualStyleBackColor = true;
            this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
            // 
            // btn_resetarLista
            // 
            this.btn_resetarLista.Location = new System.Drawing.Point(159, 76);
            this.btn_resetarLista.Name = "btn_resetarLista";
            this.btn_resetarLista.Size = new System.Drawing.Size(227, 23);
            this.btn_resetarLista.TabIndex = 3;
            this.btn_resetarLista.Text = "Resetar Lista";
            this.btn_resetarLista.UseVisualStyleBackColor = true;
            this.btn_resetarLista.Click += new System.EventHandler(this.btn_resetarLista_Click);
            // 
            // txt_novoTransporte
            // 
            this.txt_novoTransporte.Location = new System.Drawing.Point(159, 182);
            this.txt_novoTransporte.Name = "txt_novoTransporte";
            this.txt_novoTransporte.Size = new System.Drawing.Size(173, 20);
            this.txt_novoTransporte.TabIndex = 4;
            // 
            // btn_adicionarTransporte
            // 
            this.btn_adicionarTransporte.Location = new System.Drawing.Point(338, 178);
            this.btn_adicionarTransporte.Name = "btn_adicionarTransporte";
            this.btn_adicionarTransporte.Size = new System.Drawing.Size(100, 27);
            this.btn_adicionarTransporte.TabIndex = 5;
            this.btn_adicionarTransporte.Text = "Adicionar Novo Transporte";
            this.btn_adicionarTransporte.UseVisualStyleBackColor = true;
            this.btn_adicionarTransporte.Click += new System.EventHandler(this.btn_adicionarTransporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte";
            // 
            // Form_CheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_adicionarTransporte);
            this.Controls.Add(this.txt_novoTransporte);
            this.Controls.Add(this.btn_resetarLista);
            this.Controls.Add(this.btn_limparLista);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.Controls.Add(this.cb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_CheckListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CheckListBox";
            this.Load += new System.EventHandler(this.Form_CheckListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cb_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionados;
        private System.Windows.Forms.Button btn_limparLista;
        private System.Windows.Forms.Button btn_resetarLista;
        private System.Windows.Forms.TextBox txt_novoTransporte;
        private System.Windows.Forms.Button btn_adicionarTransporte;
        private System.Windows.Forms.Label label1;
    }
}