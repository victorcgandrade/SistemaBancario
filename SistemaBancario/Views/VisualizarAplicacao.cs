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
        public VisualizarAplicacao(string idAplicacao)
        {
            InitializeComponent();

            DataTable dadosAplicacao = MySQLFunctions.AcessarDadosAplicacao(idAplicacao); //obtem todos os dados de um cliente

            if (dadosAplicacao != null) //se nao ocorreu erro na chamada da funcao acima
            {
                dgv_VisualizarAplicacao.DataSource = Convert(dadosAplicacao); //transpondo a tabela para melhor visualizacao

                dgv_VisualizarAplicacao.Columns[0].HeaderText = ""; //nome para exibicao
                dgv_VisualizarAplicacao.Columns[0].Name = "Nome Atributos"; //nome para manipulacao

                dgv_VisualizarAplicacao.Columns[1].HeaderText = ""; //nome para exibicao
                dgv_VisualizarAplicacao.Columns[1].Name = "Valor Atributos"; //nome para manipulacao

                string tipoAplicacao = dadosAplicacao.Rows[0][1].ToString(); //na primeira linha esta armazenado o primeiro nome do cliente
                string numAplicacao = dadosAplicacao.Rows[0][0].ToString(); //na segunda linha esta armazenado o sobrenome do cliente
                string numeroConta = dadosAplicacao.Rows[0][9].ToString();

                lb_IdentificadorAplicacao.Text = "Conta " + numeroConta + " - " + tipoAplicacao + " " + numAplicacao;
            }
            else
            {
                MessageBox.Show("Algo deu errado. Tente novamente.");
            }
        }

        //Metodo para transpor uma tabela: Linha vira coluna e coluna vira linha
        public DataTable Convert(DataTable dt)
        {
            DataTable dt2 = new DataTable();
            for (int i = 0; i <= dt.Rows.Count; i++)
            {
                dt2.Columns.Add();
            }
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt2.Rows.Add();
                dt2.Rows[i][0] = dt.Columns[i].ColumnName;
            }
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    dt2.Rows[i][j + 1] = dt.Rows[j][i];
                }
            }
            return dt2;
        }

        private void btn_RemoverAplicacao_Click(object sender, EventArgs e)
        {
            string idAplicacao = dgv_VisualizarAplicacao.Rows[0].Cells[1].Value.ToString();

            if (MessageBox.Show("Tem certeza que deseja cancelar esta aplicação?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MySQLFunctions.CancelarAplicacao(idAplicacao))
                {
                    MessageBox.Show("Aplicação cancelada com sucesso!");
                }
                else
                {
                  MessageBox.Show("Não foi possível cancelar a aplicação!");
                }
            }
        }
    }
}
