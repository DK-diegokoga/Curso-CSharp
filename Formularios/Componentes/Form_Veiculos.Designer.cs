
namespace Componentes
{
    partial class Form_Lista_Veiculos
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
            this.txt_listaVeiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_listaVeiculos
            // 
            this.txt_listaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_listaVeiculos.Location = new System.Drawing.Point(12, 12);
            this.txt_listaVeiculos.Multiline = true;
            this.txt_listaVeiculos.Name = "txt_listaVeiculos";
            this.txt_listaVeiculos.Size = new System.Drawing.Size(307, 219);
            this.txt_listaVeiculos.TabIndex = 0;
            // 
            // Form_Lista_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 247);
            this.Controls.Add(this.txt_listaVeiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_Lista_Veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Lista_Veiculos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_listaVeiculos;
    }
}