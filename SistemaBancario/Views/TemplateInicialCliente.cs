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
    public partial class TemplateInicialCliente : Form
    {
        
        InstanciaLogin il;
        decimal saldo;
        public TemplateInicialCliente()
        {
            InitializeComponent();
            toolTipSaldo.SetToolTip(btnSaldo, "Exibe/Esconde saldo");
        }

        public TemplateInicialCliente(InstanciaLogin il)
        {
            saldo = MySQLFunctions.ConsultarSaldo(il);
            InitializeComponent();
            this.il = il;
            toolTipSaldo.SetToolTip(btnSaldo, "Exibe/Esconde saldo");
        }

   
        private void btnSaldo_Click(object sender, EventArgs e)
        {
            if (btnSaldo.Text == "Saldo") { 
            btnSaldo.Text = "R$ " + saldo.ToString();
            }
            else
            {
                btnSaldo.Text = "Saldo";
            }
        }

        private void btn_Atendimento_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaAtendimento ta = new TelaAtendimento();
            ta.Show();
        }
    }
}
