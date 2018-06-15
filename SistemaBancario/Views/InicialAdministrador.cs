using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class InicialAdministrador : SistemaBancario.Views.TemplateInicialAdministrador
    {
        public InicialAdministrador()
        {
            InitializeComponent();
        }

        //Botao para adicionar cliente - Codigo para fechar a tela aberta por um botao e tambem a tela que lhe deu origem
        private void btn_AdicionarCliente_Click(object sender, EventArgs e)
        {
            AdicionarCliente adicionarCliente = new AdicionarCliente();
            adicionarCliente.FormClosed += new FormClosedEventHandler(adicionarCliente_FormClosed); //Este Metodo ira lidar com o evento 'Close' na segunda tela
            adicionarCliente.Show();
            this.Hide();
        }

        //Quando a segunda tela for fechada, fecha-se tambem a tela que lhe deu origem
        private void adicionarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        //Botao para consultar cliente
        private void btn_ConsultarCliente_Click(object sender, EventArgs e)
        {
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.FormClosed += new FormClosedEventHandler(consultarCliente_FormClosed); 
            consultarCliente.Show();
            this.Hide();
        }

        //Quando a segunda tela for fechada, fecha-se tambem a tela que lhe deu origem
        private void consultarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        //Botao para listar cliente
        private void btn_ListarClientes_Click(object sender, EventArgs e)
        {
            ListarClientes listarCliente = new ListarClientes();
            listarCliente.FormClosed += new FormClosedEventHandler(listarCliente_FormClosed);
            listarCliente.Show();
            this.Hide();
        }

        //Quando a segunda tela for fechada, fecha-se tambem a tela que lhe deu origem
        private void listarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
