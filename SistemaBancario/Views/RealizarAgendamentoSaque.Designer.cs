namespace SistemaBancario.Views
{
    partial class RealizarAgendamentoSaque
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
            this.lb_TituloSaque = new System.Windows.Forms.Label();
            this.lb_TextoExplicativoListarCliente = new System.Windows.Forms.Label();
            this.lb_SubtituloListarCliente = new System.Windows.Forms.Label();
            this.lb_ValorInicial = new System.Windows.Forms.Label();
            this.tb_Valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_DataAgendamento = new System.Windows.Forms.DateTimePicker();
            this.tb_Beneficiario = new System.Windows.Forms.TextBox();
            this.btn_Confirmar_AgendarSaque = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_CriarEvento = new System.Windows.Forms.CheckBox();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.cb_CriarEvento);
            this.p_Content.Controls.Add(this.label4);
            this.p_Content.Controls.Add(this.btn_Confirmar_AgendarSaque);
            this.p_Content.Controls.Add(this.btn_Limpar);
            this.p_Content.Controls.Add(this.btn_Cancelar);
            this.p_Content.Controls.Add(this.tb_Beneficiario);
            this.p_Content.Controls.Add(this.dtp_DataAgendamento);
            this.p_Content.Controls.Add(this.label3);
            this.p_Content.Controls.Add(this.label2);
            this.p_Content.Controls.Add(this.lb_ValorInicial);
            this.p_Content.Controls.Add(this.tb_Valor);
            this.p_Content.Controls.Add(this.lb_TextoExplicativoListarCliente);
            this.p_Content.Controls.Add(this.lb_SubtituloListarCliente);
            this.p_Content.Controls.Add(this.lb_TituloSaque);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            // 
            // btn_Investimentos
            // 
            this.btn_Investimentos.FlatAppearance.BorderSize = 0;
            this.btn_Investimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_AgendamentoSaque
            // 
            this.btn_AgendamentoSaque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
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
            // lb_TituloSaque
            // 
            this.lb_TituloSaque.AutoSize = true;
            this.lb_TituloSaque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloSaque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloSaque.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloSaque.Location = new System.Drawing.Point(30, 30);
            this.lb_TituloSaque.Name = "lb_TituloSaque";
            this.lb_TituloSaque.Size = new System.Drawing.Size(294, 21);
            this.lb_TituloSaque.TabIndex = 87;
            this.lb_TituloSaque.Text = "REALIZAR AGENDAMENTO DE SAQUE";
            // 
            // lb_TextoExplicativoListarCliente
            // 
            this.lb_TextoExplicativoListarCliente.AutoSize = true;
            this.lb_TextoExplicativoListarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TextoExplicativoListarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lb_TextoExplicativoListarCliente.Location = new System.Drawing.Point(310, 126);
            this.lb_TextoExplicativoListarCliente.Name = "lb_TextoExplicativoListarCliente";
            this.lb_TextoExplicativoListarCliente.Size = new System.Drawing.Size(518, 15);
            this.lb_TextoExplicativoListarCliente.TabIndex = 92;
            this.lb_TextoExplicativoListarCliente.Text = "Ao completar os dados abaixo, será feito o saque do valor previsto na agência e d" +
    "ata informadas. ";
            // 
            // lb_SubtituloListarCliente
            // 
            this.lb_SubtituloListarCliente.AutoSize = true;
            this.lb_SubtituloListarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SubtituloListarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lb_SubtituloListarCliente.Location = new System.Drawing.Point(501, 94);
            this.lb_SubtituloListarCliente.Name = "lb_SubtituloListarCliente";
            this.lb_SubtituloListarCliente.Size = new System.Drawing.Size(137, 20);
            this.lb_SubtituloListarCliente.TabIndex = 91;
            this.lb_SubtituloListarCliente.Text = "Retirada de Saque ";
            // 
            // lb_ValorInicial
            // 
            this.lb_ValorInicial.AutoSize = true;
            this.lb_ValorInicial.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ValorInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_ValorInicial.Location = new System.Drawing.Point(366, 207);
            this.lb_ValorInicial.Name = "lb_ValorInicial";
            this.lb_ValorInicial.Size = new System.Drawing.Size(87, 13);
            this.lb_ValorInicial.TabIndex = 102;
            this.lb_ValorInicial.Text = "Valor do saque:";
            // 
            // tb_Valor
            // 
            this.tb_Valor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Valor.Location = new System.Drawing.Point(366, 224);
            this.tb_Valor.Name = "tb_Valor";
            this.tb_Valor.Size = new System.Drawing.Size(120, 22);
            this.tb_Valor.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(613, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "Data prevista para o saque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(363, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "CPF/CNPJ Beneficiário:";
            // 
            // dtp_DataAgendamento
            // 
            this.dtp_DataAgendamento.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DataAgendamento.CalendarForeColor = System.Drawing.SystemColors.MenuText;
            this.dtp_DataAgendamento.CalendarTitleForeColor = System.Drawing.SystemColors.MenuText;
            this.dtp_DataAgendamento.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtp_DataAgendamento.Checked = false;
            this.dtp_DataAgendamento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_DataAgendamento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DataAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataAgendamento.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtp_DataAgendamento.Location = new System.Drawing.Point(616, 224);
            this.dtp_DataAgendamento.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dtp_DataAgendamento.MinDate = new System.DateTime(2018, 7, 8, 0, 0, 0, 0);
            this.dtp_DataAgendamento.Name = "dtp_DataAgendamento";
            this.dtp_DataAgendamento.Size = new System.Drawing.Size(144, 22);
            this.dtp_DataAgendamento.TabIndex = 109;
            this.dtp_DataAgendamento.Value = new System.DateTime(2018, 7, 8, 0, 0, 0, 0);
            // 
            // tb_Beneficiario
            // 
            this.tb_Beneficiario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Beneficiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Beneficiario.Location = new System.Drawing.Point(366, 287);
            this.tb_Beneficiario.Name = "tb_Beneficiario";
            this.tb_Beneficiario.Size = new System.Drawing.Size(120, 22);
            this.tb_Beneficiario.TabIndex = 112;
            // 
            // btn_Confirmar_AgendarSaque
            // 
            this.btn_Confirmar_AgendarSaque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(117)))));
            this.btn_Confirmar_AgendarSaque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar_AgendarSaque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar_AgendarSaque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Confirmar_AgendarSaque.Location = new System.Drawing.Point(616, 455);
            this.btn_Confirmar_AgendarSaque.Name = "btn_Confirmar_AgendarSaque";
            this.btn_Confirmar_AgendarSaque.Size = new System.Drawing.Size(90, 29);
            this.btn_Confirmar_AgendarSaque.TabIndex = 116;
            this.btn_Confirmar_AgendarSaque.Text = "Confirmar";
            this.btn_Confirmar_AgendarSaque.UseVisualStyleBackColor = false;
            this.btn_Confirmar_AgendarSaque.Click += new System.EventHandler(this.btn_Confirmar_AgendarSaque_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(174)))), ((int)(((byte)(170)))));
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Limpar.Location = new System.Drawing.Point(520, 455);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(90, 29);
            this.btn_Limpar.TabIndex = 114;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancelar.Location = new System.Drawing.Point(424, 455);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(90, 29);
            this.btn_Cancelar.TabIndex = 115;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(326, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(486, 15);
            this.label4.TabIndex = 117;
            this.label4.Text = "Direcionar-se a um atendente munido de documentação de identificação e cartão da " +
    "conta.";
            // 
            // cb_CriarEvento
            // 
            this.cb_CriarEvento.AutoSize = true;
            this.cb_CriarEvento.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cb_CriarEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_CriarEvento.Location = new System.Drawing.Point(366, 338);
            this.cb_CriarEvento.Name = "cb_CriarEvento";
            this.cb_CriarEvento.Size = new System.Drawing.Size(348, 17);
            this.cb_CriarEvento.TabIndex = 118;
            this.cb_CriarEvento.Text = "Criar um evento no Google Calendar sobre este agendamento.";
            this.cb_CriarEvento.UseVisualStyleBackColor = true;
            // 
            // RealizarAgendamentoSaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "RealizarAgendamentoSaque";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_TituloSaque;
        private System.Windows.Forms.Label lb_TextoExplicativoListarCliente;
        private System.Windows.Forms.Label lb_SubtituloListarCliente;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label lb_ValorInicial;
        protected System.Windows.Forms.TextBox tb_Valor;
        protected System.Windows.Forms.TextBox tb_Beneficiario;
        protected System.Windows.Forms.DateTimePicker dtp_DataAgendamento;
        protected System.Windows.Forms.Button btn_Confirmar_AgendarSaque;
        protected System.Windows.Forms.Button btn_Limpar;
        protected System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_CriarEvento;
    }
}
