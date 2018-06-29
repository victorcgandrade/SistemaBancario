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
    public partial class TelaInicialAdministradorConta : TemplateInicialAdministrador
    {
        public TelaInicialAdministradorConta()
        {
            InitializeComponent();
        }

        //Botao para abrir a tela de adicionar conta
        private void btn_AdicionarConta_Click(object sender, EventArgs e)
        {
            AdicionarConta adicionarConta = new AdicionarConta();
            adicionarConta.FormClosed += new FormClosedEventHandler(adicionarConta_FormClosed);
            adicionarConta.Show();
            this.Hide();
        }

        //Quando a segunda tela for fechada, fecha-se tambem a tela que lhe deu origem
        private void adicionarConta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        //Botao para abrir a tela de consultar conta
        private void btn_ConsultarConta_Click(object sender, EventArgs e)
        {
            ConsultarConta consultarConta = new ConsultarConta();
            consultarConta.FormClosed += new FormClosedEventHandler(consultarConta_FormClosed);
            consultarConta.Show();
            this.Hide();
        }

        //Quando a segunda tela for fechada, fecha-se tambem a tela que lhe deu origem
        private void consultarConta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_ListarContas_Click(object sender, EventArgs e)
        {

        }

    }
}
