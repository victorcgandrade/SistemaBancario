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
    public partial class RealizarAgendamentoSaque : SistemaBancario.Views.TemplateInicialCliente
    {
        public RealizarAgendamentoSaque(InstanciaLogin il)
        {
            InitializeComponent();
            LabelAgencia = il.agencia;
            LabelConta = il.conta;
        }

        private void btn_Confirmar_AgendarSaque_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja realizar este saque?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                decimal valor = Convert.ToDecimal(tb_Valor.Text);
                int numConta = Convert.ToInt32(tb_NumConta.Text);
                DateTime dataSaque = dtp_DataAgendamento.Value;
                string beneficiario = tb_Beneficiario.Text;

                if (MySQLFunctions.RealizarAgendamentoSaque(valor, numConta, dataSaque, beneficiario))
                {
                    MessageBox.Show("Agendamento de saque cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível agendar este saque.");
                }
            }
        }
    }
}
