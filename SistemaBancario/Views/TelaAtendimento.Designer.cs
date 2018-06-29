namespace SistemaBancario.Views
{
    partial class TelaAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAtendimento));
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnAgencias = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.btnAgencias);
            this.p_Content.Controls.Add(this.btnFAQ);
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
            this.btn_Extrato.FlatAppearance.BorderSize = 0;
            this.btn_Extrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            // 
            // btn_Atendimento
            // 
            this.btn_Atendimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Atendimento.FlatAppearance.BorderSize = 0;
            this.btn_Atendimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btnFAQ
            // 
            this.btnFAQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnFAQ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFAQ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFAQ.Image = ((System.Drawing.Image)(resources.GetObject("btnFAQ.Image")));
            this.btnFAQ.Location = new System.Drawing.Point(391, 219);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(156, 136);
            this.btnFAQ.TabIndex = 0;
            this.btnFAQ.Text = "FAQ - PERGUNTAS FREQUENTES";
            this.btnFAQ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFAQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFAQ.UseVisualStyleBackColor = false;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // btnAgencias
            // 
            this.btnAgencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnAgencias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgencias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgencias.Image = ((System.Drawing.Image)(resources.GetObject("btnAgencias.Image")));
            this.btnAgencias.Location = new System.Drawing.Point(563, 219);
            this.btnAgencias.Name = "btnAgencias";
            this.btnAgencias.Size = new System.Drawing.Size(156, 136);
            this.btnAgencias.TabIndex = 1;
            this.btnAgencias.Text = "LOCALIZAR AGÊNCIA";
            this.btnAgencias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgencias.UseVisualStyleBackColor = false;
            this.btnAgencias.Click += new System.EventHandler(this.btnAgencias_Click);
            // 
            // TelaAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "TelaAtendimento";
            this.Text = "TelaAtendimento";
            this.p_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgencias;
        private System.Windows.Forms.Button btnFAQ;
    }
}