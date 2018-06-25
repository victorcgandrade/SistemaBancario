using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class TemplateInicialAdministrador : Form
    {
        public TemplateInicialAdministrador()
        {
            InitializeComponent();
        }

        //Botao para a tela de Aplicacoes
        private void btn_Aplicacoes_Click(object sender, EventArgs e)
        {
            InicialAdministradorAplicacao inicialAplicacao = new InicialAdministradorAplicacao();
            inicialAplicacao.FormClosed += new FormClosedEventHandler(inicialAplicacao_FormClosed);
            inicialAplicacao.Show();
            this.Hide();
        }

        //Quando a segunda tela for fechada, fecha-se tambem a tela que lhe deu origem
        private void inicialAplicacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        //Botao para a tela de Clientes
        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            InicialAdministrador inicialClientes = new InicialAdministrador();
            inicialClientes.FormClosed += new FormClosedEventHandler(inicialClientes_FormClosed);
            inicialClientes.Show();
            this.Hide();
        }

        //Quando a segunda tela for fechada, fecha-se tambem a tela que lhe deu origem
        private void inicialClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
