
namespace Componentes
{
    partial class Form_NumericUpDown
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
            this.n_up_down = new System.Windows.Forms.NumericUpDown();
            this.btn_definir = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.n_up_down)).BeginInit();
            this.SuspendLayout();
            // 
            // n_up_down
            // 
            this.n_up_down.Location = new System.Drawing.Point(12, 12);
            this.n_up_down.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.n_up_down.Name = "n_up_down";
            this.n_up_down.Size = new System.Drawing.Size(120, 20);
            this.n_up_down.TabIndex = 0;
            // 
            // btn_definir
            // 
            this.btn_definir.Location = new System.Drawing.Point(281, 9);
            this.btn_definir.Name = "btn_definir";
            this.btn_definir.Size = new System.Drawing.Size(75, 23);
            this.btn_definir.TabIndex = 1;
            this.btn_definir.Text = "Definir Valor";
            this.btn_definir.UseVisualStyleBackColor = true;
            this.btn_definir.Click += new System.EventHandler(this.btn_definir_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(163, 11);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 2;
            // 
            // Form_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_definir);
            this.Controls.Add(this.n_up_down);
            this.Name = "Form_NumericUpDown";
            this.Text = "Form_NumericUpDown";
            this.Load += new System.EventHandler(this.Form_NumericUpDown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_up_down)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown n_up_down;
        private System.Windows.Forms.Button btn_definir;
        private System.Windows.Forms.TextBox txt_numero;
    }
}