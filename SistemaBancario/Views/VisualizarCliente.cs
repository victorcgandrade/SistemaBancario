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

            DataTable dadosCliente = MySQLFunctions.AcessarDadosCliente(idBusca); //obtem todos os dados de um cliente

            if (dadosCliente != null) //se nao ocorreu erro na chamada da funcao acima
            {
                dgv_VisualizarCliente.DataSource = dadosCliente;

                string nome = dadosCliente.Rows[0][0].ToString(); //na primeira coluna esta armazenado o primeiro nome do cliente
                string sobrenome = dadosCliente.Rows[0][1].ToString(); //na segunda coluna esta armazenado o sobrenome do cliente

                lb_NomeSobrenome.Text = nome + " " + sobrenome;
            } else
            {
                MessageBox.Show("Algo deu errado. Tente novamente.");
            }
        }

    }
}
