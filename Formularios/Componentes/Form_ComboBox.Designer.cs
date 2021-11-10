
namespace Componentes
{
    partial class Form_ComboBox
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
            this.cb_trasportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_limparElementos = new System.Windows.Forms.Button();
            this.btn_resetarElementos = new System.Windows.Forms.Button();
            this.btn_adicionarTransporte = new System.Windows.Forms.Button();
            this.txt_transporte = new System.Windows.Forms.TextBox();
            this.lbl_transporte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_trasportes
            // 
            this.cb_trasportes.FormattingEnabled = true;
            this.cb_trasportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_trasportes.Location = new System.Drawing.Point(29, 41);
            this.cb_trasportes.Name = "cb_trasportes";
            this.cb_trasportes.Size = new System.Drawing.Size(175, 21);
            this.cb_trasportes.TabIndex = 0;
            this.cb_trasportes.SelectedIndexChanged += new System.EventHandler(this.cb_trasportes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionado
            // 
            this.btn_mostrarSelecionado.Location = new System.Drawing.Point(210, 39);
            this.btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
            this.btn_mostrarSelecionado.Size = new System.Drawing.Size(153, 23);
            this.btn_mostrarSelecionado.TabIndex = 1;
            this.btn_mostrarSelecionado.Text = "Mostrar selecionados";
            this.btn_mostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionado.Click += new System.EventHandler(this.btn_mostrarSelecionado_Click);
            // 
            // btn_limparElementos
            // 
            this.btn_limparElementos.Location = new System.Drawing.Point(210, 68);
            this.btn_limparElementos.Name = "btn_limparElementos";
            this.btn_limparElementos.Size = new System.Drawing.Size(153, 23);
            this.btn_limparElementos.TabIndex = 2;
            this.btn_limparElementos.Text = "Limpar elementos";
            this.btn_limparElementos.UseVisualStyleBackColor = true;
            this.btn_limparElementos.Click += new System.EventHandler(this.btn_limparElementos_Click);
            // 
            // btn_resetarElementos
            // 
            this.btn_resetarElementos.Location = new System.Drawing.Point(210, 97);
            this.btn_resetarElementos.Name = "btn_resetarElementos";
            this.btn_resetarElementos.Size = new System.Drawing.Size(153, 23);
            this.btn_resetarElementos.TabIndex = 3;
            this.btn_resetarElementos.Text = "Resetar elementos";
            this.btn_resetarElementos.UseVisualStyleBackColor = true;
            this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
            // 
            // btn_adicionarTransporte
            // 
            this.btn_adicionarTransporte.Location = new System.Drawing.Point(210, 163);
            this.btn_adicionarTransporte.Name = "btn_adicionarTransporte";
            this.btn_adicionarTransporte.Size = new System.Drawing.Size(153, 23);
            this.btn_adicionarTransporte.TabIndex = 4;
            this.btn_adicionarTransporte.Text = "Adicionar novo transporte";
            this.btn_adicionarTransporte.UseVisualStyleBackColor = true;
            this.btn_adicionarTransporte.Click += new System.EventHandler(this.btn_adicionarTransporte_Click);
            // 
            // txt_transporte
            // 
            this.txt_transporte.Location = new System.Drawing.Point(29, 163);
            this.txt_transporte.Name = "txt_transporte";
            this.txt_transporte.Size = new System.Drawing.Size(175, 20);
            this.txt_transporte.TabIndex = 5;
            // 
            // lbl_transporte
            // 
            this.lbl_transporte.AutoSize = true;
            this.lbl_transporte.Location = new System.Drawing.Point(26, 147);
            this.lbl_transporte.Name = "lbl_transporte";
            this.lbl_transporte.Size = new System.Drawing.Size(128, 13);
            this.lbl_transporte.TabIndex = 6;
            this.lbl_transporte.Text = "Digite um novo transporte";
            // 
            // Form_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 218);
            this.Controls.Add(this.lbl_transporte);
            this.Controls.Add(this.txt_transporte);
            this.Controls.Add(this.btn_adicionarTransporte);
            this.Controls.Add(this.btn_resetarElementos);
            this.Controls.Add(this.btn_limparElementos);
            this.Controls.Add(this.btn_mostrarSelecionado);
            this.Controls.Add(this.cb_trasportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_trasportes;
        private System.Windows.Forms.Button btn_mostrarSelecionado;
        private System.Windows.Forms.Button btn_limparElementos;
        private System.Windows.Forms.Button btn_resetarElementos;
        private System.Windows.Forms.Button btn_adicionarTransporte;
        private System.Windows.Forms.TextBox txt_transporte;
        private System.Windows.Forms.Label lbl_transporte;
    }
}