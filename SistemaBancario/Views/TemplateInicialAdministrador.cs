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
    }
}
