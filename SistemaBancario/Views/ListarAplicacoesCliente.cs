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
    public partial class ListarAplicacoesCliente : SistemaBancario.Views.TemplateInicialCliente
    {
        InstanciaLogin il = new InstanciaLogin();

        public ListarAplicacoesCliente(InstanciaLogin il)
        {
            InitializeComponent();
            this.il = il;
            LabelAgencia = il.agencia;
            LabelConta = il.conta;
            carregarTabelaAplicacoes();
        }

        private void carregarTabelaAplicacoes()
        {
            DataTable listagemAplicacoes = new DataTable();

            listagemAplicacoes = MySQLFunctions.ListarAplicacaoCliente(Convert.ToInt32(lblConta.Text));

            if (listagemAplicacoes != null)
            {
                dgv_ResultadoAplicacoesCliente.DataSource = listagemAplicacoes;
                dgv_ResultadoAplicacoesCliente.Columns["Identificador"].Visible = false;

                dgv_ResultadoAplicacoesCliente.Visible = true;
                btn_Retornar.Visible = true;

            }
            else
            {
                MessageBox.Show("Algo deu errado.");
            }
        }

        private void btn_Retornar_Click(object sender, EventArgs e)
        {
            AplicacoesCliente aplicacoes = new AplicacoesCliente(this.il);
            aplicacoes.FormClosed += new FormClosedEventHandler(aplicacoes_FormClosed);
            aplicacoes.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void aplicacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
