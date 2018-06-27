using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;
using MySql.Data.MySqlClient;
using SistemaBancario.Models;

namespace SistemaBancario.Views
{
    public partial class TelaSenhaCliente : Form
    {
        string senha;
        string _numeroConta;
        public TelaSenhaCliente()
        {
            InitializeComponent();

        }

        public TelaSenhaCliente(string numeroConta)
        {
            InitializeComponent();
            _numeroConta = numeroConta;
        }

        public void preencheNome()
        {

        }
        public bool ChecaTextBoxes()
        {
            if (txtPrimeiroCaracter.Text == "")
            {
                txtPrimeiroCaracter.Text = "*";

            }
            else if (txtSegundoCaracter.Text == "")
            {
                txtSegundoCaracter.Text = "*";

            }
            else if (txtTerceiroCaracter.Text == "")
            {
                txtTerceiroCaracter.Text = "*";

            }
            else if (txtQuartoCaracter.Text == "")
            {
                txtQuartoCaracter.Text = "*";
                return true;
            }

            return true;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            senha = senha + "3";
            ChecaTextBoxes();
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            senha = senha + "6";
            ChecaTextBoxes();
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            senha = senha + "4";
            ChecaTextBoxes();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            senha = senha + "0";
            ChecaTextBoxes();
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            senha = senha + "9";
            ChecaTextBoxes();
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            senha = senha + "5";
            ChecaTextBoxes();
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            senha = senha + "8";
            ChecaTextBoxes();
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            senha = senha + "7";
            ChecaTextBoxes();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            senha = senha + "1";
            ChecaTextBoxes();
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            senha = senha + "2";
            ChecaTextBoxes();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {


            if (SistemaBancario.Models.MySQLFunctions.LoginCliente(_numeroConta, senha))
            {
                MessageBox.Show("Logado com sucesso");
                this.Hide();
                InstanciaLogin il = new InstanciaLogin(_numeroConta);
                TemplateInicialCliente tic=new TemplateInicialCliente(il);
                tic.Show();

            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo com segurança");
            this.Hide();
            TelaLogin tl = new TelaLogin();
            tl.Show();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin tl = new TelaLogin();
            tl.Show();
        }
    }
}
