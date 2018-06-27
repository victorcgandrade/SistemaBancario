namespace SistemaBancario.Views
{
    partial class AlterarAplicacao
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
            this.cb_TipoAplicacao = new System.Windows.Forms.ComboBox();
            this.lb_TipoAplicacao = new System.Windows.Forms.Label();
            this.lb_InformacaoGeral = new System.Windows.Forms.Label();
            this.lb_TituloAlterarAplicacao = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lb_ValorInicial = new System.Windows.Forms.Label();
            this.tb_ValorInicial = new System.Windows.Forms.TextBox();
            this.lb_Vencimento = new System.Windows.Forms.Label();
            this.dtp_Vencimento = new System.Windows.Forms.DateTimePicker();
            this.lb_TaxaRendimento = new System.Windows.Forms.Label();
            this.tb_TaxaRendimento = new System.Windows.Forms.TextBox();
            this.lb_Status_Aplicacao = new System.Windows.Forms.Label();
            this.cb_Status_Aplicacao = new System.Windows.Forms.ComboBox();
            this.lb_Tributario = new System.Windows.Forms.Label();
            this.lb_ImpostoRenda = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_ValorIOF = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Confirmar_AlterarAplicacao = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.btn_Confirmar_AlterarAplicacao);
            this.p_Content.Controls.Add(this.lb_ImpostoRenda);
            this.p_Content.Controls.Add(this.textBox1);
            this.p_Content.Controls.Add(this.lb_ValorIOF);
            this.p_Content.Controls.Add(this.textBox2);
            this.p_Content.Controls.Add(this.lb_Tributario);
            this.p_Content.Controls.Add(this.cb_Status_Aplicacao);
            this.p_Content.Controls.Add(this.lb_Status_Aplicacao);
            this.p_Content.Controls.Add(this.lb_TaxaRendimento);
            this.p_Content.Controls.Add(this.tb_TaxaRendimento);
            this.p_Content.Controls.Add(this.lb_Vencimento);
            this.p_Content.Controls.Add(this.dtp_Vencimento);
            this.p_Content.Controls.Add(this.lb_ValorInicial);
            this.p_Content.Controls.Add(this.tb_ValorInicial);
            this.p_Content.Controls.Add(this.btn_Limpar);
            this.p_Content.Controls.Add(this.btn_Cancelar);
            this.p_Content.Controls.Add(this.lb_TituloAlterarAplicacao);
            this.p_Content.Controls.Add(this.cb_TipoAplicacao);
            this.p_Content.Controls.Add(this.lb_TipoAplicacao);
            this.p_Content.Controls.Add(this.lb_InformacaoGeral);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
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
            this.btn_Contas.FlatAppearance.BorderSize = 0;
            this.btn_Contas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Aplicacoes
            // 
            this.btn_Aplicacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Aplicacoes.FlatAppearance.BorderSize = 0;
            this.btn_Aplicacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // cb_TipoAplicacao
            // 
            this.cb_TipoAplicacao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb_TipoAplicacao.Enabled = false;
            this.cb_TipoAplicacao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TipoAplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_TipoAplicacao.FormattingEnabled = true;
            this.cb_TipoAplicacao.Items.AddRange(new object[] {
            "Pré-Fixada",
            "Pós-Fixada"});
            this.cb_TipoAplicacao.Location = new System.Drawing.Point(228, 137);
            this.cb_TipoAplicacao.Name = "cb_TipoAplicacao";
            this.cb_TipoAplicacao.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoAplicacao.TabIndex = 92;
            // 
            // lb_TipoAplicacao
            // 
            this.lb_TipoAplicacao.AutoSize = true;
            this.lb_TipoAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TipoAplicacao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TipoAplicacao.Location = new System.Drawing.Point(228, 112);
            this.lb_TipoAplicacao.Name = "lb_TipoAplicacao";
            this.lb_TipoAplicacao.Size = new System.Drawing.Size(114, 17);
            this.lb_TipoAplicacao.TabIndex = 93;
            this.lb_TipoAplicacao.Text = "Tipo de Aplicação";
            // 
            // lb_InformacaoGeral
            // 
            this.lb_InformacaoGeral.AutoSize = true;
            this.lb_InformacaoGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_InformacaoGeral.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InformacaoGeral.Location = new System.Drawing.Point(228, 187);
            this.lb_InformacaoGeral.Name = "lb_InformacaoGeral";
            this.lb_InformacaoGeral.Size = new System.Drawing.Size(124, 17);
            this.lb_InformacaoGeral.TabIndex = 91;
            this.lb_InformacaoGeral.Text = "Informações Gerais";
            // 
            // lb_TituloAlterarAplicacao
            // 
            this.lb_TituloAlterarAplicacao.AutoSize = true;
            this.lb_TituloAlterarAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloAlterarAplicacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloAlterarAplicacao.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloAlterarAplicacao.Location = new System.Drawing.Point(30, 30);
            this.lb_TituloAlterarAplicacao.Name = "lb_TituloAlterarAplicacao";
            this.lb_TituloAlterarAplicacao.Size = new System.Drawing.Size(173, 21);
            this.lb_TituloAlterarAplicacao.TabIndex = 96;
            this.lb_TituloAlterarAplicacao.Text = "ALTERAR  APLICAÇÃO";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(174)))), ((int)(((byte)(170)))));
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Limpar.Location = new System.Drawing.Point(502, 488);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(90, 29);
            this.btn_Limpar.TabIndex = 97;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancelar.Location = new System.Drawing.Point(406, 488);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(90, 29);
            this.btn_Cancelar.TabIndex = 98;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // lb_ValorInicial
            // 
            this.lb_ValorInicial.AutoSize = true;
            this.lb_ValorInicial.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ValorInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_ValorInicial.Location = new System.Drawing.Point(228, 225);
            this.lb_ValorInicial.Name = "lb_ValorInicial";
            this.lb_ValorInicial.Size = new System.Drawing.Size(69, 13);
            this.lb_ValorInicial.TabIndex = 100;
            this.lb_ValorInicial.Text = "Valor inicial:";
            // 
            // tb_ValorInicial
            // 
            this.tb_ValorInicial.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ValorInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ValorInicial.Location = new System.Drawing.Point(228, 242);
            this.tb_ValorInicial.Name = "tb_ValorInicial";
            this.tb_ValorInicial.Size = new System.Drawing.Size(120, 22);
            this.tb_ValorInicial.TabIndex = 99;
            // 
            // lb_Vencimento
            // 
            this.lb_Vencimento.AutoSize = true;
            this.lb_Vencimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_Vencimento.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Vencimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_Vencimento.Location = new System.Drawing.Point(331, 303);
            this.lb_Vencimento.Name = "lb_Vencimento";
            this.lb_Vencimento.Size = new System.Drawing.Size(69, 13);
            this.lb_Vencimento.TabIndex = 102;
            this.lb_Vencimento.Text = "Vencimento:";
            // 
            // dtp_Vencimento
            // 
            this.dtp_Vencimento.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Vencimento.CalendarForeColor = System.Drawing.SystemColors.MenuText;
            this.dtp_Vencimento.CalendarTitleForeColor = System.Drawing.SystemColors.MenuText;
            this.dtp_Vencimento.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtp_Vencimento.Checked = false;
            this.dtp_Vencimento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_Vencimento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Vencimento.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtp_Vencimento.Location = new System.Drawing.Point(406, 298);
            this.dtp_Vencimento.MaxDate = new System.DateTime(2018, 5, 23, 0, 0, 0, 0);
            this.dtp_Vencimento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtp_Vencimento.Name = "dtp_Vencimento";
            this.dtp_Vencimento.Size = new System.Drawing.Size(94, 22);
            this.dtp_Vencimento.TabIndex = 101;
            this.dtp_Vencimento.Value = new System.DateTime(2018, 5, 23, 0, 0, 0, 0);
            // 
            // lb_TaxaRendimento
            // 
            this.lb_TaxaRendimento.AutoSize = true;
            this.lb_TaxaRendimento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaxaRendimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_TaxaRendimento.Location = new System.Drawing.Point(375, 225);
            this.lb_TaxaRendimento.Name = "lb_TaxaRendimento";
            this.lb_TaxaRendimento.Size = new System.Drawing.Size(110, 13);
            this.lb_TaxaRendimento.TabIndex = 104;
            this.lb_TaxaRendimento.Text = "Taxa de rendimento:";
            this.lb_TaxaRendimento.Visible = false;
            // 
            // tb_TaxaRendimento
            // 
            this.tb_TaxaRendimento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TaxaRendimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_TaxaRendimento.Location = new System.Drawing.Point(378, 242);
            this.tb_TaxaRendimento.Name = "tb_TaxaRendimento";
            this.tb_TaxaRendimento.Size = new System.Drawing.Size(122, 22);
            this.tb_TaxaRendimento.TabIndex = 103;
            this.tb_TaxaRendimento.Visible = false;
            // 
            // lb_Status_Aplicacao
            // 
            this.lb_Status_Aplicacao.AutoSize = true;
            this.lb_Status_Aplicacao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status_Aplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_Status_Aplicacao.Location = new System.Drawing.Point(228, 282);
            this.lb_Status_Aplicacao.Name = "lb_Status_Aplicacao";
            this.lb_Status_Aplicacao.Size = new System.Drawing.Size(42, 13);
            this.lb_Status_Aplicacao.TabIndex = 106;
            this.lb_Status_Aplicacao.Text = "Status:";
            // 
            // cb_Status_Aplicacao
            // 
            this.cb_Status_Aplicacao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Status_Aplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_Status_Aplicacao.FormattingEnabled = true;
            this.cb_Status_Aplicacao.Items.AddRange(new object[] {
            "Pré-Fixada",
            "Pós-Fixada"});
            this.cb_Status_Aplicacao.Location = new System.Drawing.Point(228, 298);
            this.cb_Status_Aplicacao.Name = "cb_Status_Aplicacao";
            this.cb_Status_Aplicacao.Size = new System.Drawing.Size(91, 21);
            this.cb_Status_Aplicacao.TabIndex = 107;
            // 
            // lb_Tributario
            // 
            this.lb_Tributario.AutoSize = true;
            this.lb_Tributario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_Tributario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tributario.Location = new System.Drawing.Point(615, 187);
            this.lb_Tributario.Name = "lb_Tributario";
            this.lb_Tributario.Size = new System.Drawing.Size(150, 17);
            this.lb_Tributario.TabIndex = 108;
            this.lb_Tributario.Text = "Informações Tributárias";
            this.lb_Tributario.Visible = false;
            // 
            // lb_ImpostoRenda
            // 
            this.lb_ImpostoRenda.AutoSize = true;
            this.lb_ImpostoRenda.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ImpostoRenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_ImpostoRenda.Location = new System.Drawing.Point(615, 282);
            this.lb_ImpostoRenda.Name = "lb_ImpostoRenda";
            this.lb_ImpostoRenda.Size = new System.Drawing.Size(101, 13);
            this.lb_ImpostoRenda.TabIndex = 112;
            this.lb_ImpostoRenda.Text = "Imposto de renda:";
            this.lb_ImpostoRenda.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(618, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 22);
            this.textBox1.TabIndex = 111;
            this.textBox1.Visible = false;
            // 
            // lb_ValorIOF
            // 
            this.lb_ValorIOF.AutoSize = true;
            this.lb_ValorIOF.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ValorIOF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_ValorIOF.Location = new System.Drawing.Point(615, 225);
            this.lb_ValorIOF.Name = "lb_ValorIOF";
            this.lb_ValorIOF.Size = new System.Drawing.Size(73, 13);
            this.lb_ValorIOF.TabIndex = 110;
            this.lb_ValorIOF.Text = "Valor de IOF:";
            this.lb_ValorIOF.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(618, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 22);
            this.textBox2.TabIndex = 109;
            this.textBox2.Visible = false;
            // 
            // btn_Confirmar_AlterarAplicacao
            // 
            this.btn_Confirmar_AlterarAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(117)))));
            this.btn_Confirmar_AlterarAplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar_AlterarAplicacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar_AlterarAplicacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Confirmar_AlterarAplicacao.Location = new System.Drawing.Point(598, 488);
            this.btn_Confirmar_AlterarAplicacao.Name = "btn_Confirmar_AlterarAplicacao";
            this.btn_Confirmar_AlterarAplicacao.Size = new System.Drawing.Size(90, 29);
            this.btn_Confirmar_AlterarAplicacao.TabIndex = 113;
            this.btn_Confirmar_AlterarAplicacao.Text = "Confirmar";
            this.btn_Confirmar_AlterarAplicacao.UseVisualStyleBackColor = false;
            // 
            // AlterarAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "AlterarAplicacao";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.ComboBox cb_TipoAplicacao;
        protected System.Windows.Forms.Label lb_TipoAplicacao;
        protected System.Windows.Forms.Label lb_InformacaoGeral;
        private System.Windows.Forms.Label lb_TituloAlterarAplicacao;
        protected System.Windows.Forms.Button btn_Limpar;
        protected System.Windows.Forms.Button btn_Cancelar;
        protected System.Windows.Forms.Label lb_ValorInicial;
        protected System.Windows.Forms.TextBox tb_ValorInicial;
        protected System.Windows.Forms.Label lb_TaxaRendimento;
        protected System.Windows.Forms.TextBox tb_TaxaRendimento;
        protected System.Windows.Forms.Label lb_Vencimento;
        protected System.Windows.Forms.DateTimePicker dtp_Vencimento;
        protected System.Windows.Forms.ComboBox cb_Status_Aplicacao;
        protected System.Windows.Forms.Label lb_Status_Aplicacao;
        protected System.Windows.Forms.Label lb_ImpostoRenda;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Label lb_ValorIOF;
        protected System.Windows.Forms.TextBox textBox2;
        protected System.Windows.Forms.Label lb_Tributario;
        protected System.Windows.Forms.Button btn_Confirmar_AlterarAplicacao;
    }
}
