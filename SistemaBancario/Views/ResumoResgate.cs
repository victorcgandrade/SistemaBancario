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
    public partial class ResumoResgate : SistemaBancario.Views.TemplateInicialCliente
    {
        InstanciaLogin il = new InstanciaLogin();
        Aplicacao aplicacao = new Aplicacao();

        public ResumoResgate(Aplicacao aplicacao, InstanciaLogin il, string valorResgatar)
        {
            InitializeComponent();
            this.il = il;
            this.aplicacao = aplicacao;
            LabelAgencia = il.agencia;
            LabelConta = il.conta;
            carregarResgate(aplicacao, valorResgatar);
        }

        private void carregarResgate(Aplicacao aplicacao, string valorResgatar)
        {
            lb_DataInicialAplicacao.Text = aplicacao.DataInicio.Date.ToString();
            lb_ValorResgate.Text = valorResgatar;

        }

        private void btn_ConfirmarResgate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja realizar este resgate?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                decimal valorResgate = Convert.ToDecimal(lb_ValorResgate.Text);
                int numeroConta = Convert.ToInt32(lblConta.Text);

                if (MySQLFunctions.ResgatarValorAplicacao(numeroConta, aplicacao.Id, valorResgate, (aplicacao.ValorResgate - valorResgate)))
                {
                    MessageBox.Show("Resgate realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar este resgate.");
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            RealizarResgate realizarResgate = new RealizarResgate(aplicacao.Id, this.il);
            realizarResgate.FormClosed += new FormClosedEventHandler(realizarResgate_FormClosed);
            realizarResgate.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void realizarResgate_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
