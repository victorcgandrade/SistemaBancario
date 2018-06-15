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
            this.btnAdicionarConta = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.button4);
            this.p_Content.Controls.Add(this.button3);
            this.p_Content.Controls.Add(this.button2);
            this.p_Content.Controls.Add(this.button6);
            this.p_Content.Controls.Add(this.btnAdicionarConta);
            // 
            // btnAdicionarConta
            // 
            this.btnAdicionarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnAdicionarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarConta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarConta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionarConta.Image = global::SistemaBancario.Properties.Resources.add;
            this.btnAdicionarConta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarConta.Location = new System.Drawing.Point(301, 135);
            this.btnAdicionarConta.Name = "btnAdicionarConta";
            this.btnAdicionarConta.Size = new System.Drawing.Size(156, 136);
            this.btnAdicionarConta.TabIndex = 0;
            this.btnAdicionarConta.Text = "ADICIONAR CONTA";
            this.btnAdicionarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionarConta.UseVisualStyleBackColor = false;
            this.btnAdicionarConta.Click += new System.EventHandler(this.btnAdicionarConta_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Image = global::SistemaBancario.Properties.Resources.magnifying_glass;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.Location = new System.Drawing.Point(476, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 136);
            this.button6.TabIndex = 5;
            this.button6.Text = "CONSULTAR CONTA";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::SistemaBancario.Properties.Resources.pencil_edit_button;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(651, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 136);
            this.button2.TabIndex = 6;
            this.button2.Text = "ALTERAR CONTA";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = global::SistemaBancario.Properties.Resources.list;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(387, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 136);
            this.button3.TabIndex = 7;
            this.button3.Text = "LISTAR CONTAS";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Image = global::SistemaBancario.Properties.Resources.garbage;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(566, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 136);
            this.button4.TabIndex = 8;
            this.button4.Text = "REMOVER CONTA";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
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

        private System.Windows.Forms.Button btnAdicionarConta;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
    }
}