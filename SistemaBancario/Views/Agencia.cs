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
    }
}
