using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class AdicionarConta : TemplateInicialAdministrador
    {
        public AdicionarConta()
        {
            InitializeComponent();
        }

        private Boolean CriarConta()
        {
            bool sucesso = false;

            string cpf = tb_CpfCliente.Text;
            int agencia = Convert.ToInt32(tb_NumeroAgencia.Text);
            int numero = Convert.ToInt32(tb_NumeroConta.Text);
            string senha = tb_Senha.Text;

            if (MySQLFunctions.InserirConta(agencia, numero, senha, cpf))
            {

                sucesso = true;
            }
            else
            {
                sucesso = false;
            }

            return sucesso;
        }

        private void btn_AdicionarConta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja criar essa conta?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CriarConta())
                {
                    MessageBox.Show("Conta Corrente criada com sucesso!");

                }
                else
                {
                    MessageBox.Show("Não foi possível criar esta conta corrente!");
                }
            }
        }
    }
}
