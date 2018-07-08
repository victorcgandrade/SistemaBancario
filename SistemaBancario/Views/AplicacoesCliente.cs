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
        public AplicacoesCliente()
        {
            InitializeComponent();
        }

        private void btn_CriarAplicacao_Click(object sender, EventArgs e)
        {
            CriarAplicacao criarAplicacao = new CriarAplicacao();
            criarAplicacao.FormClosed += new FormClosedEventHandler(criarAplicacao_FormClosed);
            criarAplicacao.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void criarAplicacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
