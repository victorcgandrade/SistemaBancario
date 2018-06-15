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
    public partial class ListarAplicacoes : SistemaBancario.Views.TemplateInicialAdministrador
    {
        public ListarAplicacoes()
        {
            InitializeComponent();
            carregarTabela();
        }

        private void carregarTabela()
        {
            DataTable listagemClientes = new DataTable();

            listagemClientes = MySQLFunctions.ListarAplicacao();

            if (listagemClientes != null)
            {
                dgv_ResultadoListarAplicacao.DataSource = listagemClientes;
            }
            else
            {
                MessageBox.Show("Algo deu errado.");
            }
        }
    }
}
