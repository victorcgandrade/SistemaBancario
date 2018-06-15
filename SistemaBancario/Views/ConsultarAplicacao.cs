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
    public partial class ConsultarAplicacao : SistemaBancario.Views.TemplateInicialAdministrador
    {
        public ConsultarAplicacao()
        {
            InitializeComponent();
        }

        private void btn_BuscarAplicacao_Click(object sender, EventArgs e)
        {
            string numeroBusca = tb_CampoBuscaAplicacao.Text;

            if (numeroBusca != "")
            {
                DataTable resultadoBuscaAplicacao = new DataTable();
                resultadoBuscaAplicacao = MySQLFunctions.BuscarAplicacao(numeroBusca);

                if (resultadoBuscaAplicacao != null)
                {

                    dgv_ResultadoBuscaAplicacao.DataSource = resultadoBuscaAplicacao;

                    //Nomeacao das colunas
                    dgv_ResultadoBuscaAplicacao.Columns[0].HeaderText = "Identificador"; //nome para exibicao
                    dgv_ResultadoBuscaAplicacao.Columns[0].Name = "Identificador"; //nome para manipulacao

                    dgv_ResultadoBuscaAplicacao.Columns[1].HeaderText = "Tipo de Aplicação";
                    dgv_ResultadoBuscaAplicacao.Columns[1].Name = "Tipo de Aplicação";

                    dgv_ResultadoBuscaAplicacao.Columns[2].HeaderText = "Valor Inicial (R$)";
                    dgv_ResultadoBuscaAplicacao.Columns[2].Name = "Valor Inicial";

                    dgv_ResultadoBuscaAplicacao.Columns[3].HeaderText = "Vencimento";
                    dgv_ResultadoBuscaAplicacao.Columns[3].Name = "Vencimento";

                }
                else
                {
                    MessageBox.Show("Não foi possível realizar a busca. Certifique-se de que digitou corretamente e tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("Insira um valor válido para que a busca seja realizada.");
            }
        }
    }
}
