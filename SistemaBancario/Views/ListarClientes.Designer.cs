namespace SistemaBancario.Views
{
    partial class ListarClientes
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
            this.lb_TextoExplicativoListarCliente = new System.Windows.Forms.Label();
            this.lb_SubtituloListarCliente = new System.Windows.Forms.Label();
            this.lb_TituloListarCliente = new System.Windows.Forms.Label();
            this.dgv_ResultadoListarCliente = new System.Windows.Forms.DataGridView();
            this.p_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoListarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.dgv_ResultadoListarCliente);
            this.p_Content.Controls.Add(this.lb_TextoExplicativoListarCliente);
            this.p_Content.Controls.Add(this.lb_SubtituloListarCliente);
            this.p_Content.Controls.Add(this.lb_TituloListarCliente);
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
            // lb_TextoExplicativoListarCliente
            // 
            this.lb_TextoExplicativoListarCliente.AutoSize = true;
            this.lb_TextoExplicativoListarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TextoExplicativoListarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lb_TextoExplicativoListarCliente.Location = new System.Drawing.Point(388, 128);
            this.lb_TextoExplicativoListarCliente.Name = "lb_TextoExplicativoListarCliente";
            this.lb_TextoExplicativoListarCliente.Size = new System.Drawing.Size(342, 15);
            this.lb_TextoExplicativoListarCliente.TabIndex = 87;
            this.lb_TextoExplicativoListarCliente.Text = "Na tabela abaixo, estão todos os clientes registrados no sistema.";
            // 
            // lb_SubtituloListarCliente
            // 
            this.lb_SubtituloListarCliente.AutoSize = true;
            this.lb_SubtituloListarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SubtituloListarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lb_SubtituloListarCliente.Location = new System.Drawing.Point(487, 104);
            this.lb_SubtituloListarCliente.Name = "lb_SubtituloListarCliente";
            this.lb_SubtituloListarCliente.Size = new System.Drawing.Size(145, 20);
            this.lb_SubtituloListarCliente.TabIndex = 86;
            this.lb_SubtituloListarCliente.Text = "Listagem de clientes";
            // 
            // lb_TituloListarCliente
            // 
            this.lb_TituloListarCliente.AutoSize = true;
            this.lb_TituloListarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloListarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloListarCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloListarCliente.Location = new System.Drawing.Point(38, 41);
            this.lb_TituloListarCliente.Name = "lb_TituloListarCliente";
            this.lb_TituloListarCliente.Size = new System.Drawing.Size(137, 21);
            this.lb_TituloListarCliente.TabIndex = 85;
            this.lb_TituloListarCliente.Text = "LISTAR CLIENTES";
            // 
            // dgv_ResultadoListarCliente
            // 
            this.dgv_ResultadoListarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ResultadoListarCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ResultadoListarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ResultadoListarCliente.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ResultadoListarCliente.Location = new System.Drawing.Point(304, 177);
            this.dgv_ResultadoListarCliente.Name = "dgv_ResultadoListarCliente";
            this.dgv_ResultadoListarCliente.ReadOnly = true;
            this.dgv_ResultadoListarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ResultadoListarCliente.Size = new System.Drawing.Size(510, 201);
            this.dgv_ResultadoListarCliente.TabIndex = 88;
            // 
            // ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "ListarClientes";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoListarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_TextoExplicativoListarCliente;
        private System.Windows.Forms.Label lb_SubtituloListarCliente;
        private System.Windows.Forms.Label lb_TituloListarCliente;
        private System.Windows.Forms.DataGridView dgv_ResultadoListarCliente;
    }
}
