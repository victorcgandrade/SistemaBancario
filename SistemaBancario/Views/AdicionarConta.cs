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
            int agencia = Int32.Parse(txtBoxAgencia.Text);
            int numero = Int32.Parse(txtBoxNumero.Text);
            int senha = Int32.Parse(txtBoxSenha.Text);
            int cpf = Int32.Parse(txtBoxCPF.Text);

            if (MySQLFunctions.InserirConta(agencia, numero, senha, cpf))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CriarConta())
            {
                MessageBox.Show("Conta criada com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha na operação!");
            }

        }
    }
}
