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
    public partial class VisualizarCliente : SistemaBancario.Views.TemplateInicialAdministrador
    {

        public VisualizarCliente(string idBusca)
        {
            InitializeComponent();
            if (!PreencherDados(idBusca))
            {
                MessageBox.Show("Algo deu errado. Tente novamente.");
            }
        }

        private Boolean PreencherDados(string idBusca)
        {
            bool sucesso = false;

            DataTable dadosCliente = MySQLFunctions.AcessarDadosCliente(idBusca); //obtem todos os dados de um cliente

            if (dadosCliente != null) //se nao ocorreu erro na chamada da funcao acima
            {
                dgv_VisualizarCliente.DataSource = TransposeTable(dadosCliente); //Transpondo a tabela para melhor visualizacao

                //Retirando o nome do cabecalho da tabela
                dgv_VisualizarCliente.Columns[0].HeaderText = "";
                dgv_VisualizarCliente.Columns[1].HeaderText = "";

                string nome = dadosCliente.Rows[0][0].ToString(); //na primeira coluna esta armazenado o primeiro nome do cliente
                string sobrenome = dadosCliente.Rows[0][1].ToString(); //na segunda coluna esta armazenado o sobrenome do cliente

                lb_NomeSobrenome.Text = nome + " " + sobrenome;
                sucesso = true;
            }
            return sucesso;
        }

        //Funcao que ira transpor uma tabela: coluna torna-se linha e linha, coluna
        private DataTable TransposeTable(DataTable dt)
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

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            string cpfUsuario = dgv_VisualizarCliente.Rows[2].Cells[1].Value.ToString(); //captura o valor do CPF do cliente

            if (MySQLFunctions.RemoverCliente(cpfUsuario))
            {
                MessageBox.Show("Removido com sucesso!");
            } else
            {
                MessageBox.Show("Não foi possível remover o cliente. Tente novamente.");
            }
        }
    }
}