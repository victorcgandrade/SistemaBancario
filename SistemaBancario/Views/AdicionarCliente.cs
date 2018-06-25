using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class AdicionarCliente : SistemaBancario.Views.FormularioCliente
    {
        public AdicionarCliente()
        {
            InitializeComponent();
        }

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
                if (MySQLFunctions.InserirUsuario(primeiroNome, sobrenome, cpf, rg))
                {
                    sucesso = true;
                }
            }

            return sucesso;
        }

        //Metodo para adicionar uma linha na tabela Endereco no banco de dados remoto online
        private Boolean CriarEndereco()
        {
            bool sucesso = false;

            string cep = tb_Cep.Text;
            string tipo = cb_Tipo.Text;
            string logradouro = tb_Logradouro.Text;
            int numero = Convert.ToInt32(tb_Numero.Text);
            string bairro = tb_Bairro.Text;
            string complemento = tb_Complemento.Text;
            string cidade = tb_Cidade.Text;
            string estado = cb_Estado.Text;

            if (cep != "" && tipo != "" && logradouro != "" && bairro != "" && cidade != "" && estado != "")
            {
                if (MySQLFunctions.InserirEndereco(tipo, logradouro, numero, bairro, complemento, cep, cidade, estado))
                {
                    sucesso = true;
                }
            }

            return sucesso;
        }

        //Metodo para adicionar uma linha na tabela Cliente no banco de dados remoto online
        private Boolean CriarCliente()
        {
            bool sucesso = false;

            string cpf = tb_CpfCliente.Text; //para poder recuperar o id de Usuario
            string cep = tb_Cep.Text; //para poder recuperar o id do Endereco deste cliente
            string email = tb_Email.Text;
            string telefone = tb_Telefone.Text;
            string celular = tb_Celular.Text;
            string dataNascimento = dtp_DataNascimento.Text;
            string dataCadastro = dtp_DataCadastro.Text;
            string status = cb_Status.Text;
            string estadoCivil = cb_EstadoCivil.Text;

            if (cpf != "" && cep != "" && email != "" && celular != "" && dataNascimento != "" && dataCadastro != "" && status != "" && estadoCivil != "")
            {
                if (MySQLFunctions.InserirCliente(dataNascimento, email, telefone, celular, dataCadastro, status, estadoCivil, cep, cpf))
                {
                    sucesso = true;
                }
            }

            return sucesso;
        }

        //Metodo para adicionar uma linha na tabela PessoaFisica no banco de dados remoto online
        private Boolean CriarTitularPessoaFisica()
        {
            bool sucesso = false;

            string email = tb_Email.Text; //para poder recuperar o id de cliente
            string profissao = tb_Profissao.Text;
            string textoRendaMensal = tb_RendaMensal.Text;

            if (textoRendaMensal != "")
            {
                Decimal rendaMensal = Decimal.Parse(textoRendaMensal);

                if (profissao != "" && email != "")
                {
                    if (MySQLFunctions.InserirTitularPessoaFisica(profissao, rendaMensal, email))
                    {
                        sucesso = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Renda Mensal inválida!");
            }

            return sucesso;
        }

        //Metodo para adicionar uma linha na tabela PessoaJuridica no banco de dados remoto online
        private Boolean CriarTitularPessoaJuridica()
        {
            bool sucesso = false;

            string email = tb_Email.Text; //para poder recuperar o id de cliente
            string cnpj = tb_Cnpj.Text;
            string razaoSocial = tb_RazaoSocial.Text;
            string tipoPessoaJuridica = cb_TipoPessoaJuridica.Text;

            if (razaoSocial != "" && cnpj != "" && tipoPessoaJuridica != "")
            {
                if (MySQLFunctions.InserirTitularPessoaJuridica(cnpj, razaoSocial, tipoPessoaJuridica, email))
                {
                    sucesso = true;
                }
            }
            return sucesso;
        }

        //Metodo para adicionar uma linha na tabela Dependente no banco de dados remoto online
        private Boolean CriarDependente()
        {
            bool sucesso = false;

            string email = tb_Email.Text; //para poder recuperar o id de cliente
            string cpfTitularResponsavel = tb_CpfTitularAssociado.Text;

            if (cpfTitularResponsavel != "" && email != "")
            {
                if (MySQLFunctions.InserirDependente(cpfTitularResponsavel, email))
                {
                    sucesso = true;
                }
            }
            return sucesso;
        }

        //Metodo para redirecionar para as funcoes que criam os diferentes tipos de cliente
        private Boolean SelecionarTipoCliente()
        {
            bool sucesso = false;

            if (cb_TipoCliente.Text == "Titular Pessoa Física")
            {
                if (CriarTitularPessoaFisica())
                {
                    sucesso = true;
                }

            }
            else if (cb_TipoCliente.Text == "Titular Pessoa Jurídica")
            {
                if (CriarTitularPessoaJuridica())
                {
                    sucesso = true;
                }
            }
            else if (cb_TipoCliente.Text == "Dependente")
            {
                if (CriarDependente())
                {
                    sucesso = true;
                }
            }
            else
            {
                MessageBox.Show("Tipo de Cliente está incorreto!");
            }
            return sucesso;
        }

        //Botao confirmar ao ser clicado
        private void btn_Confirmar_Adicionar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja adicionar este cliente?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Para criar algum tipo de cliente eh preciso seguir a seguinte ordem
                if (CriarUsuario() && CriarEndereco() && CriarCliente())
                {
                    if (SelecionarTipoCliente())
                    {
                        MessageBox.Show("O Cliente foi inserido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível criar o cliente.");
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível criar o cliente.");
                }
            }
        }



        //Metodo para 'esconder' partes da tela de acordo com o tipo de cliente
        private void cb_TipoCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_TipoCliente.Text == "Titular Pessoa Física")
            {
                //Parte de dependente escondido
                lb_TitularAssociado.Visible = false;
                lb_CpfResponsavel.Visible = false;
                tb_CpfTitularAssociado.Visible = false;

                //Parte de pessoa juridica escondido
                lb_InformacaoJuridica.Visible = false;
                lb_RazaoSocial.Visible = false;
                tb_RazaoSocial.Visible = false;
                lb_Cnpj.Visible = false;
                tb_Cnpj.Visible = false;
                cb_TipoPessoaJuridica.Visible = false;

                //Parte de pessoa fisica visivel
                lb_InformacaoEconomica.Visible = true;
                lb_Profissao.Visible = true;
                tb_Profissao.Visible = true;
                lb_RendaMensal.Visible = true;
                tb_RendaMensal.Visible = true;

            }
            else if (cb_TipoCliente.Text == "Titular Pessoa Jurídica")
            {
                //Parte de dependente escondido
                lb_TitularAssociado.Visible = false;
                lb_CpfResponsavel.Visible = false;
                tb_CpfTitularAssociado.Visible = false;

                //Parte de pessoa fisica escondido
                lb_InformacaoEconomica.Visible = false;
                lb_Profissao.Visible = false;
                tb_Profissao.Visible = false;
                lb_RendaMensal.Visible = false;
                tb_RendaMensal.Visible = false;

                //Parte de pessoa juridica visivel 
                lb_InformacaoJuridica.Visible = true;
                lb_RazaoSocial.Visible = true;
                tb_RazaoSocial.Visible = true;
                lb_Cnpj.Visible = true;
                tb_Cnpj.Visible = true;
                cb_TipoPessoaJuridica.Visible = true;

            }
            else if (cb_TipoCliente.Text == "Dependente")
            {
                //Parte de pessoa fisica escondido
                lb_InformacaoEconomica.Visible = false;
                lb_Profissao.Visible = false;
                tb_Profissao.Visible = false;
                lb_RendaMensal.Visible = false;
                tb_RendaMensal.Visible = false;

                //Parte de pessoa juridico escondido
                lb_InformacaoJuridica.Visible = false;
                lb_RazaoSocial.Visible = false;
                tb_RazaoSocial.Visible = false;
                lb_Cnpj.Visible = false;
                tb_Cnpj.Visible = false;
                cb_TipoPessoaJuridica.Visible = false;

                //Parte de dependente visivel
                lb_TitularAssociado.Visible = true;
                lb_CpfResponsavel.Visible = true;
                tb_CpfTitularAssociado.Visible = true;
            }
        }

        

    }
}
