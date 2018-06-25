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
    public partial class FormularioCliente : SistemaBancario.Views.TemplateInicialAdministrador
    {
        public FormularioCliente()
        {
            InitializeComponent();
            
            //Valores das comboboxes abaixo ja selecionados
            cb_Status.SelectedItem = "Ativo";
            cb_TipoCliente.SelectedItem = "Titular Pessoa Física";
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

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
