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
    public partial class RealizarResgate : SistemaBancario.Views.TemplateInicialCliente
    {
        Aplicacao aplicacao = new Aplicacao();

        InstanciaLogin il = new InstanciaLogin();

        public RealizarResgate(int idAplicacao, InstanciaLogin il)
        {
            InitializeComponent();
            this.il = il;
            LabelAgencia = il.agencia;
            LabelConta = il.conta;
            carregarAplicacao(idAplicacao);
        }

       public void carregarAplicacao(int idAplicacao)
       {
            Aplicacao aplicacao = MySQLFunctions.RetornarAplicacao(idAplicacao);

            if (aplicacao != null)
            {
                lb_DataAplicacao.Text = aplicacao.DataInicio.ToString();
                lb_ValorResgate.Text = string.Format("{0:N}", aplicacao.ValorResgate);
                tb_ValorResgatar.Text = string.Format("{0:N}", aplicacao.ValorResgate);
                this.aplicacao = aplicacao;
                MySQLFunctions.AtualizarValorResgateAplicacao(aplicacao.Id, aplicacao.ValorResgate);
            }
            else
            {
                MessageBox.Show("Não foi possível carregar a aplicação.");
            }
       }

        private void rb_ResgateParcial_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ResgateParcial.Checked)
            {
                rb_ResgateTotal.Checked = false;
                tb_ValorResgatar.Enabled = true;
                tb_ValorResgatar.BackColor = System.Drawing.SystemColors.Window;
            } 
            else
            {
                rb_ResgateTotal.Checked = true;
                tb_ValorResgatar.Enabled = false;
                tb_ValorResgatar.BackColor = System.Drawing.SystemColors.InactiveCaption;
                tb_ValorResgatar.Text = string.Format("{0:N}", aplicacao.ValorResgate);
            }
        }

        private void rb_ResgateTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ResgateTotal.Checked)
            {
                rb_ResgateParcial.Checked = false;
                tb_ValorResgatar.Enabled = false;
                tb_ValorResgatar.BackColor = System.Drawing.SystemColors.InactiveCaption;
                tb_ValorResgatar.Text = string.Format("{0:N}", aplicacao.ValorResgate);
            }
            else
            {
                rb_ResgateParcial.Checked = true;
                tb_ValorResgatar.Enabled = true;
                tb_ValorResgatar.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void btn_Avancar_ResgatarAplicacao_Click(object sender, EventArgs e)
        {
            //Chama tela de resumo de pagamento
            ResumoResgate resumoResg = new ResumoResgate(aplicacao, this.il, tb_ValorResgatar.Text);
            resumoResg.FormClosed += new FormClosedEventHandler(resumoResg_FormClosed);
            resumoResg.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void resumoResg_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
