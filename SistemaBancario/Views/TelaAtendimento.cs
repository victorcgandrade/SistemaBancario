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
    public partial class TelaAtendimento : TemplateInicialCliente
    {
        public TelaAtendimento()
        {
            InitializeComponent();
        }

        private void btnAgencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaBuscarAgencia tba = new TelaBuscarAgencia();
            tba.Show();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFAQ tf = new TelaFAQ();
            tf.Show();
        }
    }
}
