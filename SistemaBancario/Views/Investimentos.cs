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
    public partial class Investimentos : TemplateInicialCliente
    {
        public Investimentos()
        {
            InitializeComponent();
        }

        private void Investimentos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aplicacoes_Click(object sender, EventArgs e)
        {
            AplicacoesCliente aplicacoes = new AplicacoesCliente();
            aplicacoes.FormClosed += new FormClosedEventHandler(aplicacoes_FormClosed);
            aplicacoes.Show();
            this.Hide();
        }

        //Quando a tela de for fechada, fecha-se tambem a tela que lhe deu origem
        private void aplicacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_Resgate_Click(object sender, EventArgs e)
        {

        }
    }
}
