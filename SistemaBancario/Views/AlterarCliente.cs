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
    public partial class AlterarCliente : SistemaBancario.Views.AdicionarCliente
    {
        public AlterarCliente(Cliente cl)
        {
            InitializeComponent();

            inicializarCliente(cl);

            if (cl is Dependente)
            {
                Dependente dp = (Dependente) cl;

                inicializarDependente(dp);

            } else if (cl is PessoaFisica)
            {
                PessoaFisica pf = (PessoaFisica)cl;
                inicializarPF(pf);

            } else if (cl is PessoaJuridica)
            {
                PessoaJuridica pj = (PessoaJuridica)cl;
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

        //Botao confirmar ao ser clicado
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
