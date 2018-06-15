using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class InicialAdministradorAplicacao : SistemaBancario.Views.TemplateInicialAdministrador
    {
        public InicialAdministradorAplicacao()
        {
            InitializeComponent();
        }

        private void btn_ConsultarAplicacao_Click(object sender, EventArgs e)
        {
            ConsultarAplicacao consultarAplicacao = new ConsultarAplicacao();
            consultarAplicacao.FormClosed += new FormClosedEventHandler(consultarAplicacao_FormClosed);
            consultarAplicacao.Show();
            this.Hide();
        }

        //Quando a segunda tela for fechada, fecha-se tambem a tela que lhe deu origem
        private void consultarAplicacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_ListarAplicacao_Click(object sender, EventArgs e)
        {
            ListarAplicacoes listarAplicacoes = new ListarAplicacoes();
            listarAplicacoes.FormClosed += new FormClosedEventHandler(listarAplicacoes_FormClosed);
            listarAplicacoes.Show();
            this.Hide();
        }

        //Quando a segunda tela for fechada, fecha-se tambem a tela que lhe deu origem
        private void listarAplicacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}

