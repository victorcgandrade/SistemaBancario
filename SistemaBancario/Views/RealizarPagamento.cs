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
    public partial class RealizarPagamento : SistemaBancario.Views.TemplateInicialCliente
    {
        InstanciaLogin LoginAtual; //refere-se a sessao atual de login 
        
        public RealizarPagamento(InstanciaLogin il)
        {
            InitializeComponent();
            LoginAtual = il;
            tb_NumeroAgencia.Text = LoginAtual.agencia;
            tb_NumeroConta.Text = LoginAtual.conta;
            LabelConta = il.conta;
            LabelAgencia = il.agencia;
        }

        private void btn_AvancarResumoPagamento_Click(object sender, EventArgs e)
        {
            //Lista de informacoes do pagamento para, posteriormente, exibir na tela do resumo 
            List<String> informacoes = new List<string>();
            informacoes.Add(tb_Boleto.Text);
            informacoes.Add(LoginAtual.agencia);
            informacoes.Add(LoginAtual.conta);
            informacoes.Add(cb_BancoDestino.Text);
            informacoes.Add(tb_Valor.Text);

            ResumoPagamento resumoPag = new ResumoPagamento(informacoes, LoginAtual);
            resumoPag.FormClosed += new FormClosedEventHandler(resumoPag_FormClosed);
            resumoPag.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void resumoPag_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
}
}
