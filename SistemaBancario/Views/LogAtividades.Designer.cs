namespace SistemaBancario.Views
{
    partial class LogAtividades
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
            this.lb_TituloTela = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.richTextBox1);
            this.p_Content.Controls.Add(this.lb_TituloTela);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            // 
            // btn_LogDados
            // 
            this.btn_LogDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_LogDados.FlatAppearance.BorderSize = 0;
            this.btn_LogDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Agencias
            // 
            this.btn_Agencias.FlatAppearance.BorderSize = 0;
            this.btn_Agencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.FlatAppearance.BorderSize = 0;
            this.btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Contas
            // 
            this.btn_Contas.FlatAppearance.BorderSize = 0;
            this.btn_Contas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Aplicacoes
            // 
            this.btn_Aplicacoes.FlatAppearance.BorderSize = 0;
            this.btn_Aplicacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // lb_TituloTela
            // 
            this.lb_TituloTela.AutoSize = true;
            this.lb_TituloTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloTela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloTela.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloTela.Location = new System.Drawing.Point(118, 84);
            this.lb_TituloTela.Name = "lb_TituloTela";
            this.lb_TituloTela.Size = new System.Drawing.Size(126, 21);
            this.lb_TituloTela.TabIndex = 78;
            this.lb_TituloTela.Text = "LOG DE DADOS";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(122, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(863, 318);
            this.richTextBox1.TabIndex = 79;
            this.richTextBox1.Text = "";
            // 
            // LogAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "LogAtividades";
            this.Text = "TelaInicialAdministradorConta";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lb_TituloTela;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}