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
    public partial class VisualizarCliente : SistemaBancario.Views.TemplateInicialAdministrador
    {

        private Cliente cliente; //variavel global para ser reaproveitada ao longo do codigo

        public VisualizarCliente(int idBusca)
        {
            InitializeComponent();
            carregarCliente(idBusca);
        }

        private void carregarCliente(int idBusca)
        {
            cliente = MySQLFunctions.RetornarCliente(idBusca); //obtem todos os dados de um cliente

            lb_NomeSobrenome.Text = cliente.NomeCompleto();

            if (cliente != null)
            {
                //campos comuns a todos os clientes
                tb_Visualizar_Nome.Text = cliente.PrimeiroNome;
                tb_Visualizar_Sobrenome.Text = cliente.Sobrenome;
                tb_Visualizar_DataNasc.Text = cliente.DataNascimento.Date.ToString();
                tb_Visualizar_EstadoCivil.Text = cliente.Estado_civil;

                tb_Visualizar_CPF.Text = cliente.Cpf;
                tb_Visualizar_RG.Text = cliente.Rg;

                tb_Visualizar_Email.Text = cliente.Email;
                tb_Visualizar_Celular.Text = cliente.Celular;
                tb_Visualizar_Tel.Text = cliente.Telefone;

                tb_Visualizar_CEP.Text = cliente.Endereco.Cep;
                tb_Visualizar_TipoLograd.Text = cliente.Endereco.Tipo;
                tb_Visualizar_Lograd.Text = cliente.Endereco.Logradouro;
                tb_Visualizar_Numero.Text = cliente.Endereco.Numero.ToString();
                tb_Visualizar_Bairro.Text = cliente.Endereco.Bairro;
                tb_Visualizar_Cidade.Text = cliente.Endereco.Cidade;
                tb_Visualizar_Estado.Text = cliente.Endereco.Estado;
                tb_Visualizar_Complemento.Text = cliente.Endereco.Complemento;

                tb_Visualizar_Status.Text = cliente.Status;
                tb_Visualizar_DataCadas.Text = cliente.DataCadastro.Date.ToString();

                if (cliente is Dependente)
                {
                    Dependente dependente = new Dependente();

                    dependente = (Dependente) cliente;

                    tb_Visualizar_TpCliente.Text = "Dependente";
                    lb_Titular.Visible = true;
                    lb_CpfResponsavel.Visible = true;
                    tb_Visualizar_CPFTitular.Visible = true;
                   // tb_Visualizar_CPFTitular.Text = dependente.Titular.Cpf;
                }
                else if (cliente is PessoaFisica)
                {
                    PessoaFisica pf = new PessoaFisica();

                    pf = (PessoaFisica) cliente;

                    tb_Visualizar_TpCliente.Text = "Pessoa Física";
                    lb_Economica.Visible = true;
                    lb_Profissao.Visible = true;
                    lb_RendaMensal.Visible = true;
                    tb_Visualizar_Profissao.Visible = true;
                    tb_Visualizar_Profissao.Text = pf.Profissao;
                    tb_Visualizar_Renda.Visible = true;
                    tb_Visualizar_Renda.Text = pf.RendaMensal.ToString();
                }
                else if (cliente is PessoaJuridica)
                {
                    PessoaJuridica pj = new PessoaJuridica();

                    pj = (PessoaJuridica) cliente;

                    tb_Visualizar_TpCliente.Text = "Pessoa Jurídica";
                    lb_Juridica.Visible = true;
                    lb_RazaoSocial.Visible = true;
                    tb_Visualizar_RazaoSocial.Visible = true;
                    tb_Visualizar_RazaoSocial.Text = pj.RazaoSocial;
                    lb_Cnpj.Visible = true;
                    tb_Visualizar_CNPJ.Visible = true;
                    tb_Visualizar_CNPJ.Text = pj.Cnpj;
                    lb_Tipo_CNPJ.Visible = true;
                    tb_Visualizar_TpCNPJ.Visible = true;
                    tb_Visualizar_TpCNPJ.Text = pj.Tipo;
                }
            }     
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            string cpf = cliente.Cpf;

            if (MessageBox.Show("Tem certeza que deseja inativar este cliente?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MySQLFunctions.InativarCliente(cpf))
                {
                    MessageBox.Show("Cliente inativado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível inativar o cliente!");
                }
            }
        }

        //Quando o botao de alterar cliente for clicado
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            AlterarCliente alterarCliente = new AlterarCliente(cliente);
            alterarCliente.FormClosed += new FormClosedEventHandler(alterarCliente_FormClosed);
            alterarCliente.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void alterarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
