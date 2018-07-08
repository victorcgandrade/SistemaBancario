using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaBancario.Models;

namespace SistemaBancario.Views
{
    public partial class CriarAplicacao : SistemaBancario.Views.TemplateInicialCliente
    {
        public CriarAplicacao()
        {
            InitializeComponent();
        }

        private Boolean AdicionarAplicacao()
        {
            bool sucesso = false;

            Decimal valorInicial = Convert.ToDecimal(tb_ValorInicial.Text);
            DateTime vencimento = Convert.ToDateTime(dtp_DataVencimento.Text);
            int idConta = 1; //CORRIGIR

            if (MySQLFunctions.CriarAplicacao(valorInicial, vencimento, idConta))
            {

                sucesso = true;
            }
            else
            {
                sucesso = false;
            }

            return sucesso;
        }

        private void btn_Confirmar_Aplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja criar essa aplicação?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (AdicionarAplicacao())
                {
                    MessageBox.Show("Aplicação criada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível criar a aplicação!");
                }
            }
        }
    }
}
