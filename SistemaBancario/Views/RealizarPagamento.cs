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

        public RealizarPagamento()
        {
            InitializeComponent();
        }

        private void btn_AvancarResumoPagamento_Click(object sender, EventArgs e)
        {
            //Lista de informacoes do pagamento para, posteriormente, exibir na tela do resumo 
            List<String> informacoes = new List<string>();
            informacoes.Add(tb_Boleto.Text);
            informacoes.Add(cb_BancoDestino.Text);
            informacoes.Add(tb_Valor.Text);

            //Chama tela de resumo de pagamento
          //  ResumoPagamento resumoPag = new ResumoPagamento(informacoes);
         //   resumoPag.FormClosed += new FormClosedEventHandler(resumoPag_FormClosed);
         //   resumoPag.Show();
        //    this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void resumoPag_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
}
}
