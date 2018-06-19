namespace SistemaBancario.Views
{
    partial class VisualizarAplicacao
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
            this.dgv_VisualizarAplicacao = new System.Windows.Forms.DataGridView();
            this.lb_IdentificadorAplicacao = new System.Windows.Forms.Label();
            this.pb_IconeCliente = new System.Windows.Forms.PictureBox();
            this.btn_AlterarAplicacao = new System.Windows.Forms.Button();
            this.btn_CancelarAplicacao = new System.Windows.Forms.Button();
            this.lb_TituloVisualizarAplicacao = new System.Windows.Forms.Label();
            this.p_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizarAplicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconeCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.dgv_VisualizarAplicacao);
            this.p_Content.Controls.Add(this.lb_IdentificadorAplicacao);
            this.p_Content.Controls.Add(this.pb_IconeCliente);
            this.p_Content.Controls.Add(this.btn_AlterarAplicacao);
            this.p_Content.Controls.Add(this.btn_CancelarAplicacao);
            this.p_Content.Controls.Add(this.lb_TituloVisualizarAplicacao);
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
            // dgv_VisualizarAplicacao
            // 
            this.dgv_VisualizarAplicacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_VisualizarAplicacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_VisualizarAplicacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VisualizarAplicacao.Location = new System.Drawing.Point(322, 152);
            this.dgv_VisualizarAplicacao.Name = "dgv_VisualizarAplicacao";
            this.dgv_VisualizarAplicacao.ReadOnly = true;
            this.dgv_VisualizarAplicacao.Size = new System.Drawing.Size(460, 315);
            this.dgv_VisualizarAplicacao.TabIndex = 96;
            // 
            // lb_IdentificadorAplicacao
            // 
            this.lb_IdentificadorAplicacao.AutoSize = true;
            this.lb_IdentificadorAplicacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdentificadorAplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lb_IdentificadorAplicacao.Location = new System.Drawing.Point(265, 89);
            this.lb_IdentificadorAplicacao.Name = "lb_IdentificadorAplicacao";
            this.lb_IdentificadorAplicacao.Size = new System.Drawing.Size(192, 20);
            this.lb_IdentificadorAplicacao.TabIndex = 95;
            this.lb_IdentificadorAplicacao.Text = "Aplicação Nº X Conta XXXX";
            // 
            // pb_IconeCliente
            // 
            this.pb_IconeCliente.Image = global::SistemaBancario.Properties.Resources.money_bag;
            this.pb_IconeCliente.Location = new System.Drawing.Point(222, 80);
            this.pb_IconeCliente.Name = "pb_IconeCliente";
            this.pb_IconeCliente.Size = new System.Drawing.Size(37, 38);
            this.pb_IconeCliente.TabIndex = 94;
            this.pb_IconeCliente.TabStop = false;
            // 
            // btn_AlterarAplicacao
            // 
            this.btn_AlterarAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btn_AlterarAplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AlterarAplicacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarAplicacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AlterarAplicacao.Location = new System.Drawing.Point(702, 80);
            this.btn_AlterarAplicacao.Name = "btn_AlterarAplicacao";
            this.btn_AlterarAplicacao.Size = new System.Drawing.Size(90, 29);
            this.btn_AlterarAplicacao.TabIndex = 92;
            this.btn_AlterarAplicacao.Text = "Alterar";
            this.btn_AlterarAplicacao.UseVisualStyleBackColor = false;
            // 
            // btn_CancelarAplicacao
            // 
            this.btn_CancelarAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.btn_CancelarAplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarAplicacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarAplicacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CancelarAplicacao.Location = new System.Drawing.Point(798, 80);
            this.btn_CancelarAplicacao.Name = "btn_CancelarAplicacao";
            this.btn_CancelarAplicacao.Size = new System.Drawing.Size(90, 29);
            this.btn_CancelarAplicacao.TabIndex = 93;
            this.btn_CancelarAplicacao.Text = "Cancelar";
            this.btn_CancelarAplicacao.UseVisualStyleBackColor = false;
            this.btn_CancelarAplicacao.Click += new System.EventHandler(this.btn_RemoverAplicacao_Click);
            // 
            // lb_TituloVisualizarAplicacao
            // 
            this.lb_TituloVisualizarAplicacao.AutoSize = true;
            this.lb_TituloVisualizarAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloVisualizarAplicacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloVisualizarAplicacao.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloVisualizarAplicacao.Location = new System.Drawing.Point(30, 30);
            this.lb_TituloVisualizarAplicacao.Name = "lb_TituloVisualizarAplicacao";
            this.lb_TituloVisualizarAplicacao.Size = new System.Drawing.Size(198, 21);
            this.lb_TituloVisualizarAplicacao.TabIndex = 91;
            this.lb_TituloVisualizarAplicacao.Text = "VISUALIZAR  APLICAÇÃO";
            // 
            // VisualizarAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "VisualizarAplicacao";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizarAplicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconeCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VisualizarAplicacao;
        private System.Windows.Forms.Label lb_IdentificadorAplicacao;
        private System.Windows.Forms.PictureBox pb_IconeCliente;
        private System.Windows.Forms.Button btn_AlterarAplicacao;
        private System.Windows.Forms.Button btn_CancelarAplicacao;
        private System.Windows.Forms.Label lb_TituloVisualizarAplicacao;
    }
}
