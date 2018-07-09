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
    public partial class InicialResgate : SistemaBancario.Views.TemplateInicialCliente
    {
        InstanciaLogin il = new InstanciaLogin();

        public InicialResgate(InstanciaLogin il)
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
                dgv_AplicacoesCliente.DataSource = listagemAplicacoes;
                dgv_AplicacoesCliente.Columns["Identificador"].Visible = false;

            }
            else
            {
                MessageBox.Show("Algo deu errado.");
            }
        }

        private void btn_Avancar_Resgate_Click(object sender, EventArgs e)
        {
            int index_cur_row = dgv_AplicacoesCliente.CurrentRow.Index; //capturando o indice da linha selecionada
            DataGridViewRow cur_row = dgv_AplicacoesCliente.Rows[index_cur_row]; //variavel dessa linha

            string idAplicacao = cur_row.Cells["Identificador"].Value.ToString();

            RealizarResgate realizarResgate = new RealizarResgate(Convert.ToInt32(idAplicacao), this.il);
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
