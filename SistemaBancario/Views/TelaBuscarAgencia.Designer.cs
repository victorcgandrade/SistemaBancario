namespace SistemaBancario.Views
{
    partial class TelaBuscarAgencia
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
            this.tcAtendimento = new System.Windows.Forms.TabControl();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.dgvAgencias = new System.Windows.Forms.DataGridView();
            this.tpAgencias = new System.Windows.Forms.TabPage();
            this.p_Content.SuspendLayout();
            this.tcAtendimento.SuspendLayout();
            this.tpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgencias)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.tcAtendimento);
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
            // tcAtendimento
            // 
            this.tcAtendimento.Controls.Add(this.tpLista);
            this.tcAtendimento.Controls.Add(this.tpAgencias);
            this.tcAtendimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tcAtendimento.Location = new System.Drawing.Point(58, 32);
            this.tcAtendimento.Name = "tcAtendimento";
            this.tcAtendimento.SelectedIndex = 0;
            this.tcAtendimento.Size = new System.Drawing.Size(1020, 538);
            this.tcAtendimento.TabIndex = 0;
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.dgvAgencias);
            this.tpLista.Location = new System.Drawing.Point(4, 26);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpLista.Size = new System.Drawing.Size(1012, 508);
            this.tpLista.TabIndex = 0;
            this.tpLista.Text = "Lista";
            this.tpLista.UseVisualStyleBackColor = true;
            // 
            // dgvAgencias
            // 
            this.dgvAgencias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAgencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgencias.Location = new System.Drawing.Point(3, 3);
            this.dgvAgencias.Name = "dgvAgencias";
            this.dgvAgencias.Size = new System.Drawing.Size(1006, 502);
            this.dgvAgencias.TabIndex = 0;
            // 
            // tpAgencias
            // 
            this.tpAgencias.Location = new System.Drawing.Point(4, 26);
            this.tpAgencias.Name = "tpAgencias";
            this.tpAgencias.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgencias.Size = new System.Drawing.Size(1012, 508);
            this.tpAgencias.TabIndex = 1;
            this.tpAgencias.Text = "Mapa";
            this.tpAgencias.UseVisualStyleBackColor = true;
            // 
            // TelaBuscarAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "TelaBuscarAgencia";
            this.Text = "TelaBuscarAgencia";
            this.p_Content.ResumeLayout(false);
            this.tcAtendimento.ResumeLayout(false);
            this.tpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAtendimento;
        private System.Windows.Forms.TabPage tpLista;
        private System.Windows.Forms.TabPage tpAgencias;
        private System.Windows.Forms.DataGridView dgvAgencias;
    }
}