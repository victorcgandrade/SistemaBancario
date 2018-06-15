using System;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class Agencia : Form
    {
        public Agencia()
        {
            InitializeComponent();
        }

        private void buttonCriarAgencia_Click(object sender, EventArgs e)
        {
            CriarAgencia formCriarAgencia = new CriarAgencia();
            formCriarAgencia.Show();
        }

        private void buttonListarAgencia_Click(object sender, EventArgs e)
        {
            ListarAgencia formListarAgencia = new ListarAgencia();
            formListarAgencia.Show();
        }

        private void buttonRemoverAgencia_Click(object sender, EventArgs e)
        {
            RemoverAgencia formListarAgencia = new RemoverAgencia();
            formListarAgencia.Show();
        }

        private void buttonAlterarAgencia_Click(object sender, EventArgs e)
        {
            AlterarAgencia formAlterarAgencia = new AlterarAgencia();
            formAlterarAgencia.Show();
        }

        private void btn_Retornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TemplateInicialAdministrador tia = new TemplateInicialAdministrador();
            tia.Show();
        }
    }
}
