namespace SistemaBancario.Views
{
    partial class InicialAdministradorAplicacao
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
            this.btn_ListarAplicacao = new System.Windows.Forms.Button();
            this.btn_ConsultarAplicacao = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.btn_ListarAplicacao);
            this.p_Content.Controls.Add(this.btn_ConsultarAplicacao);
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
            // btn_ListarAplicacao
            // 
            this.btn_ListarAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_ListarAplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ListarAplicacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ListarAplicacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ListarAplicacao.Image = global::SistemaBancario.Properties.Resources.list;
            this.btn_ListarAplicacao.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ListarAplicacao.Location = new System.Drawing.Point(559, 208);
            this.btn_ListarAplicacao.Name = "btn_ListarAplicacao";
            this.btn_ListarAplicacao.Size = new System.Drawing.Size(156, 136);
            this.btn_ListarAplicacao.TabIndex = 6;
            this.btn_ListarAplicacao.Text = "LISTAR APLICAÇÕES";
            this.btn_ListarAplicacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ListarAplicacao.UseVisualStyleBackColor = false;
            // 
            // btn_ConsultarAplicacao
            // 
            this.btn_ConsultarAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_ConsultarAplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConsultarAplicacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ConsultarAplicacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ConsultarAplicacao.Image = global::SistemaBancario.Properties.Resources.magnifying_glass;
            this.btn_ConsultarAplicacao.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ConsultarAplicacao.Location = new System.Drawing.Point(386, 208);
            this.btn_ConsultarAplicacao.Name = "btn_ConsultarAplicacao";
            this.btn_ConsultarAplicacao.Size = new System.Drawing.Size(156, 136);
            this.btn_ConsultarAplicacao.TabIndex = 5;
            this.btn_ConsultarAplicacao.Text = "CONSULTAR APLICAÇÃO";
            this.btn_ConsultarAplicacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ConsultarAplicacao.UseVisualStyleBackColor = false;
            this.btn_ConsultarAplicacao.Click += new System.EventHandler(this.btn_ConsultarAplicacao_Click);
            // 
            // InicialAdministradorAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "InicialAdministradorAplicacao";
            this.p_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ListarAplicacao;
        private System.Windows.Forms.Button btn_ConsultarAplicacao;
    }
}
