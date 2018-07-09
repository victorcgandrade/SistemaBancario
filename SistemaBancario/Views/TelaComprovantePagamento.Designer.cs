namespace SistemaBancario.Views
{
    partial class TelaComprovantePagamento
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
            this.lb_TituloPagamentos = new System.Windows.Forms.Label();
            this.dataGridView_Pagamentos = new System.Windows.Forms.DataGridView();
            this.btn_Retornar = new System.Windows.Forms.Button();
            this.textBox_VisualizarPagamento = new System.Windows.Forms.TextBox();
            this.label_VisualizarPagamento = new System.Windows.Forms.Label();
            this.button_Enviar = new System.Windows.Forms.Button();
            this.label_ComprovantePagamento_Tooltip = new System.Windows.Forms.Label();
            this.p_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.label_ComprovantePagamento_Tooltip);
            this.p_Content.Controls.Add(this.button_Enviar);
            this.p_Content.Controls.Add(this.textBox_VisualizarPagamento);
            this.p_Content.Controls.Add(this.label_VisualizarPagamento);
            this.p_Content.Controls.Add(this.btn_Retornar);
            this.p_Content.Controls.Add(this.dataGridView_Pagamentos);
            this.p_Content.Controls.Add(this.lb_TituloPagamentos);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            // 
            // btn_Investimentos
            // 
            this.btn_Investimentos.FlatAppearance.BorderSize = 0;
            this.btn_Investimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_AgendamentoSaque
            // 
            this.btn_AgendamentoSaque.FlatAppearance.BorderSize = 0;
            this.btn_AgendamentoSaque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Tranferencias
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
            this.btn_Extrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Extrato.FlatAppearance.BorderSize = 0;
            this.btn_Extrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Atendimento
            // 
            this.btn_Atendimento.FlatAppearance.BorderSize = 0;
            this.btn_Atendimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // lb_TituloPagamentos
            // 
            this.lb_TituloPagamentos.AutoSize = true;
            this.lb_TituloPagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloPagamentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloPagamentos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloPagamentos.Location = new System.Drawing.Point(169, 91);
            this.lb_TituloPagamentos.Name = "lb_TituloPagamentos";
            this.lb_TituloPagamentos.Size = new System.Drawing.Size(373, 21);
            this.lb_TituloPagamentos.TabIndex = 86;
            this.lb_TituloPagamentos.Text = "VISUALIZAR COMPROVANTES DE PAGAMENTOS";
            // 
            // dataGridView_Pagamentos
            // 
            this.dataGridView_Pagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pagamentos.Location = new System.Drawing.Point(173, 161);
            this.dataGridView_Pagamentos.Name = "dataGridView_Pagamentos";
            this.dataGridView_Pagamentos.Size = new System.Drawing.Size(649, 194);
            this.dataGridView_Pagamentos.TabIndex = 87;
            // 
            // btn_Retornar
            // 
            this.btn_Retornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(174)))), ((int)(((byte)(170)))));
            this.btn_Retornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Retornar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retornar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Retornar.Location = new System.Drawing.Point(173, 438);
            this.btn_Retornar.Name = "btn_Retornar";
            this.btn_Retornar.Size = new System.Drawing.Size(90, 29);
            this.btn_Retornar.TabIndex = 97;
            this.btn_Retornar.Text = "Retornar";
            this.btn_Retornar.UseVisualStyleBackColor = false;
            this.btn_Retornar.Click += new System.EventHandler(this.btn_Retornar_Click);
            // 
            // textBox_VisualizarPagamento
            // 
            this.textBox_VisualizarPagamento.Location = new System.Drawing.Point(527, 380);
            this.textBox_VisualizarPagamento.Name = "textBox_VisualizarPagamento";
            this.textBox_VisualizarPagamento.Size = new System.Drawing.Size(90, 20);
            this.textBox_VisualizarPagamento.TabIndex = 104;
            // 
            // label_VisualizarPagamento
            // 
            this.label_VisualizarPagamento.AutoSize = true;
            this.label_VisualizarPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label_VisualizarPagamento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VisualizarPagamento.Location = new System.Drawing.Point(336, 380);
            this.label_VisualizarPagamento.Name = "label_VisualizarPagamento";
            this.label_VisualizarPagamento.Size = new System.Drawing.Size(188, 17);
            this.label_VisualizarPagamento.TabIndex = 103;
            this.label_VisualizarPagamento.Text = "Enviar comprovante por SMS:";
            // 
            // button_Enviar
            // 
            this.button_Enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(117)))));
            this.button_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Enviar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Enviar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Enviar.Location = new System.Drawing.Point(732, 374);
            this.button_Enviar.Name = "button_Enviar";
            this.button_Enviar.Size = new System.Drawing.Size(90, 29);
            this.button_Enviar.TabIndex = 105;
            this.button_Enviar.Text = "Enviar";
            this.button_Enviar.UseVisualStyleBackColor = false;
            this.button_Enviar.Click += new System.EventHandler(this.button_Enviar_Click);
            // 
            // label_ComprovantePagamento_Tooltip
            // 
            this.label_ComprovantePagamento_Tooltip.AutoSize = true;
            this.label_ComprovantePagamento_Tooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label_ComprovantePagamento_Tooltip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label_ComprovantePagamento_Tooltip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_ComprovantePagamento_Tooltip.Location = new System.Drawing.Point(336, 403);
            this.label_ComprovantePagamento_Tooltip.Name = "label_ComprovantePagamento_Tooltip";
            this.label_ComprovantePagamento_Tooltip.Size = new System.Drawing.Size(269, 17);
            this.label_ComprovantePagamento_Tooltip.TabIndex = 124;
            this.label_ComprovantePagamento_Tooltip.Text = "(Insira o id correspondente ao pagamento)";
            // 
            // TelaComprovantePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "TelaComprovantePagamento";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pagamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_TituloPagamentos;
        private System.Windows.Forms.DataGridView dataGridView_Pagamentos;
        private System.Windows.Forms.Button btn_Retornar;
        private System.Windows.Forms.TextBox textBox_VisualizarPagamento;
        private System.Windows.Forms.Label label_VisualizarPagamento;
        private System.Windows.Forms.Button button_Enviar;
        private System.Windows.Forms.Label label_ComprovantePagamento_Tooltip;
    }
}
