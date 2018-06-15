using System;
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
            this.Hide();
            Agencia agencia = new Agencia();
            agencia.Show();
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
