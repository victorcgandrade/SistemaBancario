using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class TemplateInicialCliente : Form
    {
        
        InstanciaLogin il;
        decimal saldo;
        public TemplateInicialCliente()
        {
            InitializeComponent();
            toolTipSaldo.SetToolTip(btnSaldo, "Exibe/Esconde saldo");
        }

        public TemplateInicialCliente(InstanciaLogin il)
        {
            saldo = MySQLFunctions.ConsultarSaldo(il.conta);
            InitializeComponent();
            this.il = il;
            preencheInformacaoCliente();
            toolTipSaldo.SetToolTip(btnSaldo, "Exibe/Esconde saldo");
        }

        private void preencheInformacaoCliente()
        {
            lb_NumAgencia.Text = il.agencia;
            lb_NumConta.Text = il.conta;
        }

   
        private void btnSaldo_Click(object sender, EventArgs e)
        {

            saldo = MySQLFunctions.ConsultarSaldo(il.conta);

            if (btnSaldo.Text == "Saldo") { 
            btnSaldo.Text = "R$ " + saldo.ToString();
            }
            else
            {
                btnSaldo.Text = "Saldo";
            }
        }

        private void btn_Pagamentos_Click(object sender, EventArgs e)
        {
            RealizarPagamento realizarPag = new RealizarPagamento();
            realizarPag.FormClosed += new FormClosedEventHandler(realizarPag_FormClosed);
            realizarPag.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void realizarPag_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_AgendamentoSaque_Click(object sender, EventArgs e)
        {
            RealizarAgendamentoSaque realizarSaque = new RealizarAgendamentoSaque();
            realizarSaque.FormClosed += new FormClosedEventHandler(realizarSaque_FormClosed);
            realizarSaque.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void realizarSaque_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_Investimentos_Click(object sender, EventArgs e)
        {
            Investimentos investimentos = new Investimentos();
            investimentos.FormClosed += new FormClosedEventHandler(investimentos_FormClosed);
            investimentos.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void investimentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
