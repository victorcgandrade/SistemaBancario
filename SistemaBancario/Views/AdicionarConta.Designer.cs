namespace SistemaBancario.Views
{
    partial class AdicionarConta
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
            this.lb_TituloAdicionarConta = new System.Windows.Forms.Label();
            this.lblNumeorConta = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txtBoxCPF = new System.Windows.Forms.TextBox();
            this.txtBoxAgencia = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.btnSalvar);
            this.p_Content.Controls.Add(this.txtBoxAgencia);
            this.p_Content.Controls.Add(this.txtBoxCPF);
            this.p_Content.Controls.Add(this.txtBoxSenha);
            this.p_Content.Controls.Add(this.txtBoxNumero);
            this.p_Content.Controls.Add(this.lblCPF);
            this.p_Content.Controls.Add(this.lblSenha);
            this.p_Content.Controls.Add(this.lblAgencia);
            this.p_Content.Controls.Add(this.lblNumeorConta);
            this.p_Content.Controls.Add(this.lb_TituloAdicionarConta);
            // 
            // lb_TituloAdicionarConta
            // 
            this.lb_TituloAdicionarConta.AutoSize = true;
            this.lb_TituloAdicionarConta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb_TituloAdicionarConta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloAdicionarConta.Location = new System.Drawing.Point(67, 49);
            this.lb_TituloAdicionarConta.Name = "lb_TituloAdicionarConta";
            this.lb_TituloAdicionarConta.Size = new System.Drawing.Size(158, 21);
            this.lb_TituloAdicionarConta.TabIndex = 0;
            this.lb_TituloAdicionarConta.Text = "ADICIONAR CONTA";
            // 
            // lblNumeorConta
            // 
            this.lblNumeorConta.AutoSize = true;
            this.lblNumeorConta.Location = new System.Drawing.Point(273, 97);
            this.lblNumeorConta.Name = "lblNumeorConta";
            this.lblNumeorConta.Size = new System.Drawing.Size(44, 13);
            this.lblNumeorConta.TabIndex = 1;
            this.lblNumeorConta.Text = "Número";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(100, 97);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(46, 13);
            this.lblAgencia.TabIndex = 2;
            this.lblAgencia.Text = "Agencia";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(442, 97);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(592, 97);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(110, 13);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "Cpf Cliente Associado";
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(276, 116);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumero.TabIndex = 9;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(445, 116);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSenha.TabIndex = 10;
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.Location = new System.Drawing.Point(595, 116);
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCPF.TabIndex = 12;
            // 
            // txtBoxAgencia
            // 
            this.txtBoxAgencia.Location = new System.Drawing.Point(103, 116);
            this.txtBoxAgencia.Name = "txtBoxAgencia";
            this.txtBoxAgencia.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAgencia.TabIndex = 13;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(103, 219);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // AdicionarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "AdicionarConta";
            this.Text = "AdicionarConta";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_TituloAdicionarConta;
        private System.Windows.Forms.TextBox txtBoxAgencia;
        private System.Windows.Forms.TextBox txtBoxCPF;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label lblNumeorConta;
        private System.Windows.Forms.Button btnSalvar;
    }
}