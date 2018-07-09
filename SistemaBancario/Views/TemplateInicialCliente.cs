using Main;
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
        
        InstanciaLogin il= new InstanciaLogin(TelaLogin._agenciaContext, TelaLogin._contaContext);
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
            toolTipSaldo.SetToolTip(btnSaldo, "Exibe/Esconde saldo");
            lblConta.Text = il.conta;
            lblAgencia.Text = il.agencia;
        }

        public string LabelConta
        {
            get
            {
                return lblConta.Text;
            }
            set
            {
                lblConta.Text = value;
            }
        }

        public string LabelAgencia
        {
            get
            {
                return lblAgencia.Text;
            }
            set
            {
                lblAgencia.Text = value;
            }
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
            RealizarPagamento realizarPag = new RealizarPagamento(this.il);
            realizarPag.FormClosed += new FormClosedEventHandler(realizarPag_FormClosed);
            realizarPag.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void realizarPag_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_Atendimento_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaAtendimento ta = new TelaAtendimento(this.il);
            ta.Show();
        }

        private void btn_Extrato_Click(object sender, EventArgs e)
        {
            ListarPagamentos l = new ListarPagamentos(this.il);
            l.Show();
            this.Hide();
        }

        private void btn_AgendamentoSaque_Click(object sender, EventArgs e)
        {
            RealizarAgendamentoSaque realizarSaque = new RealizarAgendamentoSaque(this.il);
            realizarSaque.FormClosed += new FormClosedEventHandler(realizarSaque_FormClosed);
            realizarSaque.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void realizarSaque_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_Tranferencias_Click(object sender, EventArgs e)
        {
            TelaTransferencia tt = new TelaTransferencia(this.il);
            this.Hide();
            tt.Show();
        }
    }
}
