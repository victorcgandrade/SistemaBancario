namespace SistemaBancario.Views
{
    partial class ListarPagamentos
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
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.button_Confirmar);
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
            this.btn_Tranferencias.FlatAppearance.BorderSize = 0;
            this.btn_Tranferencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
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
            this.lb_TituloPagamentos.Size = new System.Drawing.Size(376, 21);
            this.lb_TituloPagamentos.TabIndex = 86;
            this.lb_TituloPagamentos.Text = "VISUALIZAR COMPROVANTES DE PAGAMENTOS";
            // 
            // dataGridView_Pagamentos
            // 
            this.dataGridView_Pagamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Pagamentos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
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
            this.textBox_VisualizarPagamento.Location = new System.Drawing.Point(406, 394);
            this.textBox_VisualizarPagamento.Name = "textBox_VisualizarPagamento";
            this.textBox_VisualizarPagamento.Size = new System.Drawing.Size(90, 20);
            this.textBox_VisualizarPagamento.TabIndex = 104;
            // 
            // label_VisualizarPagamento
            // 
            this.label_VisualizarPagamento.AutoSize = true;
            this.label_VisualizarPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label_VisualizarPagamento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VisualizarPagamento.Location = new System.Drawing.Point(170, 394);
            this.label_VisualizarPagamento.Name = "label_VisualizarPagamento";
            this.label_VisualizarPagamento.Size = new System.Drawing.Size(230, 17);
            this.label_VisualizarPagamento.TabIndex = 103;
            this.label_VisualizarPagamento.Text = "Insira o Identificador do Pagamento:";
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(117)))));
            this.button_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Confirmar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Confirmar.Location = new System.Drawing.Point(732, 388);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(90, 29);
            this.button_Confirmar.TabIndex = 105;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = false;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // ListarPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "ListarPagamentos";
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
        private System.Windows.Forms.Button button_Confirmar;
    }
}
