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
    public partial class ConsultarConta : SistemaBancario.Views.TemplateInicialAdministrador
    {
        public ConsultarConta()
        {
            InitializeComponent();
        }

        private void btn_BuscarConta_Click(object sender, EventArgs e)
        {
            string numeroBusca = tb_CampoBuscaConta.Text;

            if (numeroBusca != "")
            {
                DataTable resultadoBuscaConta = new DataTable();
                resultadoBuscaConta = MySQLFunctions.BuscarConta(numeroBusca);

                if (resultadoBuscaConta != null)
                {

                    dgv_ResultadoBuscaConta.DataSource = resultadoBuscaConta;

                    dgv_ResultadoBuscaConta.Visible = true;
                    lb_InformativoVisualizarConta.Visible = true;
                    btn_VisualizarConta.Visible = true;
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar a busca. Certifique-se de que digitou corretamente e tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("Insira um valor válido para que a busca seja realizada.");
            }
        }

        private void btn_VisualizarConta_Click(object sender, EventArgs e)
        {
            int index_cur_row = dgv_ResultadoBuscaConta.CurrentRow.Index; //capturando o indice da linha selecionada
            DataGridViewRow cur_row = dgv_ResultadoBuscaConta.Rows[index_cur_row]; //linha selecionada

            string idAplicacao = cur_row.Cells["Identificador"].Value.ToString();

            VisualizarConta visualizarConta = new VisualizarConta();
            visualizarConta.FormClosed += new FormClosedEventHandler(visualizarConta_FormClosed);
            visualizarConta.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void visualizarConta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
