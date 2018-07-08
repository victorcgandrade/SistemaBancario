namespace SistemaBancario.Views
{
    partial class ListarAplicacoesCliente
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
            this.lb_TituloMinhasAplicacoes = new System.Windows.Forms.Label();
            this.lb_SubtituloMinhasAplicacoes = new System.Windows.Forms.Label();
            this.dgv_ResultadoAplicacoesCliente = new System.Windows.Forms.DataGridView();
            this.btn_Retornar = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoAplicacoesCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.btn_Retornar);
            this.p_Content.Controls.Add(this.dgv_ResultadoAplicacoesCliente);
            this.p_Content.Controls.Add(this.lb_SubtituloMinhasAplicacoes);
            this.p_Content.Controls.Add(this.lb_TituloMinhasAplicacoes);
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
            // lb_TituloMinhasAplicacoes
            // 
            this.lb_TituloMinhasAplicacoes.AutoSize = true;
            this.lb_TituloMinhasAplicacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloMinhasAplicacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloMinhasAplicacoes.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloMinhasAplicacoes.Location = new System.Drawing.Point(30, 30);
            this.lb_TituloMinhasAplicacoes.Name = "lb_TituloMinhasAplicacoes";
            this.lb_TituloMinhasAplicacoes.Size = new System.Drawing.Size(174, 21);
            this.lb_TituloMinhasAplicacoes.TabIndex = 80;
            this.lb_TituloMinhasAplicacoes.Text = "MINHAS APLICAÇÕES";
            // 
            // lb_SubtituloMinhasAplicacoes
            // 
            this.lb_SubtituloMinhasAplicacoes.AutoSize = true;
            this.lb_SubtituloMinhasAplicacoes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SubtituloMinhasAplicacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lb_SubtituloMinhasAplicacoes.Location = new System.Drawing.Point(506, 99);
            this.lb_SubtituloMinhasAplicacoes.Name = "lb_SubtituloMinhasAplicacoes";
            this.lb_SubtituloMinhasAplicacoes.Size = new System.Drawing.Size(153, 20);
            this.lb_SubtituloMinhasAplicacoes.TabIndex = 87;
            this.lb_SubtituloMinhasAplicacoes.Text = "Aplicações realizadas";
            // 
            // dgv_ResultadoAplicacoesCliente
            // 
            this.dgv_ResultadoAplicacoesCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ResultadoAplicacoesCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ResultadoAplicacoesCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ResultadoAplicacoesCliente.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ResultadoAplicacoesCliente.Location = new System.Drawing.Point(311, 132);
            this.dgv_ResultadoAplicacoesCliente.Name = "dgv_ResultadoAplicacoesCliente";
            this.dgv_ResultadoAplicacoesCliente.ReadOnly = true;
            this.dgv_ResultadoAplicacoesCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ResultadoAplicacoesCliente.Size = new System.Drawing.Size(542, 248);
            this.dgv_ResultadoAplicacoesCliente.TabIndex = 92;
            this.dgv_ResultadoAplicacoesCliente.Visible = false;
            // 
            // btn_Retornar
            // 
            this.btn_Retornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_Retornar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retornar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Retornar.Location = new System.Drawing.Point(520, 445);
            this.btn_Retornar.Name = "btn_Retornar";
            this.btn_Retornar.Size = new System.Drawing.Size(125, 32);
            this.btn_Retornar.TabIndex = 95;
            this.btn_Retornar.Text = "Retornar";
            this.btn_Retornar.UseVisualStyleBackColor = false;
            this.btn_Retornar.Visible = false;
            this.btn_Retornar.Click += new System.EventHandler(this.btn_Retornar_Click);
            // 
            // ListarAplicacoesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "ListarAplicacoesCliente";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoAplicacoesCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_TituloMinhasAplicacoes;
        private System.Windows.Forms.Label lb_SubtituloMinhasAplicacoes;
        private System.Windows.Forms.DataGridView dgv_ResultadoAplicacoesCliente;
        private System.Windows.Forms.Button btn_Retornar;
    }
}
