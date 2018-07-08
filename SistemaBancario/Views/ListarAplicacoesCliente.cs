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
        public ListarAplicacoesCliente(InstanciaLogin il)
        {
            InitializeComponent();
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

                dgv_ResultadoAplicacoesCliente.Visible = true;
                lb_InformativoVisualizarAp.Visible = true;
                btn_VisualizarAplicacaoCliente.Visible = true;

            }
            else
            {
                MessageBox.Show("Algo deu errado.");
            }
        }

        private void btn_VisualizarAplicacaoCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
