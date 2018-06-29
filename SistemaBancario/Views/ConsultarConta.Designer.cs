namespace SistemaBancario.Views
{
    partial class ConsultarConta
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
            this.lb_TituloConsultarConta = new System.Windows.Forms.Label();
            this.lb_InformativoVisualizarConta = new System.Windows.Forms.Label();
            this.btn_VisualizarConta = new System.Windows.Forms.Button();
            this.dgv_ResultadoBuscaConta = new System.Windows.Forms.DataGridView();
            this.btn_BuscarConta = new System.Windows.Forms.Button();
            this.lb_TextoExplicativoConsultarConta = new System.Windows.Forms.Label();
            this.lb_SubtituloConsultarConta = new System.Windows.Forms.Label();
            this.tb_CampoBuscaConta = new System.Windows.Forms.TextBox();
            this.p_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoBuscaConta)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.lb_InformativoVisualizarConta);
            this.p_Content.Controls.Add(this.btn_VisualizarConta);
            this.p_Content.Controls.Add(this.dgv_ResultadoBuscaConta);
            this.p_Content.Controls.Add(this.btn_BuscarConta);
            this.p_Content.Controls.Add(this.lb_TextoExplicativoConsultarConta);
            this.p_Content.Controls.Add(this.lb_SubtituloConsultarConta);
            this.p_Content.Controls.Add(this.tb_CampoBuscaConta);
            this.p_Content.Controls.Add(this.lb_TituloConsultarConta);
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
            // lb_TituloConsultarConta
            // 
            this.lb_TituloConsultarConta.AutoSize = true;
            this.lb_TituloConsultarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloConsultarConta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloConsultarConta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloConsultarConta.Location = new System.Drawing.Point(30, 30);
            this.lb_TituloConsultarConta.Name = "lb_TituloConsultarConta";
            this.lb_TituloConsultarConta.Size = new System.Drawing.Size(160, 21);
            this.lb_TituloConsultarConta.TabIndex = 79;
            this.lb_TituloConsultarConta.Text = "CONSULTAR CONTA";
            // 
            // lb_InformativoVisualizarConta
            // 
            this.lb_InformativoVisualizarConta.AutoSize = true;
            this.lb_InformativoVisualizarConta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InformativoVisualizarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lb_InformativoVisualizarConta.Location = new System.Drawing.Point(325, 448);
            this.lb_InformativoVisualizarConta.Name = "lb_InformativoVisualizarConta";
            this.lb_InformativoVisualizarConta.Size = new System.Drawing.Size(461, 15);
            this.lb_InformativoVisualizarConta.TabIndex = 91;
            this.lb_InformativoVisualizarConta.Text = "Selecione uma linha da tabela acima e clique em Visualizar  para saber mais da co" +
    "nta.";
            this.lb_InformativoVisualizarConta.Visible = false;
            // 
            // btn_VisualizarConta
            // 
            this.btn_VisualizarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_VisualizarConta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VisualizarConta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_VisualizarConta.Location = new System.Drawing.Point(494, 486);
            this.btn_VisualizarConta.Name = "btn_VisualizarConta";
            this.btn_VisualizarConta.Size = new System.Drawing.Size(125, 32);
            this.btn_VisualizarConta.TabIndex = 90;
            this.btn_VisualizarConta.Text = "Visualizar";
            this.btn_VisualizarConta.UseVisualStyleBackColor = false;
            this.btn_VisualizarConta.Visible = false;
            this.btn_VisualizarConta.Click += new System.EventHandler(this.btn_VisualizarConta_Click);
            // 
            // dgv_ResultadoBuscaConta
            // 
            this.dgv_ResultadoBuscaConta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ResultadoBuscaConta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ResultadoBuscaConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ResultadoBuscaConta.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ResultadoBuscaConta.Location = new System.Drawing.Point(300, 238);
            this.dgv_ResultadoBuscaConta.Name = "dgv_ResultadoBuscaConta";
            this.dgv_ResultadoBuscaConta.ReadOnly = true;
            this.dgv_ResultadoBuscaConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ResultadoBuscaConta.Size = new System.Drawing.Size(510, 201);
            this.dgv_ResultadoBuscaConta.TabIndex = 89;
            this.dgv_ResultadoBuscaConta.Visible = false;
            // 
            // btn_BuscarConta
            // 
            this.btn_BuscarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_BuscarConta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarConta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_BuscarConta.Location = new System.Drawing.Point(518, 185);
            this.btn_BuscarConta.Name = "btn_BuscarConta";
            this.btn_BuscarConta.Size = new System.Drawing.Size(75, 32);
            this.btn_BuscarConta.TabIndex = 88;
            this.btn_BuscarConta.Text = "Buscar";
            this.btn_BuscarConta.UseVisualStyleBackColor = false;
            this.btn_BuscarConta.Click += new System.EventHandler(this.btn_BuscarConta_Click);
            // 
            // lb_TextoExplicativoConsultarConta
            // 
            this.lb_TextoExplicativoConsultarConta.AutoSize = true;
            this.lb_TextoExplicativoConsultarConta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TextoExplicativoConsultarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lb_TextoExplicativoConsultarConta.Location = new System.Drawing.Point(385, 131);
            this.lb_TextoExplicativoConsultarConta.Name = "lb_TextoExplicativoConsultarConta";
            this.lb_TextoExplicativoConsultarConta.Size = new System.Drawing.Size(339, 15);
            this.lb_TextoExplicativoConsultarConta.TabIndex = 87;
            this.lb_TextoExplicativoConsultarConta.Text = "Insira o número da conta que deseja procurar no campo abaixo.";
            // 
            // lb_SubtituloConsultarConta
            // 
            this.lb_SubtituloConsultarConta.AutoSize = true;
            this.lb_SubtituloConsultarConta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SubtituloConsultarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lb_SubtituloConsultarConta.Location = new System.Drawing.Point(471, 107);
            this.lb_SubtituloConsultarConta.Name = "lb_SubtituloConsultarConta";
            this.lb_SubtituloConsultarConta.Size = new System.Drawing.Size(167, 20);
            this.lb_SubtituloConsultarConta.TabIndex = 86;
            this.lb_SubtituloConsultarConta.Text = "Procure por uma conta";
            // 
            // tb_CampoBuscaConta
            // 
            this.tb_CampoBuscaConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_CampoBuscaConta.Location = new System.Drawing.Point(421, 159);
            this.tb_CampoBuscaConta.Name = "tb_CampoBuscaConta";
            this.tb_CampoBuscaConta.Size = new System.Drawing.Size(266, 20);
            this.tb_CampoBuscaConta.TabIndex = 85;
            // 
            // ConsultarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "ConsultarConta";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoBuscaConta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_TituloConsultarConta;
        private System.Windows.Forms.Label lb_InformativoVisualizarConta;
        private System.Windows.Forms.Button btn_VisualizarConta;
        private System.Windows.Forms.DataGridView dgv_ResultadoBuscaConta;
        private System.Windows.Forms.Button btn_BuscarConta;
        private System.Windows.Forms.Label lb_TextoExplicativoConsultarConta;
        private System.Windows.Forms.Label lb_SubtituloConsultarConta;
        private System.Windows.Forms.TextBox tb_CampoBuscaConta;
    }
}
