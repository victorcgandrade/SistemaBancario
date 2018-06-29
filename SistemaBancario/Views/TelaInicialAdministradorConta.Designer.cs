namespace SistemaBancario.Views
{
    partial class TelaInicialAdministradorConta
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
            this.btn_ConsultarConta = new System.Windows.Forms.Button();
            this.btn_ListarContas = new System.Windows.Forms.Button();
            this.btn_AdicionarConta = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.btn_ListarContas);
            this.p_Content.Controls.Add(this.btn_ConsultarConta);
            this.p_Content.Controls.Add(this.btn_AdicionarConta);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
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
            // btn_ConsultarConta
            // 
            this.btn_ConsultarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_ConsultarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConsultarConta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ConsultarConta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ConsultarConta.Image = global::SistemaBancario.Properties.Resources.magnifying_glass;
            this.btn_ConsultarConta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ConsultarConta.Location = new System.Drawing.Point(471, 219);
            this.btn_ConsultarConta.Name = "btn_ConsultarConta";
            this.btn_ConsultarConta.Size = new System.Drawing.Size(156, 136);
            this.btn_ConsultarConta.TabIndex = 5;
            this.btn_ConsultarConta.Text = "CONSULTAR CONTA";
            this.btn_ConsultarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ConsultarConta.UseVisualStyleBackColor = false;
            this.btn_ConsultarConta.Click += new System.EventHandler(this.btn_ConsultarConta_Click);
            // 
            // btn_ListarContas
            // 
            this.btn_ListarContas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_ListarContas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ListarContas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ListarContas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ListarContas.Image = global::SistemaBancario.Properties.Resources.list;
            this.btn_ListarContas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ListarContas.Location = new System.Drawing.Point(649, 219);
            this.btn_ListarContas.Name = "btn_ListarContas";
            this.btn_ListarContas.Size = new System.Drawing.Size(156, 136);
            this.btn_ListarContas.TabIndex = 7;
            this.btn_ListarContas.Text = "LISTAR CONTAS";
            this.btn_ListarContas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ListarContas.UseVisualStyleBackColor = false;
            this.btn_ListarContas.Click += new System.EventHandler(this.btn_ListarContas_Click);
            // 
            // btn_AdicionarConta
            // 
            this.btn_AdicionarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_AdicionarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AdicionarConta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_AdicionarConta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AdicionarConta.Image = global::SistemaBancario.Properties.Resources.add;
            this.btn_AdicionarConta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AdicionarConta.Location = new System.Drawing.Point(296, 219);
            this.btn_AdicionarConta.Name = "btn_AdicionarConta";
            this.btn_AdicionarConta.Size = new System.Drawing.Size(156, 136);
            this.btn_AdicionarConta.TabIndex = 0;
            this.btn_AdicionarConta.Text = "ADICIONAR CONTA";
            this.btn_AdicionarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AdicionarConta.UseVisualStyleBackColor = false;
            this.btn_AdicionarConta.Click += new System.EventHandler(this.btn_AdicionarConta_Click);
            // 
            // TelaInicialAdministradorConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "TelaInicialAdministradorConta";
            this.Text = "TelaInicialAdministradorConta";
            this.p_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ListarContas;
        private System.Windows.Forms.Button btn_ConsultarConta;
        private System.Windows.Forms.Button btn_AdicionarConta;
    }
}