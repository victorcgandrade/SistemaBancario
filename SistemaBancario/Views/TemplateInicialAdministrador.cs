using Main;
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
    public partial class TemplateInicialAdministrador : SistemaBancarioTela
    {
        public TemplateInicialAdministrador()
        {
            InitializeComponent();
        }

        private void pb_IconeAgencias_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void p_Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            SairUsuario(this);

        }

        private void btn_Contas_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicialAdministradorConta tlac = new TelaInicialAdministradorConta();
            tlac.Show();
        }
    }
}
