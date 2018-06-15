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
    public partial class ListarClientes : SistemaBancario.Views.TemplateInicialAdministrador
    {
        public ListarClientes()
        {
            InitializeComponent();
            carregarTabela();
        }

        private void carregarTabela()
        {
            DataTable listagemClientes = new DataTable();

            listagemClientes = MySQLFunctions.ListarCliente();

            if (listagemClientes != null)
            {
                dgv_ResultadoListarCliente.DataSource = listagemClientes;

            }
            else
            {
                MessageBox.Show("Algo deu errado.");
            }
        }

    }
}
