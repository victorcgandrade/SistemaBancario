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

        private Cliente cliente; //variavel global para ser reaproveitada ao longo do codigo

        public VisualizarCliente(string idBusca)
        {
            InitializeComponent();

            List<Cliente> a = new List<Cliente>();

            cliente = MySQLFunctions.RetornarCliente(idBusca); //obtem todos os dados de um cliente

            a.Add(cliente);

            if (cliente != null) //se nao ocorreu erro na chamada da funcao acima
            {
                dgv_VisualizarCliente.DataSource = a;
            }
            else
            {
                MessageBox.Show("Algo deu errado. Tente novamente.");
            }
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
            AlterarCliente alterarCliente = new AlterarCliente(cliente);
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
