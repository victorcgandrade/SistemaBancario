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
    public partial class VisualizarConta : SistemaBancario.Views.TemplateInicialAdministrador
    {
        private ContaCorrente contaCorrente; //variavel global para ser reaproveitada ao longo do codigo

        public VisualizarConta(int idBusca)
        {
            InitializeComponent();
            carregarConta(idBusca);
        }

        private void carregarConta(int idBusca)
        {
            contaCorrente = MySQLFunctions.RetornarContaCorrente(idBusca);

            if (contaCorrente != null)
            {
                lb_ContaCorrenteId.Text = "Conta Corrente " + idBusca;
                tb_NumAgencia.Text = contaCorrente.Agencia.Numero.ToString();
                tb_NumConta.Text = contaCorrente.Numero.ToString();
                tb_Status.Text = contaCorrente.Status;
                tb_Saldo.Text = contaCorrente.Saldo.ToString();
                tb_Taxa.Text = contaCorrente.Taxa.ToString();
                tb_Limite.Text = contaCorrente.Limite.ToString();
                tb_CPFCliente.Text = contaCorrente.Cliente.Cpf;
            } 
            else
            {
                MessageBox.Show("Não foi possível carregar a conta!");
            }
        }

    }
}
