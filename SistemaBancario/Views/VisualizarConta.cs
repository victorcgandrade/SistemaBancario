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

        private void btn_AlterarConta_Click(object sender, EventArgs e)
        {
            AlterarConta alterarConta = new AlterarConta(contaCorrente);
            alterarConta.FormClosed += new FormClosedEventHandler(alterarConta_FormClosed);
            alterarConta.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void alterarConta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_InativarConta_Click(object sender, EventArgs e)
        {
            string numeroConta = tb_NumConta.Text;

            if (MessageBox.Show("Tem certeza que deseja inativar esta conta?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MySQLFunctions.InativarConta(Convert.ToInt32(numeroConta)))
                {
                    MessageBox.Show("Conta inativada com sucesso!");
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("Não foi possível inativar a conta!");
                }
            }
        }
    }
}
