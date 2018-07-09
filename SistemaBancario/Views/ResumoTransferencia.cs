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
    public partial class ResumoTransferencia : TemplateInicialCliente
    {
        InstanciaLogin LoginAtual = new InstanciaLogin();
        List<string> _info = new List<string>();
        public ResumoTransferencia(InstanciaLogin il, List<string> infoTransf)
        {
            InitializeComponent();
            LoginAtual = il;
            carregarPagamento(infoTransf, il);
            LabelAgencia = il.agencia;
            LabelConta = il.conta;
            _info = infoTransf;
        }

        private void carregarPagamento(List<String> informacoes, InstanciaLogin il)
        {
            if (informacoes[0].Equals("Banco A&A"))
            {
                lblBancoDestino.Text = informacoes[0].ToString();
            }
            else
            {
                lblBancoDestino.Text = informacoes[7].ToString();
            }
            lblContaDestino.Text = informacoes[3].ToString();
            lblValor.Text = informacoes[5].ToString();
            dtpTransferencia.Value = Convert.ToDateTime(informacoes[4]);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Operação cancelada com sucesso!");
            TemplateInicialCliente tic = new TemplateInicialCliente(LoginAtual);
            tic.Show();
        }

        private void btnConfirmarTransf_Click(object sender, EventArgs e)
        {
            if (_info[0].Equals("Banco A&A"))
            {
                if (MySQLFunctions.RealizarTransferenciaEsteBanco(_info[1], _info[2], _info[3], Convert.ToDateTime(_info[4]), Convert.ToDecimal(_info[5])))
                {
                    MessageBox.Show("Transferência realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro na operação");
                }
            }
            else
            {
                if (MySQLFunctions.RealizarTransferenciaOutroBanco(_info[1], _info[2], Convert.ToDateTime(_info[4]), Convert.ToDecimal(_info[5]), _info[6], _info[7], _info[3]))
                {
                    MessageBox.Show("Transferência realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro na operação");
                }
            }
        }
    }
}
