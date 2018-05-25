using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class AdicionarCliente : SistemaBancario.Views.TemplateInicialAdministrador
    {
        public AdicionarCliente()
        {
            InitializeComponent();
        }

        private void CriarUsuario()
        {
            string primeiroNome = tb_PrimeiroNome.Text;
            string sobrenome = tb_Sobrenome.Text;
            string cpf = tb_CpfCliente.Text;
            string rg = tb_RgCliente.Text;

            if (primeiroNome != "" && sobrenome != "" && cpf != "" && rg != "")
            {
                if(SistemaBancario.Models.MySQLFunctions.InserirUsuario(primeiroNome, sobrenome, cpf, rg))
                {
                    MessageBox.Show("Sucesso!");
                }
            }

            
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            CriarUsuario();
        }
    }
}
