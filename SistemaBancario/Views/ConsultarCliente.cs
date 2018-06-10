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
    public partial class ConsultarCliente : SistemaBancario.Views.TemplateInicialAdministrador
    {
        public ConsultarCliente()
        {
            InitializeComponent();
            dgv_ResultadoBuscaCliente.Visible = false; //campo para resultado da busca, inicialmente, escondido
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
                    dgv_ResultadoBuscaCliente.Columns[0].HeaderText = "Identificador";
                    dgv_ResultadoBuscaCliente.Columns[1].HeaderText = "Primeiro nome";
                    dgv_ResultadoBuscaCliente.Columns[2].HeaderText = "Data de nascimento";
                    dgv_ResultadoBuscaCliente.Columns[3].HeaderText = "Status";

                    dgv_ResultadoBuscaCliente.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("CPF inválido!");
            }
        }
    }
}
