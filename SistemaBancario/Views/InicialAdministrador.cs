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

        //Codigo para fechar a tela aberta por um botao e tambem a tela que lhe deu origem
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


    }
}
