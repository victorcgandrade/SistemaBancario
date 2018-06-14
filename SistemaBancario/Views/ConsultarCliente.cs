﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaBancario.Models;

namespace SistemaBancario.Views
{
    public partial class ConsultarCliente : SistemaBancario.Views.TemplateInicialAdministrador
    {
        public ConsultarCliente()
        {
            InitializeComponent();
            dgv_ResultadoBuscaCliente.Visible = false; //campo para resultado da busca, inicialmente, escondido
            btn_VisualizarCliente.Visible = false;
        }

        //Metodo quando botao de busca eh clicado
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string cpfBusca = tb_CampoBusca.Text;

            if (cpfBusca != "")
            {
                if(MySQLFunctions.BuscarCliente(dgv_ResultadoBuscaCliente, cpfBusca))
                {
                    //Nomeacao das colunas
                    dgv_ResultadoBuscaCliente.Columns[0].HeaderText = "Identificador"; //nome para exibicao
                    dgv_ResultadoBuscaCliente.Columns[0].Name = "Identificador"; //nome para manipulacao

                    dgv_ResultadoBuscaCliente.Columns[1].HeaderText = "Primeiro nome";
                    dgv_ResultadoBuscaCliente.Columns[1].Name = "Primeiro nome";

                    dgv_ResultadoBuscaCliente.Columns[2].HeaderText = "Data de nascimento";
                    dgv_ResultadoBuscaCliente.Columns[2].Name = "Data de nascimento";

                    dgv_ResultadoBuscaCliente.Columns[3].HeaderText = "Status";
                    dgv_ResultadoBuscaCliente.Columns[3].Name = "Status";

                    dgv_ResultadoBuscaCliente.Visible = true;
                    btn_VisualizarCliente.Visible = true;
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar a busca. Certifique-se de que digitou corretamente e tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("Insira um nome ou cpf para que a busca seja realizada.");
            }
        }

        //Metodo para chamar a tela de Visualizar Cliente (botao Visualizar)
        private void btn_VisualizarCliente_Click(object sender, EventArgs e)
        {
            int index_cur_row = dgv_ResultadoBuscaCliente.CurrentRow.Index; //capturando o indice da linha selecionada
            DataGridViewRow cur_row = dgv_ResultadoBuscaCliente.Rows[index_cur_row]; //variavel dessa linha

            string idCliente = cur_row.Cells["Identificador"].Value.ToString();

            VisualizarCliente visualizarCliente = new VisualizarCliente(idCliente);
            visualizarCliente.FormClosed += new FormClosedEventHandler(visualizarCliente_FormClosed);
            visualizarCliente.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void visualizarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
