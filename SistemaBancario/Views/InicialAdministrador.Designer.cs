namespace SistemaBancario.Views
{
    partial class InicialAdministrador
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
            this.btn_AdicionarCliente = new System.Windows.Forms.Button();
            this.btn_ConsultarCliente = new System.Windows.Forms.Button();
            this.btn_AlterarCliente = new System.Windows.Forms.Button();
            this.btn_ListarClientes = new System.Windows.Forms.Button();
            this.btn_RemoverCliente = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.btn_RemoverCliente);
            this.p_Content.Controls.Add(this.btn_ListarClientes);
            this.p_Content.Controls.Add(this.btn_AlterarCliente);
            this.p_Content.Controls.Add(this.btn_ConsultarCliente);
            this.p_Content.Controls.Add(this.btn_AdicionarCliente);
            // 
            // btn_AdicionarCliente
            // 
            this.btn_AdicionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_AdicionarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AdicionarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdicionarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AdicionarCliente.Image = global::SistemaBancario.Properties.Resources.add;
            this.btn_AdicionarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AdicionarCliente.Location = new System.Drawing.Point(301, 135);
            this.btn_AdicionarCliente.Name = "btn_AdicionarCliente";
            this.btn_AdicionarCliente.Size = new System.Drawing.Size(156, 136);
            this.btn_AdicionarCliente.TabIndex = 0;
            this.btn_AdicionarCliente.Text = "ADICIONAR CLIENTE";
            this.btn_AdicionarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AdicionarCliente.UseVisualStyleBackColor = false;
            this.btn_AdicionarCliente.Click += new System.EventHandler(this.btn_AdicionarCliente_Click);
            // 
            // btn_ConsultarCliente
            // 
            this.btn_ConsultarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_ConsultarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConsultarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ConsultarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ConsultarCliente.Image = global::SistemaBancario.Properties.Resources.magnifying_glass;
            this.btn_ConsultarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ConsultarCliente.Location = new System.Drawing.Point(473, 135);
            this.btn_ConsultarCliente.Name = "btn_ConsultarCliente";
            this.btn_ConsultarCliente.Size = new System.Drawing.Size(156, 136);
            this.btn_ConsultarCliente.TabIndex = 1;
            this.btn_ConsultarCliente.Text = "CONSULTAR CLIENTE";
            this.btn_ConsultarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ConsultarCliente.UseVisualStyleBackColor = false;
            // 
            // btn_AlterarCliente
            // 
            this.btn_AlterarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_AlterarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AlterarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_AlterarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AlterarCliente.Image = global::SistemaBancario.Properties.Resources.pencil_edit_button;
            this.btn_AlterarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AlterarCliente.Location = new System.Drawing.Point(644, 135);
            this.btn_AlterarCliente.Name = "btn_AlterarCliente";
            this.btn_AlterarCliente.Size = new System.Drawing.Size(156, 136);
            this.btn_AlterarCliente.TabIndex = 2;
            this.btn_AlterarCliente.Text = "ALTERAR CLIENTE";
            this.btn_AlterarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AlterarCliente.UseVisualStyleBackColor = false;
            // 
            // btn_ListarClientes
            // 
            this.btn_ListarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_ListarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ListarClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ListarClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ListarClientes.Image = global::SistemaBancario.Properties.Resources.list;
            this.btn_ListarClientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ListarClientes.Location = new System.Drawing.Point(386, 293);
            this.btn_ListarClientes.Name = "btn_ListarClientes";
            this.btn_ListarClientes.Size = new System.Drawing.Size(156, 136);
            this.btn_ListarClientes.TabIndex = 3;
            this.btn_ListarClientes.Text = "LISTAR CLIENTES";
            this.btn_ListarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ListarClientes.UseVisualStyleBackColor = false;
            // 
            // btn_RemoverCliente
            // 
            this.btn_RemoverCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_RemoverCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemoverCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_RemoverCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_RemoverCliente.Image = global::SistemaBancario.Properties.Resources.garbage;
            this.btn_RemoverCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_RemoverCliente.Location = new System.Drawing.Point(557, 293);
            this.btn_RemoverCliente.Name = "btn_RemoverCliente";
            this.btn_RemoverCliente.Size = new System.Drawing.Size(156, 136);
            this.btn_RemoverCliente.TabIndex = 4;
            this.btn_RemoverCliente.Text = "REMOVER CLIENTE";
            this.btn_RemoverCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_RemoverCliente.UseVisualStyleBackColor = false;
            // 
            // InicialAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "InicialAdministrador";
            this.p_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AdicionarCliente;
        private System.Windows.Forms.Button btn_RemoverCliente;
        private System.Windows.Forms.Button btn_ListarClientes;
        private System.Windows.Forms.Button btn_AlterarCliente;
        private System.Windows.Forms.Button btn_ConsultarCliente;
    }
}
