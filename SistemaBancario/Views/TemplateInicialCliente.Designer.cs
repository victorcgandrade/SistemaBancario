using Main;
using System;

namespace SistemaBancario.Views
{
    partial class TemplateInicialCliente
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
            this.components = new System.ComponentModel.Container();
            this.p_Footer = new System.Windows.Forms.Panel();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.pb_IconeUsuario = new System.Windows.Forms.PictureBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lb_NomeAdmin = new System.Windows.Forms.Label();
            this.p_SideMenu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Atendimento = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_LinkAtivo = new System.Windows.Forms.Panel();
            this.btn_Pagamentos = new System.Windows.Forms.Button();
            this.btn_Extrato = new System.Windows.Forms.Button();
            this.btn_AgendamentoSaque = new System.Windows.Forms.Button();
            this.btn_Investimentos = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Tranferencias = new System.Windows.Forms.Button();
            this.p_Header = new System.Windows.Forms.Panel();
            this.lb_Versao = new System.Windows.Forms.Label();
            this.lb_DataHoraAtual = new System.Windows.Forms.Label();
            this.lb_DuvidasApp = new System.Windows.Forms.Label();
            this.p_Content = new System.Windows.Forms.Panel();
            this.toolTipSaldo = new System.Windows.Forms.ToolTip(this.components);
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
            this.p_Footer.Controls.Add(this.btnSaldo);
            this.p_Footer.Controls.Add(this.pb_IconeUsuario);
            this.p_Footer.Controls.Add(this.btn_Sair);
            this.p_Footer.Controls.Add(this.lb_NomeAdmin);
            this.p_Footer.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Footer.Location = new System.Drawing.Point(215, 0);
            this.p_Footer.Name = "p_Footer";
            this.p_Footer.Size = new System.Drawing.Size(1110, 43);
            this.p_Footer.TabIndex = 12;
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.btnSaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaldo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaldo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaldo.Location = new System.Drawing.Point(920, 8);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(91, 29);
            this.btnSaldo.TabIndex = 4;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // pb_IconeUsuario
            // 
            this.pb_IconeUsuario.Image = global::SistemaBancario.Properties.Resources.usuario;
            this.pb_IconeUsuario.Location = new System.Drawing.Point(753, 4);
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
            // lb_NomeAdmin
            // 
            this.lb_NomeAdmin.AutoSize = true;
            this.lb_NomeAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.lb_NomeAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeAdmin.ForeColor = System.Drawing.SystemColors.Menu;
            this.lb_NomeAdmin.Location = new System.Drawing.Point(795, 14);
            this.lb_NomeAdmin.Name = "lb_NomeAdmin";
            this.lb_NomeAdmin.Size = new System.Drawing.Size(121, 17);
            this.lb_NomeAdmin.TabIndex = 1;
            this.lb_NomeAdmin.Text = "Olá, Carlos Alberto";
            // 
            // p_SideMenu
            // 
            this.p_SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.p_SideMenu.Controls.Add(this.panel5);
            this.p_SideMenu.Controls.Add(this.btn_Atendimento);
            this.p_SideMenu.Controls.Add(this.panel4);
            this.p_SideMenu.Controls.Add(this.panel3);
            this.p_SideMenu.Controls.Add(this.panel2);
            this.p_SideMenu.Controls.Add(this.panel1);
            this.p_SideMenu.Controls.Add(this.p_LinkAtivo);
            this.p_SideMenu.Controls.Add(this.btn_Pagamentos);
            this.p_SideMenu.Controls.Add(this.btn_Extrato);
            this.p_SideMenu.Controls.Add(this.btn_AgendamentoSaque);
            this.p_SideMenu.Controls.Add(this.btn_Investimentos);
            this.p_SideMenu.Controls.Add(this.pb_Logo);
            this.p_SideMenu.Controls.Add(this.btn_Tranferencias);
            this.p_SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_SideMenu.Location = new System.Drawing.Point(0, 0);
            this.p_SideMenu.Name = "p_SideMenu";
            this.p_SideMenu.Size = new System.Drawing.Size(215, 667);
            this.p_SideMenu.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panel5.Location = new System.Drawing.Point(205, 523);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 45);
            this.panel5.TabIndex = 14;
            // 
            // btn_Atendimento
            // 
            this.btn_Atendimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btn_Atendimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Atendimento.FlatAppearance.BorderSize = 0;
            this.btn_Atendimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Atendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atendimento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Atendimento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Atendimento.Image = global::SistemaBancario.Properties.Resources.questions_circular_button_1;
            this.btn_Atendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Atendimento.Location = new System.Drawing.Point(-3, 523);
            this.btn_Atendimento.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Atendimento.Name = "btn_Atendimento";
            this.btn_Atendimento.Size = new System.Drawing.Size(218, 45);
            this.btn_Atendimento.TabIndex = 15;
            this.btn_Atendimento.Text = "   Atendimento";
            this.btn_Atendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Atendimento.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panel4.Location = new System.Drawing.Point(205, 465);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 45);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panel3.Location = new System.Drawing.Point(205, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 45);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panel2.Location = new System.Drawing.Point(205, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 45);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.panel1.Location = new System.Drawing.Point(205, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 45);
            this.panel1.TabIndex = 3;
            // 
            // p_LinkAtivo
            // 
            this.p_LinkAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.p_LinkAtivo.Location = new System.Drawing.Point(205, 241);
            this.p_LinkAtivo.Name = "p_LinkAtivo";
            this.p_LinkAtivo.Size = new System.Drawing.Size(10, 45);
            this.p_LinkAtivo.TabIndex = 2;
            // 
            // btn_Pagamentos
            // 
            this.btn_Pagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btn_Pagamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pagamentos.FlatAppearance.BorderSize = 0;
            this.btn_Pagamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Pagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pagamentos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Pagamentos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Pagamentos.Image = global::SistemaBancario.Properties.Resources.bill;
            this.btn_Pagamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Pagamentos.Location = new System.Drawing.Point(-3, 297);
            this.btn_Pagamentos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Pagamentos.Name = "btn_Pagamentos";
            this.btn_Pagamentos.Size = new System.Drawing.Size(218, 45);
            this.btn_Pagamentos.TabIndex = 12;
            this.btn_Pagamentos.Text = "   Pagamentos";
            this.btn_Pagamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Pagamentos.UseVisualStyleBackColor = false;
            this.btn_Pagamentos.Click += new System.EventHandler(this.btn_Pagamentos_Click);
            // 
            // btn_Extrato
            // 
            this.btn_Extrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btn_Extrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Extrato.FlatAppearance.BorderSize = 0;
            this.btn_Extrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Extrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Extrato.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Extrato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Extrato.Image = global::SistemaBancario.Properties.Resources.voucher;
            this.btn_Extrato.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Extrato.Location = new System.Drawing.Point(-35, 353);
            this.btn_Extrato.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Extrato.Name = "btn_Extrato";
            this.btn_Extrato.Size = new System.Drawing.Size(250, 45);
            this.btn_Extrato.TabIndex = 11;
            this.btn_Extrato.Text = "   Extrato";
            this.btn_Extrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Extrato.UseVisualStyleBackColor = false;
            // 
            // btn_AgendamentoSaque
            // 
            this.btn_AgendamentoSaque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btn_AgendamentoSaque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgendamentoSaque.FlatAppearance.BorderSize = 0;
            this.btn_AgendamentoSaque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_AgendamentoSaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgendamentoSaque.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_AgendamentoSaque.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AgendamentoSaque.Image = global::SistemaBancario.Properties.Resources.atm__1_;
            this.btn_AgendamentoSaque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AgendamentoSaque.Location = new System.Drawing.Point(-35, 409);
            this.btn_AgendamentoSaque.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AgendamentoSaque.Name = "btn_AgendamentoSaque";
            this.btn_AgendamentoSaque.Size = new System.Drawing.Size(247, 45);
            this.btn_AgendamentoSaque.TabIndex = 10;
            this.btn_AgendamentoSaque.Text = "     Saque";
            this.btn_AgendamentoSaque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AgendamentoSaque.UseVisualStyleBackColor = false;
            this.btn_AgendamentoSaque.Click += new System.EventHandler(this.btn_AgendamentoSaque_Click);
            // 
            // btn_Investimentos
            // 
            this.btn_Investimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btn_Investimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Investimentos.FlatAppearance.BorderSize = 0;
            this.btn_Investimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Investimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Investimentos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Investimentos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Investimentos.Image = global::SistemaBancario.Properties.Resources.profits;
            this.btn_Investimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Investimentos.Location = new System.Drawing.Point(0, 465);
            this.btn_Investimentos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Investimentos.Name = "btn_Investimentos";
            this.btn_Investimentos.Size = new System.Drawing.Size(215, 45);
            this.btn_Investimentos.TabIndex = 9;
            this.btn_Investimentos.Text = "    Investimentos";
            this.btn_Investimentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Investimentos.UseVisualStyleBackColor = false;
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
            // btn_Tranferencias
            // 
            this.btn_Tranferencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btn_Tranferencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tranferencias.FlatAppearance.BorderSize = 0;
            this.btn_Tranferencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.btn_Tranferencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tranferencias.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Tranferencias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Tranferencias.Image = global::SistemaBancario.Properties.Resources.transferencia;
            this.btn_Tranferencias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tranferencias.Location = new System.Drawing.Point(0, 241);
            this.btn_Tranferencias.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Tranferencias.Name = "btn_Tranferencias";
            this.btn_Tranferencias.Size = new System.Drawing.Size(215, 45);
            this.btn_Tranferencias.TabIndex = 13;
            this.btn_Tranferencias.Text = "   Transferência";
            this.btn_Tranferencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Tranferencias.UseVisualStyleBackColor = false;
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
            // 
            // TemplateInicialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Controls.Add(this.p_Content);
            this.Controls.Add(this.p_Footer);
            this.Controls.Add(this.p_SideMenu);
            this.Controls.Add(this.p_Header);
            this.Name = "TemplateInicialCliente";
            this.Text = "A&A: Banco Digital";
            this.p_Footer.ResumeLayout(false);
            this.p_Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_IconeUsuario)).EndInit();
            this.p_SideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.p_Header.ResumeLayout(false);
            this.p_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin tl = new TelaLogin();
            tl.Show();
        }

        #endregion
        private System.Windows.Forms.PictureBox pb_IconeUsuario;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lb_NomeAdmin;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lb_DataHoraAtual;
        private System.Windows.Forms.Label lb_DuvidasApp;
        private System.Windows.Forms.Label lb_Versao;
        protected System.Windows.Forms.Panel p_Content;
        private System.Windows.Forms.Panel p_Footer;
        private System.Windows.Forms.Panel p_SideMenu;
        private System.Windows.Forms.Panel p_Header;
        protected System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel p_LinkAtivo;
        protected System.Windows.Forms.Button btn_Investimentos;
        protected System.Windows.Forms.Button btn_AgendamentoSaque;
        protected System.Windows.Forms.Button btn_Tranferencias;
        protected System.Windows.Forms.Button btn_Pagamentos;
        protected System.Windows.Forms.Button btn_Extrato;
        protected System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Button btn_Atendimento;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.ToolTip toolTipSaldo;
    }
}
