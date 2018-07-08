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
    public partial class Extrato : SistemaBancario.Views.TemplateInicialCliente
    {
        InstanciaLogin il = new InstanciaLogin();
        public Extrato(InstanciaLogin il)
        {
            InitializeComponent();
            this.il = il;
            LabelConta = il.conta;
            LabelAgencia = il.agencia;
        }

        private void btn_VisualizarComprovantes_Click(object sender, EventArgs e)
        {
            ListarPagamentos listarPagamentos = new ListarPagamentos(this.il);
            listarPagamentos.Show();
        }
    }
}
