
namespace Componentes
{
    partial class Form_DateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_obterData = new System.Windows.Forms.Button();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.txt_dataCompleta = new System.Windows.Forms.TextBox();
            this.btn_setarData = new System.Windows.Forms.Button();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(13, 13);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(337, 20);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_obterData
            // 
            this.btn_obterData.Location = new System.Drawing.Point(356, 10);
            this.btn_obterData.Name = "btn_obterData";
            this.btn_obterData.Size = new System.Drawing.Size(173, 23);
            this.btn_obterData.TabIndex = 1;
            this.btn_obterData.Text = "Obter Data";
            this.btn_obterData.UseVisualStyleBackColor = true;
            this.btn_obterData.Click += new System.EventHandler(this.btn_obterData_Click);
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(13, 92);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(100, 20);
            this.txt_dia.TabIndex = 4;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(250, 92);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 20);
            this.txt_ano.TabIndex = 6;
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(131, 92);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(100, 20);
            this.txt_mes.TabIndex = 7;
            // 
            // txt_dataCompleta
            // 
            this.txt_dataCompleta.Location = new System.Drawing.Point(12, 39);
            this.txt_dataCompleta.Name = "txt_dataCompleta";
            this.txt_dataCompleta.Size = new System.Drawing.Size(338, 20);
            this.txt_dataCompleta.TabIndex = 8;
            // 
            // btn_setarData
            // 
            this.btn_setarData.Location = new System.Drawing.Point(356, 89);
            this.btn_setarData.Name = "btn_setarData";
            this.btn_setarData.Size = new System.Drawing.Size(173, 23);
            this.btn_setarData.TabIndex = 9;
            this.btn_setarData.Text = "Setar Data";
            this.btn_setarData.UseVisualStyleBackColor = true;
            this.btn_setarData.Click += new System.EventHandler(this.btn_setarData_Click);
            // 
            // btn_hoje
            // 
            this.btn_hoje.Location = new System.Drawing.Point(356, 121);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(173, 23);
            this.btn_hoje.TabIndex = 10;
            this.btn_hoje.Text = "Data Hoje";
            this.btn_hoje.UseVisualStyleBackColor = true;
            this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Location = new System.Drawing.Point(12, 76);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(23, 13);
            this.lbl_dia.TabIndex = 11;
            this.lbl_dia.Text = "Dia";
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Location = new System.Drawing.Point(128, 76);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(27, 13);
            this.lbl_mes.TabIndex = 12;
            this.lbl_mes.Text = "Mês";
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(247, 76);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(26, 13);
            this.lbl_ano.TabIndex = 13;
            this.lbl_ano.Text = "Ano";
            // 
            // Form_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 156);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.lbl_dia);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.btn_setarData);
            this.Controls.Add(this.txt_dataCompleta);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_dia);
            this.Controls.Add(this.btn_obterData);
            this.Controls.Add(this.dtp_data);
            this.Name = "Form_DateTimePicker";
            this.Text = "Form_DateTimePicker";
            this.Load += new System.EventHandler(this.Form_DateTimePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btn_obterData;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.TextBox txt_dataCompleta;
        private System.Windows.Forms.Button btn_setarData;
        private System.Windows.Forms.Button btn_hoje;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.Label lbl_ano;
    }
}