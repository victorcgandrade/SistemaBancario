namespace SistemaBancario.Views
{
    partial class InicialResgate
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
            this.dgv_AplicacoesCliente = new System.Windows.Forms.DataGridView();
            this.lb_Subtitulo_SelecionarAplicacao = new System.Windows.Forms.Label();
            this.lb_TituloResgatarAplicacao = new System.Windows.Forms.Label();
            this.btn_Avancar_Resgate = new System.Windows.Forms.Button();
            this.lb_InformativoResgate = new System.Windows.Forms.Label();
            this.p_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AplicacoesCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.lb_InformativoResgate);
            this.p_Content.Controls.Add(this.btn_Avancar_Resgate);
            this.p_Content.Controls.Add(this.lb_TituloResgatarAplicacao);
            this.p_Content.Controls.Add(this.dgv_AplicacoesCliente);
            this.p_Content.Controls.Add(this.lb_Subtitulo_SelecionarAplicacao);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            // 
            // btn_Investimentos
            // 
            this.btn_Investimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Investimentos.FlatAppearance.BorderSize = 0;
            this.btn_Investimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_AgendamentoSaque
            // 
            this.btn_AgendamentoSaque.FlatAppearance.BorderSize = 0;
            this.btn_AgendamentoSaque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // lb_Conta
            // 
            this.lb_Conta.FlatAppearance.BorderSize = 0;
            this.lb_Conta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Pagamentos
            // 
            this.btn_Pagamentos.FlatAppearance.BorderSize = 0;
            this.btn_Pagamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Extrato
            // 
            this.btn_Extrato.FlatAppearance.BorderSize = 0;
            this.btn_Extrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Atendimento
            // 
            this.btn_Atendimento.FlatAppearance.BorderSize = 0;
            this.btn_Atendimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // dgv_AplicacoesCliente
            // 
            this.dgv_AplicacoesCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AplicacoesCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_AplicacoesCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AplicacoesCliente.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_AplicacoesCliente.Location = new System.Drawing.Point(316, 133);
            this.dgv_AplicacoesCliente.Name = "dgv_AplicacoesCliente";
            this.dgv_AplicacoesCliente.ReadOnly = true;
            this.dgv_AplicacoesCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AplicacoesCliente.Size = new System.Drawing.Size(542, 248);
            this.dgv_AplicacoesCliente.TabIndex = 97;
            // 
            // lb_Subtitulo_SelecionarAplicacao
            // 
            this.lb_Subtitulo_SelecionarAplicacao.AutoSize = true;
            this.lb_Subtitulo_SelecionarAplicacao.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Subtitulo_SelecionarAplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lb_Subtitulo_SelecionarAplicacao.Location = new System.Drawing.Point(455, 100);
            this.lb_Subtitulo_SelecionarAplicacao.Name = "lb_Subtitulo_SelecionarAplicacao";
            this.lb_Subtitulo_SelecionarAplicacao.Size = new System.Drawing.Size(265, 20);
            this.lb_Subtitulo_SelecionarAplicacao.TabIndex = 96;
            this.lb_Subtitulo_SelecionarAplicacao.Text = "Selecione uma aplicação para resgate";
            // 
            // lb_TituloResgatarAplicacao
            // 
            this.lb_TituloResgatarAplicacao.AutoSize = true;
            this.lb_TituloResgatarAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloResgatarAplicacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloResgatarAplicacao.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloResgatarAplicacao.Location = new System.Drawing.Point(30, 30);
            this.lb_TituloResgatarAplicacao.Name = "lb_TituloResgatarAplicacao";
            this.lb_TituloResgatarAplicacao.Size = new System.Drawing.Size(180, 21);
            this.lb_TituloResgatarAplicacao.TabIndex = 99;
            this.lb_TituloResgatarAplicacao.Text = "RESGATAR APLICAÇÃO";
            // 
            // btn_Avancar_Resgate
            // 
            this.btn_Avancar_Resgate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_Avancar_Resgate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Avancar_Resgate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Avancar_Resgate.Location = new System.Drawing.Point(525, 428);
            this.btn_Avancar_Resgate.Name = "btn_Avancar_Resgate";
            this.btn_Avancar_Resgate.Size = new System.Drawing.Size(125, 32);
            this.btn_Avancar_Resgate.TabIndex = 100;
            this.btn_Avancar_Resgate.Text = "Avançar";
            this.btn_Avancar_Resgate.UseVisualStyleBackColor = false;
            this.btn_Avancar_Resgate.Click += new System.EventHandler(this.btn_Avancar_Resgate_Click);
            // 
            // lb_InformativoResgate
            // 
            this.lb_InformativoResgate.AutoSize = true;
            this.lb_InformativoResgate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InformativoResgate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lb_InformativoResgate.Location = new System.Drawing.Point(362, 384);
            this.lb_InformativoResgate.Name = "lb_InformativoResgate";
            this.lb_InformativoResgate.Size = new System.Drawing.Size(451, 15);
            this.lb_InformativoResgate.TabIndex = 101;
            this.lb_InformativoResgate.Text = "Selecione uma linha da tabela acima e clique em Avançar para resgatar a aplicação" +
    ".";
            // 
            // InicialResgate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "InicialResgate";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AplicacoesCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_AplicacoesCliente;
        private System.Windows.Forms.Label lb_Subtitulo_SelecionarAplicacao;
        private System.Windows.Forms.Button btn_Avancar_Resgate;
        private System.Windows.Forms.Label lb_TituloResgatarAplicacao;
        private System.Windows.Forms.Label lb_InformativoResgate;
    }
}
