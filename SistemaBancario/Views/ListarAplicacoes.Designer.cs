namespace SistemaBancario.Views
{
    partial class ListarAplicacoes
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
            this.dgv_ResultadoListarAplicacao = new System.Windows.Forms.DataGridView();
            this.lb_TextoExplicativoListarAplicacao = new System.Windows.Forms.Label();
            this.lb_SubtituloListarAplicacao = new System.Windows.Forms.Label();
            this.lb_TituloListarAplicacao = new System.Windows.Forms.Label();
            this.p_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoListarAplicacao)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.dgv_ResultadoListarAplicacao);
            this.p_Content.Controls.Add(this.lb_TextoExplicativoListarAplicacao);
            this.p_Content.Controls.Add(this.lb_SubtituloListarAplicacao);
            this.p_Content.Controls.Add(this.lb_TituloListarAplicacao);
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
            // dgv_ResultadoListarAplicacao
            // 
            this.dgv_ResultadoListarAplicacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ResultadoListarAplicacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ResultadoListarAplicacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ResultadoListarAplicacao.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ResultadoListarAplicacao.Location = new System.Drawing.Point(306, 177);
            this.dgv_ResultadoListarAplicacao.Name = "dgv_ResultadoListarAplicacao";
            this.dgv_ResultadoListarAplicacao.ReadOnly = true;
            this.dgv_ResultadoListarAplicacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ResultadoListarAplicacao.Size = new System.Drawing.Size(510, 201);
            this.dgv_ResultadoListarAplicacao.TabIndex = 92;
            // 
            // lb_TextoExplicativoListarAplicacao
            // 
            this.lb_TextoExplicativoListarAplicacao.AutoSize = true;
            this.lb_TextoExplicativoListarAplicacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TextoExplicativoListarAplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lb_TextoExplicativoListarAplicacao.Location = new System.Drawing.Point(381, 128);
            this.lb_TextoExplicativoListarAplicacao.Name = "lb_TextoExplicativoListarAplicacao";
            this.lb_TextoExplicativoListarAplicacao.Size = new System.Drawing.Size(360, 15);
            this.lb_TextoExplicativoListarAplicacao.TabIndex = 91;
            this.lb_TextoExplicativoListarAplicacao.Text = "Na tabela abaixo, estão todas as aplicações registradas no sistema.";
            // 
            // lb_SubtituloListarAplicacao
            // 
            this.lb_SubtituloListarAplicacao.AutoSize = true;
            this.lb_SubtituloListarAplicacao.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SubtituloListarAplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lb_SubtituloListarAplicacao.Location = new System.Drawing.Point(479, 104);
            this.lb_SubtituloListarAplicacao.Name = "lb_SubtituloListarAplicacao";
            this.lb_SubtituloListarAplicacao.Size = new System.Drawing.Size(164, 20);
            this.lb_SubtituloListarAplicacao.TabIndex = 90;
            this.lb_SubtituloListarAplicacao.Text = "Listagem de aplicações";
            // 
            // lb_TituloListarAplicacao
            // 
            this.lb_TituloListarAplicacao.AutoSize = true;
            this.lb_TituloListarAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloListarAplicacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloListarAplicacao.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloListarAplicacao.Location = new System.Drawing.Point(30, 41);
            this.lb_TituloListarAplicacao.Name = "lb_TituloListarAplicacao";
            this.lb_TituloListarAplicacao.Size = new System.Drawing.Size(160, 21);
            this.lb_TituloListarAplicacao.TabIndex = 89;
            this.lb_TituloListarAplicacao.Text = "LISTAR APLICAÇÕES";
            // 
            // ListarAplicacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "ListarAplicacoes";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoListarAplicacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ResultadoListarAplicacao;
        private System.Windows.Forms.Label lb_TextoExplicativoListarAplicacao;
        private System.Windows.Forms.Label lb_SubtituloListarAplicacao;
        private System.Windows.Forms.Label lb_TituloListarAplicacao;
    }
}
