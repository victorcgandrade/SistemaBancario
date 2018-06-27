namespace SistemaBancario.Views
{
    partial class AlterarConta
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
            this.lb_InformativoCliente = new System.Windows.Forms.Label();
            this.lb_Asterisco = new System.Windows.Forms.Label();
            this.tb_NumeroAgencia = new System.Windows.Forms.TextBox();
            this.tb_TipoConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CpfCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_TipoConta = new System.Windows.Forms.Label();
            this.lb_Senha = new System.Windows.Forms.Label();
            this.lb_NumeroConta = new System.Windows.Forms.Label();
            this.lb_Agencia = new System.Windows.Forms.Label();
            this.lb_InformacaoConta = new System.Windows.Forms.Label();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.tb_NumeroConta = new System.Windows.Forms.TextBox();
            this.lb_TituloAlterarConta = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.lb_Status = new System.Windows.Forms.Label();
            this.btn_Confirmar_AlterarConta = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.btn_Confirmar_AlterarConta);
            this.p_Content.Controls.Add(this.btn_Limpar);
            this.p_Content.Controls.Add(this.btn_Cancelar);
            this.p_Content.Controls.Add(this.cb_Status);
            this.p_Content.Controls.Add(this.lb_Status);
            this.p_Content.Controls.Add(this.lb_InformativoCliente);
            this.p_Content.Controls.Add(this.lb_Asterisco);
            this.p_Content.Controls.Add(this.tb_NumeroAgencia);
            this.p_Content.Controls.Add(this.tb_TipoConta);
            this.p_Content.Controls.Add(this.label2);
            this.p_Content.Controls.Add(this.tb_CpfCliente);
            this.p_Content.Controls.Add(this.label1);
            this.p_Content.Controls.Add(this.lb_TipoConta);
            this.p_Content.Controls.Add(this.lb_Senha);
            this.p_Content.Controls.Add(this.lb_NumeroConta);
            this.p_Content.Controls.Add(this.lb_Agencia);
            this.p_Content.Controls.Add(this.lb_InformacaoConta);
            this.p_Content.Controls.Add(this.tb_Senha);
            this.p_Content.Controls.Add(this.tb_NumeroConta);
            this.p_Content.Controls.Add(this.lb_TituloAlterarConta);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            // 
            // btn_LogDados
            // 
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
            this.btn_Contas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Contas.FlatAppearance.BorderSize = 0;
            this.btn_Contas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Aplicacoes
            // 
            this.btn_Aplicacoes.FlatAppearance.BorderSize = 0;
            this.btn_Aplicacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // lb_InformativoCliente
            // 
            this.lb_InformativoCliente.AutoSize = true;
            this.lb_InformativoCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InformativoCliente.ForeColor = System.Drawing.Color.Red;
            this.lb_InformativoCliente.Location = new System.Drawing.Point(570, 257);
            this.lb_InformativoCliente.Name = "lb_InformativoCliente";
            this.lb_InformativoCliente.Size = new System.Drawing.Size(317, 15);
            this.lb_InformativoCliente.TabIndex = 119;
            this.lb_InformativoCliente.Text = "* Apenas Clientes Titulares Pessoa Física ou Pessoa Jurídica";
            // 
            // lb_Asterisco
            // 
            this.lb_Asterisco.AutoSize = true;
            this.lb_Asterisco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Asterisco.ForeColor = System.Drawing.Color.Red;
            this.lb_Asterisco.Location = new System.Drawing.Point(693, 218);
            this.lb_Asterisco.Name = "lb_Asterisco";
            this.lb_Asterisco.Size = new System.Drawing.Size(12, 15);
            this.lb_Asterisco.TabIndex = 118;
            this.lb_Asterisco.Text = "*";
            // 
            // tb_NumeroAgencia
            // 
            this.tb_NumeroAgencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_NumeroAgencia.Location = new System.Drawing.Point(239, 234);
            this.tb_NumeroAgencia.Name = "tb_NumeroAgencia";
            this.tb_NumeroAgencia.Size = new System.Drawing.Size(121, 20);
            this.tb_NumeroAgencia.TabIndex = 117;
            // 
            // tb_TipoConta
            // 
            this.tb_TipoConta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_TipoConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_TipoConta.Location = new System.Drawing.Point(239, 121);
            this.tb_TipoConta.Name = "tb_TipoConta";
            this.tb_TipoConta.Size = new System.Drawing.Size(121, 20);
            this.tb_TipoConta.TabIndex = 116;
            this.tb_TipoConta.Text = "Conta Corrente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(570, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "CPF (Apenas números):";
            // 
            // tb_CpfCliente
            // 
            this.tb_CpfCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_CpfCliente.Enabled = false;
            this.tb_CpfCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_CpfCliente.Location = new System.Drawing.Point(573, 234);
            this.tb_CpfCliente.Name = "tb_CpfCliente";
            this.tb_CpfCliente.Size = new System.Drawing.Size(146, 20);
            this.tb_CpfCliente.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 113;
            this.label1.Text = "Informações do cliente responsável";
            // 
            // lb_TipoConta
            // 
            this.lb_TipoConta.AutoSize = true;
            this.lb_TipoConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TipoConta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TipoConta.Location = new System.Drawing.Point(236, 92);
            this.lb_TipoConta.Name = "lb_TipoConta";
            this.lb_TipoConta.Size = new System.Drawing.Size(91, 17);
            this.lb_TipoConta.TabIndex = 112;
            this.lb_TipoConta.Text = "Tipo de conta";
            // 
            // lb_Senha
            // 
            this.lb_Senha.AutoSize = true;
            this.lb_Senha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_Senha.Location = new System.Drawing.Point(365, 277);
            this.lb_Senha.Name = "lb_Senha";
            this.lb_Senha.Size = new System.Drawing.Size(106, 13);
            this.lb_Senha.TabIndex = 111;
            this.lb_Senha.Text = "Senha de 4 dígitos:";
            // 
            // lb_NumeroConta
            // 
            this.lb_NumeroConta.AutoSize = true;
            this.lb_NumeroConta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumeroConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_NumeroConta.Location = new System.Drawing.Point(236, 277);
            this.lb_NumeroConta.Name = "lb_NumeroConta";
            this.lb_NumeroConta.Size = new System.Drawing.Size(99, 13);
            this.lb_NumeroConta.TabIndex = 110;
            this.lb_NumeroConta.Text = "Número da conta:";
            // 
            // lb_Agencia
            // 
            this.lb_Agencia.AutoSize = true;
            this.lb_Agencia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Agencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_Agencia.Location = new System.Drawing.Point(236, 218);
            this.lb_Agencia.Name = "lb_Agencia";
            this.lb_Agencia.Size = new System.Drawing.Size(110, 13);
            this.lb_Agencia.TabIndex = 109;
            this.lb_Agencia.Text = "Número da agência:";
            // 
            // lb_InformacaoConta
            // 
            this.lb_InformacaoConta.AutoSize = true;
            this.lb_InformacaoConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_InformacaoConta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InformacaoConta.Location = new System.Drawing.Point(236, 188);
            this.lb_InformacaoConta.Name = "lb_InformacaoConta";
            this.lb_InformacaoConta.Size = new System.Drawing.Size(140, 17);
            this.lb_InformacaoConta.TabIndex = 108;
            this.lb_InformacaoConta.Text = "Informações da conta";
            // 
            // tb_Senha
            // 
            this.tb_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Senha.Location = new System.Drawing.Point(368, 293);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(121, 20);
            this.tb_Senha.TabIndex = 107;
            this.tb_Senha.UseSystemPasswordChar = true;
            // 
            // tb_NumeroConta
            // 
            this.tb_NumeroConta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_NumeroConta.Enabled = false;
            this.tb_NumeroConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_NumeroConta.Location = new System.Drawing.Point(239, 293);
            this.tb_NumeroConta.Name = "tb_NumeroConta";
            this.tb_NumeroConta.Size = new System.Drawing.Size(122, 20);
            this.tb_NumeroConta.TabIndex = 106;
            // 
            // lb_TituloAlterarConta
            // 
            this.lb_TituloAlterarConta.AutoSize = true;
            this.lb_TituloAlterarConta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb_TituloAlterarConta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloAlterarConta.Location = new System.Drawing.Point(30, 30);
            this.lb_TituloAlterarConta.Name = "lb_TituloAlterarConta";
            this.lb_TituloAlterarConta.Size = new System.Drawing.Size(135, 21);
            this.lb_TituloAlterarConta.TabIndex = 105;
            this.lb_TituloAlterarConta.Text = "ALTERAR CONTA";
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Criada",
            "Ativada",
            "Inativada",
            "Com pendências"});
            this.cb_Status.Location = new System.Drawing.Point(239, 349);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(121, 21);
            this.cb_Status.TabIndex = 122;
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_Status.Location = new System.Drawing.Point(237, 333);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(42, 13);
            this.lb_Status.TabIndex = 121;
            this.lb_Status.Text = "Status:";
            // 
            // btn_Confirmar_AlterarConta
            // 
            this.btn_Confirmar_AlterarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(117)))));
            this.btn_Confirmar_AlterarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar_AlterarConta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar_AlterarConta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Confirmar_AlterarConta.Location = new System.Drawing.Point(596, 485);
            this.btn_Confirmar_AlterarConta.Name = "btn_Confirmar_AlterarConta";
            this.btn_Confirmar_AlterarConta.Size = new System.Drawing.Size(90, 29);
            this.btn_Confirmar_AlterarConta.TabIndex = 125;
            this.btn_Confirmar_AlterarConta.Text = "Confirmar";
            this.btn_Confirmar_AlterarConta.UseVisualStyleBackColor = false;
            this.btn_Confirmar_AlterarConta.Click += new System.EventHandler(this.btn_Confirmar_AlterarConta_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(174)))), ((int)(((byte)(170)))));
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Limpar.Location = new System.Drawing.Point(500, 485);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(90, 29);
            this.btn_Limpar.TabIndex = 123;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancelar.Location = new System.Drawing.Point(404, 485);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(90, 29);
            this.btn_Cancelar.TabIndex = 124;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // AlterarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "AlterarConta";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Status;
        protected System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_InformativoCliente;
        private System.Windows.Forms.Label lb_Asterisco;
        private System.Windows.Forms.TextBox tb_NumeroAgencia;
        private System.Windows.Forms.TextBox tb_TipoConta;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CpfCliente;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label lb_TipoConta;
        protected System.Windows.Forms.Label lb_Senha;
        protected System.Windows.Forms.Label lb_NumeroConta;
        protected System.Windows.Forms.Label lb_Agencia;
        protected System.Windows.Forms.Label lb_InformacaoConta;
        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.TextBox tb_NumeroConta;
        private System.Windows.Forms.Label lb_TituloAlterarConta;
        protected System.Windows.Forms.Button btn_Confirmar_AlterarConta;
        protected System.Windows.Forms.Button btn_Limpar;
        protected System.Windows.Forms.Button btn_Cancelar;
    }
}
