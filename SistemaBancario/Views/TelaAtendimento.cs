using SistemaBancario.Models;
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
        InstanciaLogin LoginAtual;
        public TelaAtendimento()
        {
            InitializeComponent();
        }

        public TelaAtendimento(InstanciaLogin il)
        {
            InitializeComponent();
            LoginAtual = il;
            LabelConta= il.conta;
            LabelAgencia = il.agencia;
        }

        private void btnAgencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaBuscarAgencia tba = new TelaBuscarAgencia(LoginAtual);
            tba.Show();
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFAQ tf = new TelaFAQ(LoginAtual);
            tf.Show();
        }
    }
}
