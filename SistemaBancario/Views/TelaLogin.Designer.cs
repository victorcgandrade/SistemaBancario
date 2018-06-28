using System;

namespace Main
{
    partial class TelaLogin
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
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.cmbBoxTipoUser = new System.Windows.Forms.ComboBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.pnlDadosUser = new System.Windows.Forms.Panel();
            this.tlpDadosAdm = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.tlpDadosCliente = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxConta = new System.Windows.Forms.TextBox();
            this.txtBoxAgencia = new System.Windows.Forms.TextBox();
            this.picBoxIcone = new System.Windows.Forms.PictureBox();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMenu.SuspendLayout();
            this.pnlDadosUser.SuspendLayout();
            this.tlpDadosAdm.SuspendLayout();
            this.tlpDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMenu
            // 
            this.tlpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.tlpMenu.ColumnCount = 1;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMenu.Controls.Add(this.lblIdentificacao, 0, 1);
            this.tlpMenu.Controls.Add(this.cmbBoxTipoUser, 0, 2);
            this.tlpMenu.Controls.Add(this.btnAcessar, 0, 4);
            this.tlpMenu.Controls.Add(this.pnlDadosUser, 0, 3);
            this.tlpMenu.Controls.Add(this.picBoxIcone, 0, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlpMenu.Location = new System.Drawing.Point(723, 0);
            this.tlpMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 6;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(200, 580);
            this.tlpMenu.TabIndex = 0;
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacao.ForeColor = System.Drawing.Color.White;
            this.lblIdentificacao.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblIdentificacao.Location = new System.Drawing.Point(3, 155);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(194, 20);
            this.lblIdentificacao.TabIndex = 1;
            this.lblIdentificacao.Text = "Identificação";
            this.lblIdentificacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxTipoUser
            // 
            this.cmbBoxTipoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxTipoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxTipoUser.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxTipoUser.FormattingEnabled = true;
            this.cmbBoxTipoUser.Location = new System.Drawing.Point(3, 188);
            this.cmbBoxTipoUser.Name = "cmbBoxTipoUser";
            this.cmbBoxTipoUser.Size = new System.Drawing.Size(194, 23);
            this.cmbBoxTipoUser.TabIndex = 2;
            this.cmbBoxTipoUser.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTipoUser_SelectedIndexChanged_1);
            // 
            // btnAcessar
            // 
            this.btnAcessar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAcessar.Location = new System.Drawing.Point(62, 268);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(75, 23);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click_1);
            // 
            // pnlDadosUser
            // 
            this.pnlDadosUser.Controls.Add(this.tlpDadosAdm);
            this.pnlDadosUser.Controls.Add(this.tlpDadosCliente);
            this.pnlDadosUser.Location = new System.Drawing.Point(0, 220);
            this.pnlDadosUser.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDadosUser.Name = "pnlDadosUser";
            this.pnlDadosUser.Size = new System.Drawing.Size(200, 40);
            this.pnlDadosUser.TabIndex = 5;
            // 
            // tlpDadosAdm
            // 
            this.tlpDadosAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.tlpDadosAdm.ColumnCount = 2;
            this.tlpDadosAdm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDadosAdm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDadosAdm.Controls.Add(this.txtBoxLogin, 0, 0);
            this.tlpDadosAdm.Controls.Add(this.txtBoxSenha, 1, 0);
            this.tlpDadosAdm.Location = new System.Drawing.Point(0, 10);
            this.tlpDadosAdm.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDadosAdm.Name = "tlpDadosAdm";
            this.tlpDadosAdm.RowCount = 1;
            this.tlpDadosAdm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDadosAdm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDadosAdm.Size = new System.Drawing.Size(200, 30);
            this.tlpDadosAdm.TabIndex = 3;
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLogin.Location = new System.Drawing.Point(3, 3);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(94, 25);
            this.txtBoxLogin.TabIndex = 0;
            this.txtBoxLogin.Text = "Login";
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenha.Location = new System.Drawing.Point(103, 3);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(94, 25);
            this.txtBoxSenha.TabIndex = 1;
            this.txtBoxSenha.Text = "Senha";
            this.txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // tlpDadosCliente
            // 
            this.tlpDadosCliente.ColumnCount = 2;
            this.tlpDadosCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDadosCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDadosCliente.Controls.Add(this.txtBoxConta, 1, 0);
            this.tlpDadosCliente.Controls.Add(this.txtBoxAgencia, 0, 0);
            this.tlpDadosCliente.Location = new System.Drawing.Point(0, 11);
            this.tlpDadosCliente.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDadosCliente.Name = "tlpDadosCliente";
            this.tlpDadosCliente.RowCount = 1;
            this.tlpDadosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDadosCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpDadosCliente.Size = new System.Drawing.Size(200, 29);
            this.tlpDadosCliente.TabIndex = 4;
            // 
            // txtBoxConta
            // 
            this.txtBoxConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxConta.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConta.Location = new System.Drawing.Point(103, 3);
            this.txtBoxConta.Name = "txtBoxConta";
            this.txtBoxConta.Size = new System.Drawing.Size(94, 23);
            this.txtBoxConta.TabIndex = 1;
            this.txtBoxConta.Text = "Conta";
            // 
            // txtBoxAgencia
            // 
            this.txtBoxAgencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAgencia.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAgencia.Location = new System.Drawing.Point(3, 3);
            this.txtBoxAgencia.Name = "txtBoxAgencia";
            this.txtBoxAgencia.Size = new System.Drawing.Size(94, 23);
            this.txtBoxAgencia.TabIndex = 0;
            this.txtBoxAgencia.Text = "Agência";
            // 
            // picBoxIcone
            // 
            this.picBoxIcone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxIcone.Image = global::SistemaBancario.Properties.Resources.logo;
            this.picBoxIcone.Location = new System.Drawing.Point(26, 3);
            this.picBoxIcone.Name = "picBoxIcone";
            this.picBoxIcone.Size = new System.Drawing.Size(147, 144);
            this.picBoxIcone.TabIndex = 0;
            this.picBoxIcone.TabStop = false;
            // 
            // tlpFooter
            // 
            this.tlpFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.tlpFooter.ColumnCount = 2;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFooter.Location = new System.Drawing.Point(0, 552);
            this.tlpFooter.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpFooter.Size = new System.Drawing.Size(723, 28);
            this.tlpFooter.TabIndex = 1;
            // 
            // tlpHeader
            // 
            this.tlpHeader.BackColor = System.Drawing.Color.White;
            this.tlpHeader.ColumnCount = 2;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(723, 30);
            this.tlpHeader.TabIndex = 2;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 580);
            this.Controls.Add(this.tlpHeader);
            this.Controls.Add(this.tlpFooter);
            this.Controls.Add(this.tlpMenu);
            this.Name = "TelaLogin";
            this.ShowIcon = false;
            this.Text = "A&A Desktop";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.tlpMenu.ResumeLayout(false);
            this.tlpMenu.PerformLayout();
            this.pnlDadosUser.ResumeLayout(false);
            this.tlpDadosAdm.ResumeLayout(false);
            this.tlpDadosAdm.PerformLayout();
            this.tlpDadosCliente.ResumeLayout(false);
            this.tlpDadosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcone)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cmbBoxTipoUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.PictureBox picBoxIcone;
        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.ComboBox cmbBoxTipoUser;
        private System.Windows.Forms.TableLayoutPanel tlpDadosAdm;
        public System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Panel pnlDadosUser;
        private System.Windows.Forms.TableLayoutPanel tlpDadosCliente;
        private System.Windows.Forms.TextBox txtBoxConta;
        private System.Windows.Forms.TextBox txtBoxAgencia;
    }
}