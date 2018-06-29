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
    public partial class AlterarConta : SistemaBancario.Views.TemplateInicialAdministrador
    {
        ContaCorrente contaCorrente; //atributo global para ser reaproveitado ao longo do codigo

        public AlterarConta(ContaCorrente cc)
        {
            InitializeComponent();
            carregarContaCorrente(cc);
        }

        private void carregarContaCorrente(ContaCorrente cc)
        {
            if (cc != null)
            {

                contaCorrente = cc;

                cb_NumAgencia.DataSource = MySQLFunctions.RetornarNumAgencias();
                tb_NumeroConta.Text = cc.Numero.ToString();
                tb_Senha.Text = cc.Senha;

                cb_Status.SelectedIndex = cb_Status.FindString(cc.Status);

                tb_CpfCliente.Text = cc.Cliente.Cpf;
            }
            else
            {
                MessageBox.Show("Não foi possível carregar a conta!");
            }
        }

        private Boolean AtualizarConta()
        {
            int numeroConta = Convert.ToInt32(tb_NumeroConta.Text);
            string novaSenha = tb_Senha.Text;
            string novoStatus = cb_Status.Text;
            int novaAgencia = Convert.ToInt32(cb_NumAgencia.Text);

            if (MySQLFunctions.AtualizarContaCorrente(numeroConta, novaSenha, novoStatus, novaAgencia))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        private void btn_Confirmar_AlterarConta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja alterar esta conta?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (AtualizarConta())
                {
                    MessageBox.Show("Conta atualizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar a conta.");
                }
            }
        }
    }
}
