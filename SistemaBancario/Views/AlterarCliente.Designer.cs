namespace SistemaBancario.Views
{
    partial class AlterarCliente
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
            this.p_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_TipoPessoaJuridica
            // 
            this.cb_TipoPessoaJuridica.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb_TipoPessoaJuridica.Enabled = false;
            // 
            // tb_Cnpj
            // 
            this.tb_Cnpj.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_Cnpj.ReadOnly = true;
            // 
            // tb_CpfTitularAssociado
            // 
            this.tb_CpfTitularAssociado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_CpfTitularAssociado.ReadOnly = true;
            // 
            // lb_TituloAdicionarCliente
            // 
            this.lb_TituloAdicionarCliente.Size = new System.Drawing.Size(144, 21);
            this.lb_TituloAdicionarCliente.Text = "ALTERAR CLIENTE";
            // 
            // cb_TipoCliente
            // 
            this.cb_TipoCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb_TipoCliente.Enabled = false;
            // 
            // dtp_DataNascimento
            // 
            this.dtp_DataNascimento.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtp_DataNascimento.Enabled = false;
            // 
            // tb_RgCliente
            // 
            this.tb_RgCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_RgCliente.ReadOnly = true;
            // 
            // tb_CpfCliente
            // 
            this.tb_CpfCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_CpfCliente.ReadOnly = true;
            // 
            // AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1325, 694);
            this.Name = "AlterarCliente";
            this.p_Content.ResumeLayout(false);
            this.p_Content.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
