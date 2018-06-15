namespace SistemaBancario.Views
{
    partial class TemplateInicialAdministrador
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
            this.p_Footer = new System.Windows.Forms.Panel();
            this.pb_IconeUsuario = new System.Windows.Forms.PictureBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lb_LoginAdmin = new System.Windows.Forms.Label();
            this.lb_NomeAdmin = new System.Windows.Forms.Label();
            this.p_SideMenu = new System.Windows.Forms.Panel();
            this.p_LinkAtivo = new System.Windows.Forms.Panel();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Contas = new System.Windows.Forms.Button();
            this.btn_Aplicacoes = new System.Windows.Forms.Button();
            this.btn_Agencias = new System.Windows.Forms.Button();
            this.btn_LogDados = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.p_Header = new System.Windows.Forms.Panel();
            this.lb_Versao = new System.Windows.Forms.Label();
            this.lb_DataHoraAtual = new System.Windows.Forms.Label();
            this.lb_DuvidasApp = new System.Windows.Forms.Label();
            this.p_Content = new System.Windows.Forms.Panel();
            this.p_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconeUsuario)).BeginInit();
            this.p_SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.p_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Footer
            // 
            this.p_Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.p_Footer.Controls.Add(this.pb_IconeUsuario);
            this.p_Footer.Controls.Add(this.btn_Sair);
            this.p_Footer.Controls.Add(this.lb_LoginAdmin);
            this.p_Footer.Controls.Add(this.lb_NomeAdmin);
            this.p_Footer.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Footer.Location = new System.Drawing.Point(215, 0);
            this.p_Footer.Name = "p_Footer";
            this.p_Footer.Size = new System.Drawing.Size(1110, 43);
            this.p_Footer.TabIndex = 12;
            // 
            // pb_IconeUsuario
            // 
            this.pb_IconeUsuario.Image = global::SistemaBancario.Properties.Resources.usuario;
            this.pb_IconeUsuario.Location = new System.Drawing.Point(849, 6);
            this.pb_IconeUsuario.Name = "pb_IconeUsuario";
            this.pb_IconeUsuario.Size = new System.Drawing.Size(36, 36);
            this.pb_IconeUsuario.TabIndex = 0;
            this.pb_IconeUsuario.TabStop = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Sair.Location = new System.Drawing.Point(1017, 8);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(61, 29);
            this.btn_Sair.TabIndex = 0;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lb_LoginAdmin
            // 
            this.lb_LoginAdmin.AutoSize = true;
            this.lb_LoginAdmin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoginAdmin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lb_LoginAdmin.Location = new System.Drawing.Point(911, 25);
            this.lb_LoginAdmin.Name = "lb_LoginAdmin";
            this.lb_LoginAdmin.Size = new System.Drawing.Size(49, 13);
            this.lb_LoginAdmin.TabIndex = 2;
            this.lb_LoginAdmin.Text = "0211547";
            // 
            // lb_NomeAdmin
            // 
            this.lb_NomeAdmin.AutoSize = true;
            this.lb_NomeAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.lb_NomeAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeAdmin.ForeColor = System.Drawing.SystemColors.Menu;
            this.lb_NomeAdmin.Location = new System.Drawing.Point(891, 8);
            this.lb_NomeAdmin.Name = "lb_NomeAdmin";
            this.lb_NomeAdmin.Size = new System.Drawing.Size(94, 17);
            this.lb_NomeAdmin.TabIndex = 1;
            this.lb_NomeAdmin.Text = "Carlos Alberto";
            // 
            // p_SideMenu
            // 
            this.p_SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.p_SideMenu.Controls.Add(this.p_LinkAtivo);
            this.p_SideMenu.Controls.Add(this.btn_Clientes);
            this.p_SideMenu.Controls.Add(this.btn_Contas);
            this.p_SideMenu.Controls.Add(this.btn_Aplicacoes);
            this.p_SideMenu.Controls.Add(this.btn_Agencias);
            this.p_SideMenu.Controls.Add(this.btn_LogDados);
            this.p_SideMenu.Controls.Add(this.pb_Logo);
            this.p_SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_SideMenu.Location = new System.Drawing.Point(0, 0);
            this.p_SideMenu.Name = "p_SideMenu";
            this.p_SideMenu.Size = new System.Drawing.Size(215, 667);
            this.p_SideMenu.TabIndex = 11;
            // 
            // p_LinkAtivo
            // 
            this.p_LinkAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.p_LinkAtivo.Location = new System.Drawing.Point(205, 241);
            this.p_LinkAtivo.Name = "p_LinkAtivo";
            this.p_LinkAtivo.Size = new System.Drawing.Size(10, 45);
            this.p_LinkAtivo.TabIndex = 2;
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clientes.FlatAppearance.BorderSize = 0;
            this.btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Clientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Clientes.Image = global::SistemaBancario.Properties.Resources.clientes;
            this.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clientes.Location = new System.Drawing.Point(-32, 241);
            this.btn_Clientes.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(247, 45);
            this.btn_Clientes.TabIndex = 13;
            this.btn_Clientes.Text = "  Clientes";
            this.btn_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Clientes.UseVisualStyleBackColor = false;
            // 
            // btn_Contas
            // 
            this.btn_Contas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btn_Contas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Contas.FlatAppearance.BorderSize = 0;
            this.btn_Contas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Contas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Contas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Contas.Image = global::SistemaBancario.Properties.Resources.credit_card;
            this.btn_Contas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Contas.Location = new System.Drawing.Point(-32, 297);
            this.btn_Contas.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Contas.Name = "btn_Contas";
            this.btn_Contas.Size = new System.Drawing.Size(247, 45);
            this.btn_Contas.TabIndex = 12;
            this.btn_Contas.Text = "  Contas";
            this.btn_Contas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Contas.UseVisualStyleBackColor = false;
            this.btn_Contas.Click += new System.EventHandler(this.btn_Contas_Click);
            // 
            // btn_Aplicacoes
            // 
            this.btn_Aplicacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btn_Aplicacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aplicacoes.FlatAppearance.BorderSize = 0;
            this.btn_Aplicacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Aplicacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aplicacoes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Aplicacoes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Aplicacoes.Image = global::SistemaBancario.Properties.Resources.aplicacoes;
            this.btn_Aplicacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Aplicacoes.Location = new System.Drawing.Point(-12, 353);
            this.btn_Aplicacoes.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Aplicacoes.Name = "btn_Aplicacoes";
            this.btn_Aplicacoes.Size = new System.Drawing.Size(227, 45);
            this.btn_Aplicacoes.TabIndex = 11;
            this.btn_Aplicacoes.Text = "  Aplicações";
            this.btn_Aplicacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Aplicacoes.UseVisualStyleBackColor = false;
            // 
            // btn_Agencias
            // 
            this.btn_Agencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btn_Agencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agencias.FlatAppearance.BorderSize = 0;
            this.btn_Agencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Agencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agencias.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Agencias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Agencias.Image = global::SistemaBancario.Properties.Resources.agencias;
            this.btn_Agencias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agencias.Location = new System.Drawing.Point(-23, 409);
            this.btn_Agencias.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Agencias.Name = "btn_Agencias";
            this.btn_Agencias.Size = new System.Drawing.Size(235, 45);
            this.btn_Agencias.TabIndex = 10;
            this.btn_Agencias.Text = "  Agências";
            this.btn_Agencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agencias.UseVisualStyleBackColor = false;
            this.btn_Agencias.Click += new System.EventHandler(this.pb_IconeAgencias_Click);
            // 
            // btn_LogDados
            // 
            this.btn_LogDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btn_LogDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogDados.FlatAppearance.BorderSize = 0;
            this.btn_LogDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_LogDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogDados.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_LogDados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_LogDados.Image = global::SistemaBancario.Properties.Resources.folder;
            this.btn_LogDados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LogDados.Location = new System.Drawing.Point(0, 465);
            this.btn_LogDados.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LogDados.Name = "btn_LogDados";
            this.btn_LogDados.Size = new System.Drawing.Size(215, 45);
            this.btn_LogDados.TabIndex = 9;
            this.btn_LogDados.Text = "  Log de Dados";
            this.btn_LogDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LogDados.UseVisualStyleBackColor = false;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = global::SistemaBancario.Properties.Resources.logo;
            this.pb_Logo.Location = new System.Drawing.Point(29, 46);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(151, 149);
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // p_Header
            // 
            this.p_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.p_Header.Controls.Add(this.lb_Versao);
            this.p_Header.Controls.Add(this.lb_DataHoraAtual);
            this.p_Header.Controls.Add(this.lb_DuvidasApp);
            this.p_Header.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_Header.Location = new System.Drawing.Point(0, 667);
            this.p_Header.Name = "p_Header";
            this.p_Header.Size = new System.Drawing.Size(1325, 27);
            this.p_Header.TabIndex = 10;
            // 
            // lb_Versao
            // 
            this.lb_Versao.AutoSize = true;
            this.lb_Versao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Versao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Versao.Location = new System.Drawing.Point(11, 6);
            this.lb_Versao.Name = "lb_Versao";
            this.lb_Versao.Size = new System.Drawing.Size(63, 15);
            this.lb_Versao.TabIndex = 3;
            this.lb_Versao.Text = "Versão 0.1 ";
            // 
            // lb_DataHoraAtual
            // 
            this.lb_DataHoraAtual.AutoSize = true;
            this.lb_DataHoraAtual.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DataHoraAtual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_DataHoraAtual.Location = new System.Drawing.Point(74, 6);
            this.lb_DataHoraAtual.Name = "lb_DataHoraAtual";
            this.lb_DataHoraAtual.Size = new System.Drawing.Size(106, 15);
            this.lb_DataHoraAtual.TabIndex = 1;
            this.lb_DataHoraAtual.Text = "22/05/2018 12:55 ";
            // 
            // lb_DuvidasApp
            // 
            this.lb_DuvidasApp.AutoSize = true;
            this.lb_DuvidasApp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DuvidasApp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_DuvidasApp.Location = new System.Drawing.Point(1147, 6);
            this.lb_DuvidasApp.Name = "lb_DuvidasApp";
            this.lb_DuvidasApp.Size = new System.Drawing.Size(146, 15);
            this.lb_DuvidasApp.TabIndex = 2;
            this.lb_DuvidasApp.Text = "Dúvidas sobre o aplicativo";
            // 
            // p_Content
            // 
            this.p_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.p_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Content.Location = new System.Drawing.Point(215, 43);
            this.p_Content.Name = "p_Content";
            this.p_Content.Size = new System.Drawing.Size(1110, 624);
            this.p_Content.TabIndex = 13;
            this.p_Content.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Content_Paint);
            // 
            // TemplateInicialAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Controls.Add(this.p_Content);
            this.Controls.Add(this.p_Footer);
            this.Controls.Add(this.p_SideMenu);
            this.Controls.Add(this.p_Header);
            this.Name = "TemplateInicialAdministrador";
            this.Text = "Gerenciar Administrador";
            this.p_Footer.ResumeLayout(false);
            this.p_Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconeUsuario)).EndInit();
            this.p_SideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.p_Header.ResumeLayout(false);
            this.p_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_IconeUsuario;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lb_LoginAdmin;
        private System.Windows.Forms.Label lb_NomeAdmin;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Panel p_LinkAtivo;
        private System.Windows.Forms.Label lb_DataHoraAtual;
        private System.Windows.Forms.Label lb_DuvidasApp;
        private System.Windows.Forms.Label lb_Versao;
        protected System.Windows.Forms.Panel p_Content;
        private System.Windows.Forms.Panel p_Footer;
        private System.Windows.Forms.Panel p_SideMenu;
        private System.Windows.Forms.Panel p_Header;
        private System.Windows.Forms.Button btn_LogDados;
        private System.Windows.Forms.Button btn_Agencias;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Contas;
        private System.Windows.Forms.Button btn_Aplicacoes;
    }
}
