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
        private Boolean CriarUsuario()
        {
            bool sucesso = false;

            string primeiroNome = tb_PrimeiroNome.Text;
            string sobrenome = tb_Sobrenome.Text;
            string cpf = tb_CpfCliente.Text;
            string rg = tb_RgCliente.Text;

            if (primeiroNome != "" && sobrenome != "" && cpf != "" && rg != "")
            {
                if(SistemaBancario.Models.MySQLFunctions.InserirUsuario(primeiroNome, sobrenome, cpf, rg))
                {
                    sucesso = true;
                    MessageBox.Show("USUARIO SUCESSO");
                }
            }

            return sucesso;
        }

        //Metodo para adicionar uma linha na tabela Endereco no banco de dados remoto online
        private Boolean CriarEndereco()
        {
            bool sucesso = false;

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
                    sucesso = true;
                    MessageBox.Show("ENDERECO SUCESSO");
                }
            }

            return sucesso;
        }

        //Metodo para adicionar uma linha na tabela Cliente no banco de dados remoto online
        private Boolean CriarCliente()
        {
            bool sucesso = false;

            string cpf = tb_CpfCliente.Text;
            string cep = tb_Cep.Text;
            string email = tb_Email.Text;
            string telefone = tb_Telefone.Text;
            string celular = tb_Celular.Text;
            string dataNascimento = dtp_DataNascimento.Text;
            string dataCadastro = dtp_DataCadastro.Text;
            string status = cb_Status.Text;
            string estadoCivil = cb_EstadoCivil.Text;

            if (cpf != "" && cep != "" && email != "" && telefone != "" && celular != "" && dataNascimento != "" && dataCadastro != "" && status != "" && estadoCivil != "")
            {
                if (SistemaBancario.Models.MySQLFunctions.InserirCliente (dataNascimento,  email,  telefone,  celular, dataCadastro, status, estadoCivil, cep, cpf))
                {
                    sucesso = true;
                }
            }

            return sucesso;
        }

        private Boolean SelecionarTipoCliente()
        {
            bool sucesso = false;

            if (cb_TipoCliente.Text == "Titular Pessoa Física")
            {
                if(CriarTitularPessoaFisica())
                {
                    sucesso = true;
                } 
           
            }
            else if (cb_TipoCliente.Text == "Titular Pessoa Jurídica")
            {
                if(CriarTitularPessoaJuridica())
                {
                    sucesso = true;
                }
            }
            else if (cb_TipoCliente.Text == "Dependente")
            {
                if(CriarDependente())
                {
                    sucesso = true;
                }
            } else
            {
                MessageBox.Show("Tipo de Cliente está incorreto!");
            }
            return sucesso;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja adicionar este cliente?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                //Para criar algum tipo de cliente eh preciso seguir a seguinte ordem
                if (CriarUsuario())
                {
                    if (CriarEndereco())
                    {
                        if (CriarCliente())
                        {
                            if(SelecionarTipoCliente())
                            {
                                MessageBox.Show("O Cliente foi inserido com sucesso!");
                            }
                        }
                    }
                }
            }
        }

        private Boolean CriarTitularPessoaFisica()
        {
            bool sucesso = false;

            string cpf = tb_CpfCliente.Text;
            string profissao = tb_Profissao.Text;
            Decimal rendaMensal = Decimal.Parse(tb_RendaMensal.Text);

            if (profissao != "" && cpf != "")
            {
                if (SistemaBancario.Models.MySQLFunctions.InserirTitularPessoaFisica(profissao, rendaMensal, cpf))
                {
                    sucesso = true;
                }
            }

            return sucesso;
        }

        private Boolean CriarTitularPessoaJuridica()
        {
            return false;
        }

        private Boolean CriarDependente()
        {
            return false;
        }
    }
}
