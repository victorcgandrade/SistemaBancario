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

        private DataTable dadosCliente; //variavel global para ser reaproveitada ao longo do codigo

        public VisualizarCliente(string idBusca)
        {
            InitializeComponent();

            dadosCliente = MySQLFunctions.AcessarDadosCliente(idBusca); //obtem todos os dados de um cliente

            if (dadosCliente != null) //se nao ocorreu erro na chamada da funcao acima
            {
                dgv_VisualizarCliente.DataSource = Convert(dadosCliente); //transpondo a tabela para melhor visualizacao

                dgv_VisualizarCliente.Columns[0].HeaderText = ""; //nome para exibicao
                dgv_VisualizarCliente.Columns[0].Name = "Nome Atributos"; //nome para manipulacao

                dgv_VisualizarCliente.Columns[1].HeaderText = ""; //nome para exibicao
                dgv_VisualizarCliente.Columns[1].Name = "Valor Atributos"; //nome para manipulacao

                string nome = dadosCliente.Rows[0][0].ToString(); //na primeira linha esta armazenado o primeiro nome do cliente
                string sobrenome = dadosCliente.Rows[0][1].ToString(); //na segunda linha esta armazenado o sobrenome do cliente

                lb_NomeSobrenome.Text = nome + " " + sobrenome;
            } else
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

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            string cpf = dgv_VisualizarCliente.Rows[2].Cells[1].Value.ToString();

            if (MessageBox.Show("Tem certeza que deseja inativar este cliente?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MySQLFunctions.InativarCliente(cpf))
                {
                    MessageBox.Show("Cliente inativado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível inativar o cliente!");
                }
            }
        }

        //Quando o botao de alterar cliente for clicado
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            AlterarCliente alterarCliente = new AlterarCliente(dadosCliente);
            alterarCliente.FormClosed += new FormClosedEventHandler(alterarCliente_FormClosed);
            alterarCliente.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void alterarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
