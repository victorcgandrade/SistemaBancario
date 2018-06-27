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
    public partial class VisualizarAplicacao : SistemaBancario.Views.TemplateInicialAdministrador
    {
        private Aplicacao aplicacao; //variavel global para ser reaproveitada ao longo do codigo

        public VisualizarAplicacao(string idBusca)
        {
            InitializeComponent();
            carregarAplicacao(idBusca);
        }

        private void carregarAplicacao(string idBusca)
        {
            aplicacao = MySQLFunctions.RetornarAplicacao(Convert.ToInt32(idBusca)); //obtem todos os dados de um cliente

            lb_IdentificadorAplicacao.Text = "Aplicação " + aplicacao.tipoAplicacao + " Conta " + aplicacao.contaCorrente.Numero;

            if (aplicacao != null)
            {
                tb_Visualizar_TpAplicacao.Text = aplicacao.tipoAplicacao;
                tb_Visualizar_StatusAplicacao.Text = aplicacao.status;
                tb_Visualizar_ValorMin.Text = aplicacao.valorMinimo.ToString();
                tb_Visualizar_ResgMin.Text = aplicacao.resgateMinimo.ToString();
                tb_Visualizar_ValorInicial.Text = aplicacao.valorInicial.ToString();
                tb_Visualizar_Vencimento.Text = aplicacao.vencimento.ToString() + " %";

                if (tb_Visualizar_TpAplicacao.Text == "Pré-Fixada")
                {
                    tb_Visualizar_Taxa.Text = aplicacao.taxaRendimento.ToString(); //taxa pre-definida

                } else if (tb_Visualizar_TpAplicacao.Text == "Pós-Fixada")
                {
                    tb_Visualizar_Taxa.Text = aplicacao.taxaRendimento.ToString(); //taxa Selic do dia

                    lb_Asterisco.Visible = true;
                    lb_InformacaoTaxaSelic.Visible = true;
                    lb_DataAtual.Visible = true;
                    lb_DataAtual.Text = DateTime.Today.Date.ToString();

                    lb_Tributos.Visible = true;
                    lb_IOF.Visible = true;
                    lb_ImpostoRenda.Visible = true;
                    tb_Visualizar_IOF.Text = aplicacao.valorIOF.ToString();
                    tb_Visualizar_ImpostoRenda.Text = aplicacao.impostoRenda.ToString();
                }

            }
            else
            {
                MessageBox.Show("Aplicação não carregada!");
            }
        }

        private void btn_RemoverAplicacao_Click(object sender, EventArgs e)
        {
            string idAplicacao = "";

            if (MessageBox.Show("Tem certeza que deseja cancelar esta aplicação? Ao confirmar, não será mais possível manipula-la.", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MySQLFunctions.CancelarAplicacao(idAplicacao))
                {
                    MessageBox.Show("Aplicação cancelada com sucesso!");

                    btn_AlterarAplicacao.Visible = false;
                    btn_CancelarAplicacao.Visible = false;
                }
                else
                {
                  MessageBox.Show("Não foi possível cancelar a aplicação!");
                }
            }
        }

        private void btn_AlterarAplicacao_Click(object sender, EventArgs e)
        {

        }
    }
}
