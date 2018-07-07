namespace SistemaBancario.Views
{
    partial class AplicacoesCliente
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
            this.btn_CriarAplicacao = new System.Windows.Forms.Button();
            this.btn_ConsultarAplicacao = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.btn_ConsultarAplicacao);
            this.p_Content.Controls.Add(this.btn_CriarAplicacao);
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
            this.btn_Extrato.FlatAppearance.BorderSize = 0;
            this.btn_Extrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Atendimento
            // 
            this.btn_Atendimento.FlatAppearance.BorderSize = 0;
            this.btn_Atendimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_CriarAplicacao
            // 
            this.btn_CriarAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_CriarAplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CriarAplicacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CriarAplicacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CriarAplicacao.Image = global::SistemaBancario.Properties.Resources.add;
            this.btn_CriarAplicacao.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CriarAplicacao.Location = new System.Drawing.Point(410, 219);
            this.btn_CriarAplicacao.Name = "btn_CriarAplicacao";
            this.btn_CriarAplicacao.Size = new System.Drawing.Size(156, 136);
            this.btn_CriarAplicacao.TabIndex = 2;
            this.btn_CriarAplicacao.Text = "NOVA APLICAÇÃO";
            this.btn_CriarAplicacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_CriarAplicacao.UseVisualStyleBackColor = false;
            // 
            // btn_ConsultarAplicacao
            // 
            this.btn_ConsultarAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_ConsultarAplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConsultarAplicacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ConsultarAplicacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ConsultarAplicacao.Image = global::SistemaBancario.Properties.Resources.magnifying_glass;
            this.btn_ConsultarAplicacao.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ConsultarAplicacao.Location = new System.Drawing.Point(583, 219);
            this.btn_ConsultarAplicacao.Name = "btn_ConsultarAplicacao";
            this.btn_ConsultarAplicacao.Size = new System.Drawing.Size(156, 136);
            this.btn_ConsultarAplicacao.TabIndex = 3;
            this.btn_ConsultarAplicacao.Text = "MINHAS APLICAÇÕES";
            this.btn_ConsultarAplicacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ConsultarAplicacao.UseVisualStyleBackColor = false;
            // 
            // AplicacoesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "AplicacoesCliente";
            this.p_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CriarAplicacao;
        private System.Windows.Forms.Button btn_ConsultarAplicacao;
    }
}
