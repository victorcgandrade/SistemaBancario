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

        //------------------------Simulacao de Placeholder para textbox
        private void tb_PrimeiroNome_Enter(object sender, EventArgs e)
        {
            if (tb_PrimeiroNome.Text == "Primeiro Nome")
            {
                tb_PrimeiroNome.Text = "";
                tb_PrimeiroNome.ForeColor = Color.Black;
            }
        }

        private void tb_PrimeiroNome_Leave(object sender, EventArgs e)
        {
            if (tb_PrimeiroNome.Text == "")
            {
                tb_PrimeiroNome.Text = "Primeiro Nome";
                tb_PrimeiroNome.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            }
        }
        //Simulacao de Placeholder para textbox------------------------


        //Metodo para adicionar uma linha na tabela Usuario no banco de dados remoto online
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
                MessageBox.Show("Houve algum problema: Usuario não pôde ser inserido");
            }
        }

        //Metodo para adicionar uma linha na tabela Endereco no banco de dados remoto online
        private void CriarEndereco()
        {
            string cep = tb_Cep.Text;
            string logradouro = cb_Logradouro.Text;
            string rua = tb_Rua.Text;
            int numero = Convert.ToInt32(tb_Numero.Text);
            string bairro = tb_Bairro.Text;
            string complemento = tb_Complemento.Text;
            string cidade = tb_Cidade.Text;
            string estado = cb_Estado.Text;

            if (cep != "" && logradouro != "" && rua != "" && bairro != "" && complemento != "" && cidade != "" && estado != "")
            {
                if (SistemaBancario.Models.MySQLFunctions.InserirEndereco(logradouro, rua, numero, bairro, complemento, cep, cidade, estado))
                {
                    MessageBox.Show("Sucesso!");
                }
                MessageBox.Show("Houve algum problema: Endereco não pôde ser inserido");
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            CriarUsuario();
            CriarEndereco();
        }

        private void p_Content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
