using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class ResumoAplicacao : SistemaBancario.Views.TemplateInicialCliente
    {
        public ResumoAplicacao(List<Object> informacoes, InstanciaLogin il)
        {
            InitializeComponent();
            carregarAplicacao(informacoes);
            LabelAgencia = il.agencia;
            LabelConta = il.conta;
        }

        private void carregarAplicacao(List<Object> informacoes)
        {
            lb_ValorInicial.Text = informacoes[0].ToString();
            lb_Vencimento.Text = informacoes[1].ToString();
        }

        private void btn_ConfirmarAplicacao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja criar esta aplicação?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Decimal valorInicial = Convert.ToDecimal(lb_ValorInicial.Text);
                DateTime vencimento = Convert.ToDateTime(lb_Vencimento.Text).Date;
                int numeroConta = Convert.ToInt32(lblConta.Text);

                if (MySQLFunctions.CriarAplicacao(valorInicial, vencimento, numeroConta))
                {
                    MessageBox.Show("Aplicação realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível criar a aplicação!");
                }
            }
        }
    }
}
