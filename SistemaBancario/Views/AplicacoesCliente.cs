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
    public partial class AplicacoesCliente : SistemaBancario.Views.TemplateInicialCliente
    {
        InstanciaLogin il = new InstanciaLogin();

        public AplicacoesCliente(InstanciaLogin il)
        {
            InitializeComponent();
            this.il = il;
            LabelAgencia = il.agencia;
            LabelConta = il.conta;

        }

        private void btn_CriarAplicacao_Click(object sender, EventArgs e)
        {
            CriarAplicacao criarAplicacao = new CriarAplicacao(this.il);
            criarAplicacao.FormClosed += new FormClosedEventHandler(criarAplicacao_FormClosed);
            criarAplicacao.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void criarAplicacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultarAplicacao_Click(object sender, EventArgs e)
        {
            ListarAplicacoesCliente listarAplicacao = new ListarAplicacoesCliente(this.il);
            listarAplicacao.FormClosed += new FormClosedEventHandler(listarAplicacao_FormClosed);
            listarAplicacao.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void listarAplicacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
