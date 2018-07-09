namespace SistemaBancario.Views
{
    partial class TelaTransferencia
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
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.lblContaOrigem = new System.Windows.Forms.Label();
            this.lblContaDestino = new System.Windows.Forms.Label();
            this.txtBoxContaOrigem = new System.Windows.Forms.TextBox();
            this.txtBoxContaDestino = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbBoxTipo = new System.Windows.Forms.ComboBox();
            this.dtpDataTransferencia = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.pnlDadosOutro = new System.Windows.Forms.Panel();
            this.cmbBoxCodigo = new System.Windows.Forms.ComboBox();
            this.txtBoxAgenciaOutro = new System.Windows.Forms.TextBox();
            this.lblAgenciaOutro = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDadosOutroBanco = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblOutrosBancos = new System.Windows.Forms.Label();
            this.cmbEscolhaBanco = new System.Windows.Forms.ComboBox();
            this.p_Content.SuspendLayout();
            this.pnlDadosOutro.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Content
            // 
            this.p_Content.Controls.Add(this.cmbEscolhaBanco);
            this.p_Content.Controls.Add(this.lblOutrosBancos);
            this.p_Content.Controls.Add(this.btnCancelar);
            this.p_Content.Controls.Add(this.btnLimpar);
            this.p_Content.Controls.Add(this.btnConfirmar);
            this.p_Content.Controls.Add(this.txtBoxValor);
            this.p_Content.Controls.Add(this.lblValor);
            this.p_Content.Controls.Add(this.lblDados);
            this.p_Content.Controls.Add(this.pnlDadosOutro);
            this.p_Content.Controls.Add(this.lblData);
            this.p_Content.Controls.Add(this.dtpDataTransferencia);
            this.p_Content.Controls.Add(this.cmbBoxTipo);
            this.p_Content.Controls.Add(this.lblTipo);
            this.p_Content.Controls.Add(this.txtBoxContaDestino);
            this.p_Content.Controls.Add(this.txtBoxContaOrigem);
            this.p_Content.Controls.Add(this.lblContaDestino);
            this.p_Content.Controls.Add(this.lblContaOrigem);
            this.p_Content.Controls.Add(this.lblTransferencia);
            // 
            // p_LinkAtivo
            // 
            this.p_LinkAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
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
            // btn_Atendimento
            // 
            this.btn_Atendimento.FlatAppearance.BorderSize = 0;
            this.btn_Atendimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTransferencia.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTransferencia.Location = new System.Drawing.Point(24, 27);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Size = new System.Drawing.Size(215, 21);
            this.lblTransferencia.TabIndex = 0;
            this.lblTransferencia.Text = "REALIZAR TRANSFERÊNCIA";
            // 
            // lblContaOrigem
            // 
            this.lblContaOrigem.AutoSize = true;
            this.lblContaOrigem.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblContaOrigem.Location = new System.Drawing.Point(466, 224);
            this.lblContaOrigem.Name = "lblContaOrigem";
            this.lblContaOrigem.Size = new System.Drawing.Size(80, 13);
            this.lblContaOrigem.TabIndex = 1;
            this.lblContaOrigem.Text = "Conta origem:";
            // 
            // lblContaDestino
            // 
            this.lblContaDestino.AutoSize = true;
            this.lblContaDestino.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblContaDestino.Location = new System.Drawing.Point(466, 280);
            this.lblContaDestino.Name = "lblContaDestino";
            this.lblContaDestino.Size = new System.Drawing.Size(83, 13);
            this.lblContaDestino.TabIndex = 2;
            this.lblContaDestino.Text = "Conta destino:";
            // 
            // txtBoxContaOrigem
            // 
            this.txtBoxContaOrigem.Enabled = false;
            this.txtBoxContaOrigem.Location = new System.Drawing.Point(469, 241);
            this.txtBoxContaOrigem.Name = "txtBoxContaOrigem";
            this.txtBoxContaOrigem.Size = new System.Drawing.Size(100, 20);
            this.txtBoxContaOrigem.TabIndex = 3;
            // 
            // txtBoxContaDestino
            // 
            this.txtBoxContaDestino.Location = new System.Drawing.Point(469, 297);
            this.txtBoxContaDestino.Name = "txtBoxContaDestino";
            this.txtBoxContaDestino.Size = new System.Drawing.Size(100, 20);
            this.txtBoxContaDestino.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTipo.Location = new System.Drawing.Point(291, 280);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(32, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbBoxTipo
            // 
            this.cmbBoxTipo.FormattingEnabled = true;
            this.cmbBoxTipo.Items.AddRange(new object[] {
            "DOC",
            "TED"});
            this.cmbBoxTipo.Location = new System.Drawing.Point(294, 295);
            this.cmbBoxTipo.Name = "cmbBoxTipo";
            this.cmbBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTipo.TabIndex = 6;
            // 
            // dtpDataTransferencia
            // 
            this.dtpDataTransferencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataTransferencia.Location = new System.Drawing.Point(294, 353);
            this.dtpDataTransferencia.Name = "dtpDataTransferencia";
            this.dtpDataTransferencia.Size = new System.Drawing.Size(144, 20);
            this.dtpDataTransferencia.TabIndex = 7;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblData.Location = new System.Drawing.Point(291, 337);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 13);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data:";
            // 
            // pnlDadosOutro
            // 
            this.pnlDadosOutro.Controls.Add(this.cmbBoxCodigo);
            this.pnlDadosOutro.Controls.Add(this.txtBoxAgenciaOutro);
            this.pnlDadosOutro.Controls.Add(this.lblAgenciaOutro);
            this.pnlDadosOutro.Controls.Add(this.lblCodigo);
            this.pnlDadosOutro.Controls.Add(this.lblDadosOutroBanco);
            this.pnlDadosOutro.Location = new System.Drawing.Point(702, 171);
            this.pnlDadosOutro.Name = "pnlDadosOutro";
            this.pnlDadosOutro.Size = new System.Drawing.Size(140, 216);
            this.pnlDadosOutro.TabIndex = 9;
            this.pnlDadosOutro.Visible = false;
            // 
            // cmbBoxCodigo
            // 
            this.cmbBoxCodigo.FormattingEnabled = true;
            this.cmbBoxCodigo.Items.AddRange(new object[] {
            "001 - Bradesco",
            "002 - Banco do Brasil",
            "003 - Itaú"});
            this.cmbBoxCodigo.Location = new System.Drawing.Point(7, 70);
            this.cmbBoxCodigo.Name = "cmbBoxCodigo";
            this.cmbBoxCodigo.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxCodigo.TabIndex = 15;
            // 
            // txtBoxAgenciaOutro
            // 
            this.txtBoxAgenciaOutro.Location = new System.Drawing.Point(7, 124);
            this.txtBoxAgenciaOutro.Name = "txtBoxAgenciaOutro";
            this.txtBoxAgenciaOutro.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAgenciaOutro.TabIndex = 3;
            // 
            // lblAgenciaOutro
            // 
            this.lblAgenciaOutro.AutoSize = true;
            this.lblAgenciaOutro.Location = new System.Drawing.Point(6, 108);
            this.lblAgenciaOutro.Name = "lblAgenciaOutro";
            this.lblAgenciaOutro.Size = new System.Drawing.Size(49, 13);
            this.lblAgenciaOutro.TabIndex = 2;
            this.lblAgenciaOutro.Text = "Agência:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCodigo.Location = new System.Drawing.Point(4, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código: ";
            // 
            // lblDadosOutroBanco
            // 
            this.lblDadosOutroBanco.AutoSize = true;
            this.lblDadosOutroBanco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDadosOutroBanco.Location = new System.Drawing.Point(6, 9);
            this.lblDadosOutroBanco.Name = "lblDadosOutroBanco";
            this.lblDadosOutroBanco.Size = new System.Drawing.Size(110, 17);
            this.lblDadosOutroBanco.TabIndex = 14;
            this.lblDadosOutroBanco.Text = "Dados do banco:";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDados.Location = new System.Drawing.Point(291, 172);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(150, 17);
            this.lblDados.TabIndex = 10;
            this.lblDados.Text = "Dados da transferência:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(466, 337);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "Valor:";
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.Location = new System.Drawing.Point(469, 353);
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValor.TabIndex = 12;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(117)))));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmar.Location = new System.Drawing.Point(752, 411);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 29);
            this.btnConfirmar.TabIndex = 105;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(174)))), ((int)(((byte)(170)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(656, 411);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 29);
            this.btnLimpar.TabIndex = 106;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(560, 411);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 29);
            this.btnCancelar.TabIndex = 107;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblOutrosBancos
            // 
            this.lblOutrosBancos.AutoSize = true;
            this.lblOutrosBancos.Location = new System.Drawing.Point(291, 225);
            this.lblOutrosBancos.Name = "lblOutrosBancos";
            this.lblOutrosBancos.Size = new System.Drawing.Size(24, 13);
            this.lblOutrosBancos.TabIndex = 108;
            this.lblOutrosBancos.Text = "De:";
            // 
            // cmbEscolhaBanco
            // 
            this.cmbEscolhaBanco.FormattingEnabled = true;
            this.cmbEscolhaBanco.Location = new System.Drawing.Point(294, 241);
            this.cmbEscolhaBanco.Name = "cmbEscolhaBanco";
            this.cmbEscolhaBanco.Size = new System.Drawing.Size(121, 21);
            this.cmbEscolhaBanco.TabIndex = 109;
            this.cmbEscolhaBanco.SelectedIndexChanged += new System.EventHandler(this.cmbEscolhaBanco_SelectedValueChanged);
            this.cmbEscolhaBanco.SelectedValueChanged += new System.EventHandler(this.cmbEscolhaBanco_SelectedValueChanged);
            // 
            // TelaTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "TelaTransferencia";
            this.Text = "TelaTransferencia";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            this.pnlDadosOutro.ResumeLayout(false);
            this.pnlDadosOutro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTransferencia;
        private System.Windows.Forms.DateTimePicker dtpDataTransferencia;
        private System.Windows.Forms.ComboBox cmbBoxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtBoxContaDestino;
        private System.Windows.Forms.TextBox txtBoxContaOrigem;
        private System.Windows.Forms.Label lblContaDestino;
        private System.Windows.Forms.Label lblContaOrigem;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Panel pnlDadosOutro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtBoxValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDadosOutroBanco;
        private System.Windows.Forms.TextBox txtBoxAgenciaOutro;
        private System.Windows.Forms.Label lblAgenciaOutro;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbEscolhaBanco;
        private System.Windows.Forms.Label lblOutrosBancos;
        private System.Windows.Forms.ComboBox cmbBoxCodigo;
    }
}