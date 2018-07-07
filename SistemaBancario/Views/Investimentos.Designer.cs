namespace SistemaBancario.Views
{
    partial class Investimentos
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
            this.btn_Aplicacoes = new System.Windows.Forms.Button();
            this.btn_Resgate = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.btn_Resgate);
            this.p_Content.Controls.Add(this.btn_Aplicacoes);
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
            // btn_Aplicacoes
            // 
            this.btn_Aplicacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_Aplicacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aplicacoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aplicacoes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Aplicacoes.Image = global::SistemaBancario.Properties.Resources.investment__1_;
            this.btn_Aplicacoes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Aplicacoes.Location = new System.Drawing.Point(421, 219);
            this.btn_Aplicacoes.Name = "btn_Aplicacoes";
            this.btn_Aplicacoes.Size = new System.Drawing.Size(156, 136);
            this.btn_Aplicacoes.TabIndex = 1;
            this.btn_Aplicacoes.Text = "APLICAÇÕES";
            this.btn_Aplicacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Aplicacoes.UseVisualStyleBackColor = false;
            // 
            // btn_Resgate
            // 
            this.btn_Resgate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_Resgate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Resgate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Resgate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Resgate.Image = global::SistemaBancario.Properties.Resources.give_money__1_;
            this.btn_Resgate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Resgate.Location = new System.Drawing.Point(596, 219);
            this.btn_Resgate.Name = "btn_Resgate";
            this.btn_Resgate.Size = new System.Drawing.Size(156, 136);
            this.btn_Resgate.TabIndex = 2;
            this.btn_Resgate.Text = "RESGATE";
            this.btn_Resgate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Resgate.UseVisualStyleBackColor = false;
            // 
            // Investimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "Investimentos";
            this.Text = "Investimentos";
            this.Load += new System.EventHandler(this.Investimentos_Load);
            this.p_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Resgate;
        private System.Windows.Forms.Button btn_Aplicacoes;
    }
}