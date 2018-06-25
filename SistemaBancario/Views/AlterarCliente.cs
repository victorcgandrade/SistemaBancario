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
    public partial class AlterarCliente : SistemaBancario.Views.FormularioCliente
    {
        Cliente cliente; //atributo global para ser reaproveitado ao longo do codigo

        public AlterarCliente(Cliente cl)
        {
            InitializeComponent();

            inicializarCliente(cl);

            if (cl is Dependente)
            {
                Dependente dp = (Dependente) cl;

                cliente = new Dependente();
                cliente = dp;

                inicializarDependente(dp);

            } else if (cl is PessoaFisica)
            {
                PessoaFisica pf = (PessoaFisica)cl;

                cliente = new PessoaFisica();
                cliente = pf;

                inicializarPF(pf);

            } else if (cl is PessoaJuridica)
            {
                PessoaJuridica pj = (PessoaJuridica)cl;

                cliente = new PessoaJuridica();
                cliente = pj;

                inicializarPJ(pj);

            } else
            {
                MessageBox.Show("Tipo de cliente incorreto!");
            }

        }

        private void inicializarDependente(Dependente dp)
        {
            cb_TipoCliente.Text = "Dependente";
            //tb_CpfTitularAssociado.Text = dp.Titular.Cpf;
        }

        private void inicializarPF(PessoaFisica pf)
        {
            cb_TipoCliente.Text = "Titular Pessoa Física";
            tb_Profissao.Text = pf.Profissao;
            tb_RendaMensal.Text = pf.RendaMensal.ToString();
        }

        private void inicializarPJ(PessoaJuridica pj)
        {
            cb_TipoCliente.Text = "Titular Pessoa Jurídica";
            tb_RazaoSocial.Text = pj.RazaoSocial;
            tb_Cnpj.Text = pj.Cnpj;
            cb_TipoPessoaJuridica.Text = pj.Tipo;
        }

        //todos atributos comuns aos clientes
        private void inicializarCliente(Cliente cl)
        {
            tb_PrimeiroNome.Text = cl.PrimeiroNome;
            tb_Sobrenome.Text = cl.Sobrenome;
            cb_EstadoCivil.Text = cl.Estado_civil;
            tb_CpfCliente.Text = cl.Cpf;
            tb_RgCliente.Text = cl.Rg;
            tb_Celular.Text = cl.Celular;
            tb_Telefone.Text = cl.Telefone;
            tb_Email.Text = cl.Email;
            tb_Cep.Text = cl.Endereco.Cep;
            cb_Tipo.Text = cl.Endereco.Tipo;
            tb_Logradouro.Text = cl.Endereco.Logradouro;
            tb_Numero.Text = cl.Endereco.Numero.ToString();
            tb_Bairro.Text = cl.Endereco.Bairro;
            tb_Cidade.Text = cl.Endereco.Cidade;
            cb_Estado.Text = cl.Endereco.Estado;
            tb_Complemento.Text = cl.Endereco.Complemento;
            cb_Status.Text = cl.Status;
        }

        private void btn_Confirmar_Alterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja alterar este cliente?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (AtualizarTipoCliente())
                {
                    MessageBox.Show("Cliente atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar o cliente.");
                }
            }
        }

        //Atualiza os dados comuns a todos os clientes
        private Boolean AtualizarCliente()
        {
            bool sucesso = false;

            //Dados de Usuario
            string primeiroNome = tb_PrimeiroNome.Text;
            string sobrenome = tb_Sobrenome.Text;
            string cpf = tb_CpfCliente.Text;

            //Dados de Cliente
            string emailAntigo = cliente.Email;
            string estado_civil = cb_EstadoCivil.Text;
            string emailNovo = tb_Email.Text;
            string celular = tb_Celular.Text;
            string telefone = tb_Telefone.Text;
            string status = cb_Status.Text;

            //Dados de Endereco
            string cepAntigo = cliente.Endereco.Cep;
            string cepNovo = tb_Cep.Text;
            string tipo = cb_Tipo.Text;
            string logradouro = tb_Logradouro.Text;
            int numero = Convert.ToInt32(tb_Numero.Text);
            string bairro = tb_Bairro.Text;
            string cidade = tb_Cidade.Text;
            string estado = cb_Estado.Text;
            string complemento = tb_Complemento.Text;

            if (primeiroNome != "" && sobrenome != "" && cpf != ""
                && emailAntigo != "" && estado_civil != "" && emailNovo != "" && celular != "" && status != ""
                && cepAntigo != "" && cepNovo != "" && tipo != "" && logradouro != "" && numero > 0 && bairro != "" && cidade != "" && estado != "")
            {
                if (MySQLFunctions.AtualizarUsuario(primeiroNome, sobrenome, cpf) &&
                    MySQLFunctions.AtualizarCliente(emailAntigo, estado_civil, emailNovo, celular, telefone, status) &&
                    MySQLFunctions.AtualizarEndereco(cepAntigo, cepNovo, tipo, logradouro, numero, bairro, cidade, estado, complemento))
                {
                    sucesso = true;

                }
                else
                {
                    sucesso = false;
                }

            } else {
                sucesso = false;
                MessageBox.Show("Dados incorretos ou incompletos. Tente novamente.");
            }

            return sucesso;

        }

        //Atualiza apenas os dados relativos a Dependente
        private Boolean AtualizarDependente()
        {
            bool sucesso = false;

            if (AtualizarCliente())
            {
                sucesso = true;
            }

            return sucesso;
        }

        //Atualiza apenas os dados relativos a Pessoa Fisica
        private Boolean AtualizarPF()
        {
            bool sucesso = false;

            if (AtualizarCliente())
            {
                string cpf = tb_CpfCliente.Text;
                string profissao = tb_Profissao.Text;
                decimal rendaMensal = Convert.ToDecimal(tb_RendaMensal.Text);

                if (cpf != "" && profissao != "" && rendaMensal > 0)
                {
                    if (MySQLFunctions.AtualizarPF(profissao, rendaMensal, cpf))
                    {
                        sucesso = true;

                    }
                    else
                    {
                        sucesso = false;
                    }

                }
                else
                {
                    sucesso = false;
                }
            } else
            {
                sucesso = false;
            }
                return sucesso;
        }

        //Atualiza apenas os dados relativos a Pessoa Juridica
        private Boolean AtualizarPJ()
        {
            bool sucesso = false;

            if (AtualizarCliente())
            {
                string cpf = tb_CpfCliente.Text;
                string razaoSocial = tb_RazaoSocial.Text;

                if (cpf != "" && razaoSocial != "")
                {
                    if (MySQLFunctions.AtualizarPJ(razaoSocial, cpf))
                    {
                        sucesso = true;

                    }
                    else
                    {
                        sucesso = false;
                    }

                }
                else
                {
                    sucesso = false;
                }
            } else
            {
                sucesso = false;
            }

            return sucesso;
        }

        //Atualiza o cliente de acordo com seu tipo
        private Boolean AtualizarTipoCliente()
        {
            bool sucesso = false;

            if (cb_TipoCliente.Text == "Dependente")
            {
                if (AtualizarDependente())
                {
                    sucesso = true;
                }

            }
            else if (cb_TipoCliente.Text == "Titular Pessoa Física")
            {
                if (AtualizarPF())
                {
                    sucesso = true;
                }
            }
            else if (cb_TipoCliente.Text == "Titular Pessoa Jurídica")
            {
                if (AtualizarPJ())
                {
                    sucesso = true;
                }
            }
            else
            {
                MessageBox.Show("Tipo de Cliente incorreto!");
            }
            return sucesso;
        }
    }
}
