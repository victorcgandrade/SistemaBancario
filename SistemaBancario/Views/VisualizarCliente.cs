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

            int idCliente = MySQLFunctions.VisualizarCliente(idBusca);

            if (idCliente > 0) //nao ocorreu erro na chamada da funcao acima
            {
                MessageBox.Show(idCliente.ToString());
            } else
            {
                MessageBox.Show("Não funcionou :(");
            }
        }

    }
}
