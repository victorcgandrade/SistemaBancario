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
    public partial class VisualizarAplicacao : SistemaBancario.Views.TemplateInicialAdministrador
    {
        public VisualizarAplicacao(string idAplicacao)
        {
            InitializeComponent();

          /*  DataTable dadosAplicacao = MySQLFunctions.RetornarAplicacao(idAplicacao); //obtem todos os dados de um cliente

            if (dadosAplicacao != null) //se nao ocorreu erro na chamada da funcao acima
            {
            }
            else
            {
                MessageBox.Show("Algo deu errado. Tente novamente.");
            }*/
        }

        private void btn_RemoverAplicacao_Click(object sender, EventArgs e)
        {
            string idAplicacao = "";

            if (MessageBox.Show("Tem certeza que deseja cancelar esta aplicação? Ao confirmar, não será mais possível manipula-la.", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MySQLFunctions.CancelarAplicacao(idAplicacao))
                {
                    MessageBox.Show("Aplicação cancelada com sucesso!");

                    btn_AlterarAplicacao.Visible = false;
                    btn_CancelarAplicacao.Visible = false;
                }
                else
                {
                  MessageBox.Show("Não foi possível cancelar a aplicação!");
                }
            }
        }

        private void btn_AlterarAplicacao_Click(object sender, EventArgs e)
        {

        }
    }
}
