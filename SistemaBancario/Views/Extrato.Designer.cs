namespace SistemaBancario.Views
{
    partial class Extrato
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
            this.lb_TituloExtrato = new System.Windows.Forms.Label();
            this.btn_VisualizarComprovantes = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.btn_VisualizarComprovantes);
            this.p_Content.Controls.Add(this.lb_TituloExtrato);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
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
            this.btn_Extrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Extrato.FlatAppearance.BorderSize = 0;
            this.btn_Extrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // btn_Atendimento
            // 
            this.btn_Atendimento.FlatAppearance.BorderSize = 0;
            this.btn_Atendimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // lb_TituloExtrato
            // 
            this.lb_TituloExtrato.AutoSize = true;
            this.lb_TituloExtrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloExtrato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloExtrato.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloExtrato.Location = new System.Drawing.Point(169, 91);
            this.lb_TituloExtrato.Name = "lb_TituloExtrato";
            this.lb_TituloExtrato.Size = new System.Drawing.Size(78, 21);
            this.lb_TituloExtrato.TabIndex = 86;
            this.lb_TituloExtrato.Text = "EXTRATO";
            // 
            // btn_VisualizarComprovantes
            // 
            this.btn_VisualizarComprovantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_VisualizarComprovantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VisualizarComprovantes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_VisualizarComprovantes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_VisualizarComprovantes.Image = global::SistemaBancario.Properties.Resources.magnifying_glass;
            this.btn_VisualizarComprovantes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_VisualizarComprovantes.Location = new System.Drawing.Point(173, 208);
            this.btn_VisualizarComprovantes.Name = "btn_VisualizarComprovantes";
            this.btn_VisualizarComprovantes.Size = new System.Drawing.Size(156, 136);
            this.btn_VisualizarComprovantes.TabIndex = 87;
            this.btn_VisualizarComprovantes.Text = "VISUALIZAR COMPROVANTES";
            this.btn_VisualizarComprovantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_VisualizarComprovantes.UseVisualStyleBackColor = false;
            // 
            // Extrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "Extrato";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_TituloExtrato;
        private System.Windows.Forms.Button btn_VisualizarComprovantes;
    }
}
