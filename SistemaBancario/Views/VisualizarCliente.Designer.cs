namespace SistemaBancario.Views
{
    partial class VisualizarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarCliente));
            this.lb_TituloAdicionarCliente = new System.Windows.Forms.Label();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.pb_IconeCliente = new System.Windows.Forms.PictureBox();
            this.lb_NomeSobrenome = new System.Windows.Forms.Label();
            this.dgv_VisualizarCliente = new System.Windows.Forms.DataGridView();
            this.p_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconeCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.dgv_VisualizarCliente);
            this.p_Content.Controls.Add(this.lb_NomeSobrenome);
            this.p_Content.Controls.Add(this.pb_IconeCliente);
            this.p_Content.Controls.Add(this.btn_Alterar);
            this.p_Content.Controls.Add(this.btn_Remover);
            // 
            // lb_TituloAdicionarCliente
            // 
            this.lb_TituloAdicionarCliente.AutoSize = true;
            this.lb_TituloAdicionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lb_TituloAdicionarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TituloAdicionarCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lb_TituloAdicionarCliente.Location = new System.Drawing.Point(247, 74);
            this.lb_TituloAdicionarCliente.Name = "lb_TituloAdicionarCliente";
            this.lb_TituloAdicionarCliente.Size = new System.Drawing.Size(169, 21);
            this.lb_TituloAdicionarCliente.TabIndex = 78;
            this.lb_TituloAdicionarCliente.Text = "VISUALIZAR CLIENTE";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btn_Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alterar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Alterar.Location = new System.Drawing.Point(699, 94);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(90, 29);
            this.btn_Alterar.TabIndex = 86;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.btn_Remover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Remover.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remover.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Remover.Location = new System.Drawing.Point(795, 94);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(90, 29);
            this.btn_Remover.TabIndex = 87;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // pb_IconeCliente
            // 
            this.pb_IconeCliente.Image = ((System.Drawing.Image)(resources.GetObject("pb_IconeCliente.Image")));
            this.pb_IconeCliente.Location = new System.Drawing.Point(219, 94);
            this.pb_IconeCliente.Name = "pb_IconeCliente";
            this.pb_IconeCliente.Size = new System.Drawing.Size(37, 29);
            this.pb_IconeCliente.TabIndex = 88;
            this.pb_IconeCliente.TabStop = false;
            // 
            // lb_NomeSobrenome
            // 
            this.lb_NomeSobrenome.AutoSize = true;
            this.lb_NomeSobrenome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeSobrenome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lb_NomeSobrenome.Location = new System.Drawing.Point(262, 103);
            this.lb_NomeSobrenome.Name = "lb_NomeSobrenome";
            this.lb_NomeSobrenome.Size = new System.Drawing.Size(191, 20);
            this.lb_NomeSobrenome.TabIndex = 89;
            this.lb_NomeSobrenome.Text = "Primeiro Nome Sobrenome";
            // 
            // dgv_VisualizarCliente
            // 
            this.dgv_VisualizarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_VisualizarCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_VisualizarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VisualizarCliente.Location = new System.Drawing.Point(330, 167);
            this.dgv_VisualizarCliente.Name = "dgv_VisualizarCliente";
            this.dgv_VisualizarCliente.Size = new System.Drawing.Size(448, 400);
            this.dgv_VisualizarCliente.TabIndex = 90;
            // 
            // VisualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Controls.Add(this.lb_TituloAdicionarCliente);
            this.Name = "VisualizarCliente";
            this.Controls.SetChildIndex(this.p_Content, 0);
            this.Controls.SetChildIndex(this.lb_TituloAdicionarCliente, 0);
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconeCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TituloAdicionarCliente;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Label lb_NomeSobrenome;
        private System.Windows.Forms.PictureBox pb_IconeCliente;
        private System.Windows.Forms.DataGridView dgv_VisualizarCliente;
    }
}
