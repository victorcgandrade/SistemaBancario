namespace SistemaBancario.Views
{
    partial class ConsultarCliente
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
            this.tb_CampoBusca = new System.Windows.Forms.TextBox();
            this.lb_TituloConsultarCliente = new System.Windows.Forms.Label();
            this.lb_SubtituloConsultarCliente = new System.Windows.Forms.Label();
            this.lb_TextoExplicativoConsultarCliente = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgv_ResultadoBuscaCliente = new System.Windows.Forms.DataGridView();
            this.btn_VisualizarCliente = new System.Windows.Forms.Button();
            this.lb_InformativoVisualizarCliente = new System.Windows.Forms.Label();
            this.p_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoBuscaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.lb_InformativoVisualizarCliente);
            this.p_Content.Controls.Add(this.btn_VisualizarCliente);
            this.p_Content.Controls.Add(this.dgv_ResultadoBuscaCliente);
            this.p_Content.Controls.Add(this.btn_Buscar);
            this.p_Content.Controls.Add(this.lb_TextoExplicativoConsultarCliente);
            this.p_Content.Controls.Add(this.lb_SubtituloConsultarCliente);
            this.p_Content.Controls.Add(this.lb_TituloConsultarCliente);
            this.p_Content.Controls.Add(this.tb_CampoBusca);
            // 
            // p_LinkAtivo
            // 
            this.p_LinkAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
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
            this.btn_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
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
            this.btn_Aplicacoes.FlatAppearance.BorderSize = 0;
            this.btn_Aplicacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // tb_CampoBusca
            // 
            this.tb_CampoBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_CampoBusca.Location = new System.Drawing.Point(427, 149);
            this.tb_CampoBusca.Name = "tb_CampoBusca";
            this.tb_CampoBusca.Size = new System.Drawing.Size(266, 20);
            this.tb_CampoBusca.TabIndex = 1;
            // 
            // lb_TituloConsultarCliente
            // 
            this.lb_TituloConsultarCliente.AutoSize = true;
            this.lb_TituloConsultarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloConsultarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloConsultarCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloConsultarCliente.Location = new System.Drawing.Point(38, 41);
            this.lb_TituloConsultarCliente.Name = "lb_TituloConsultarCliente";
            this.lb_TituloConsultarCliente.Size = new System.Drawing.Size(169, 21);
            this.lb_TituloConsultarCliente.TabIndex = 78;
            this.lb_TituloConsultarCliente.Text = "CONSULTAR CLIENTE";
            // 
            // lb_SubtituloConsultarCliente
            // 
            this.lb_SubtituloConsultarCliente.AutoSize = true;
            this.lb_SubtituloConsultarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SubtituloConsultarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lb_SubtituloConsultarCliente.Location = new System.Drawing.Point(477, 97);
            this.lb_SubtituloConsultarCliente.Name = "lb_SubtituloConsultarCliente";
            this.lb_SubtituloConsultarCliente.Size = new System.Drawing.Size(166, 20);
            this.lb_SubtituloConsultarCliente.TabIndex = 79;
            this.lb_SubtituloConsultarCliente.Text = "Procure por um cliente";
            // 
            // lb_TextoExplicativoConsultarCliente
            // 
            this.lb_TextoExplicativoConsultarCliente.AutoSize = true;
            this.lb_TextoExplicativoConsultarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TextoExplicativoConsultarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lb_TextoExplicativoConsultarCliente.Location = new System.Drawing.Point(325, 121);
            this.lb_TextoExplicativoConsultarCliente.Name = "lb_TextoExplicativoConsultarCliente";
            this.lb_TextoExplicativoConsultarCliente.Size = new System.Drawing.Size(470, 15);
            this.lb_TextoExplicativoConsultarCliente.TabIndex = 80;
            this.lb_TextoExplicativoConsultarCliente.Text = "Insira o CPF (apenas números) ou nome do cliente que deseja procurar no campo aba" +
    "ixo.";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Buscar.Location = new System.Drawing.Point(524, 175);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 32);
            this.btn_Buscar.TabIndex = 81;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dgv_ResultadoBuscaCliente
            // 
            this.dgv_ResultadoBuscaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ResultadoBuscaCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ResultadoBuscaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ResultadoBuscaCliente.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ResultadoBuscaCliente.Location = new System.Drawing.Point(306, 228);
            this.dgv_ResultadoBuscaCliente.Name = "dgv_ResultadoBuscaCliente";
            this.dgv_ResultadoBuscaCliente.ReadOnly = true;
            this.dgv_ResultadoBuscaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ResultadoBuscaCliente.Size = new System.Drawing.Size(510, 201);
            this.dgv_ResultadoBuscaCliente.TabIndex = 82;
            // 
            // btn_VisualizarCliente
            // 
            this.btn_VisualizarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_VisualizarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VisualizarCliente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_VisualizarCliente.Location = new System.Drawing.Point(500, 476);
            this.btn_VisualizarCliente.Name = "btn_VisualizarCliente";
            this.btn_VisualizarCliente.Size = new System.Drawing.Size(125, 32);
            this.btn_VisualizarCliente.TabIndex = 83;
            this.btn_VisualizarCliente.Text = "Visualizar";
            this.btn_VisualizarCliente.UseVisualStyleBackColor = false;
            this.btn_VisualizarCliente.Click += new System.EventHandler(this.btn_VisualizarCliente_Click);
            // 
            // lb_InformativoVisualizarCliente
            // 
            this.lb_InformativoVisualizarCliente.AutoSize = true;
            this.lb_InformativoVisualizarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InformativoVisualizarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lb_InformativoVisualizarCliente.Location = new System.Drawing.Point(329, 438);
            this.lb_InformativoVisualizarCliente.Name = "lb_InformativoVisualizarCliente";
            this.lb_InformativoVisualizarCliente.Size = new System.Drawing.Size(465, 15);
            this.lb_InformativoVisualizarCliente.TabIndex = 84;
            this.lb_InformativoVisualizarCliente.Text = "Selecione uma linha da tabela acima e clique em Visualizar  para saber mais do cl" +
    "iente.";
            this.lb_InformativoVisualizarCliente.Visible = false;
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "ConsultarCliente";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoBuscaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_CampoBusca;
        private System.Windows.Forms.Label lb_TituloConsultarCliente;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lb_TextoExplicativoConsultarCliente;
        private System.Windows.Forms.Label lb_SubtituloConsultarCliente;
        private System.Windows.Forms.DataGridView dgv_ResultadoBuscaCliente;
        private System.Windows.Forms.Button btn_VisualizarCliente;
        private System.Windows.Forms.Label lb_InformativoVisualizarCliente;
    }
}
