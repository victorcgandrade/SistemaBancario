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
    public partial class ResumoPagamento : SistemaBancario.Views.TemplateInicialCliente
    {
        public ResumoPagamento (List<String> informacoes, InstanciaLogin il)
        {
            InitializeComponent();
            carregarPagamento(informacoes, il);
        }

        private void carregarPagamento(List<String> informacoes, InstanciaLogin il)
        {
            lb_CodBarras.Text = informacoes[0];
            lb_NumAgenciaConta.Text = il.conta + "-" + il.agencia;
            lb_NumBancoDest.Text = informacoes[3];
            lb_Valor.Text = informacoes[4];
        }

        private void btn_ConfirmarPagamento_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja realizar este pagamento?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string numBoleto = lb_CodBarras.Text;
                decimal valor = Convert.ToDecimal(lb_Valor.Text);
                int numeroConta = Convert.ToInt32(lb_NumAgenciaConta.Text.Substring(0, 2).ToString());
                string codBanco = lb_NumBancoDest.Text.Substring(0, 3);

                if (MySQLFunctions.RealizarPagamento(numBoleto, valor, numeroConta, codBanco))
                {
                    MessageBox.Show("Pagamento realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o pagamento.");
                }
            }
        }
    }
}
