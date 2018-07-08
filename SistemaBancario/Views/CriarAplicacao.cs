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
    public partial class CriarAplicacao : SistemaBancario.Views.TemplateInicialCliente
    {
        InstanciaLogin il = new InstanciaLogin();

        public CriarAplicacao(InstanciaLogin il)
        {
            InitializeComponent();
            this.il = il;
            LabelAgencia = il.agencia;
            LabelConta = il.conta;
        }

        private void btn_Avancar_CriarAplicar_Click(object sender, EventArgs e)
        {
            List<Object> informacoes = new List<Object>();

            DateTime vencimento = Convert.ToDateTime(dtp_DataVencimento.Text).Date;

            informacoes.Add(tb_ValorInicial.Text);
            informacoes.Add(vencimento);

            ResumoAplicacao resumoAplicacao = new ResumoAplicacao(informacoes, this.il);
            resumoAplicacao.FormClosed += new FormClosedEventHandler(resumoAplicacao_FormClosed);
            resumoAplicacao.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void resumoAplicacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            AplicacoesCliente aplicacoes = new AplicacoesCliente(this.il);
            aplicacoes.FormClosed += new FormClosedEventHandler(aplicacoes_FormClosed);
            aplicacoes.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void aplicacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_ValorInicial.Text = "";
            dtp_DataVencimento.Value = DateTime.Today;
        }
    }
}
