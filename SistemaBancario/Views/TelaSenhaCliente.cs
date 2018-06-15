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
            _numeroConta =numeroConta;
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
            string treatment = "Sem alteração";

            try
            {

                
                if (senha.Length == 4)
                {
                    MySqlConnection connection = new MySqlConnection("SERVER=db4free.net;PORT=3306;DATABASE=sistemabancario;UID=bancario;PWD=sb100001");
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT Conta.senha FROM Conta WHERE Conta.numero = @conta;", connection);
                    command.Parameters.AddWithValue("@conta", _numeroConta);
                    MySqlDataReader reader3 = command.ExecuteReader();
                    while (reader3.Read())
                    {
                        treatment = reader3[0].ToString();

                    }
                    reader3.Close();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Senha incompleta");
                }

            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (treatment.Equals("Sem alteração"))
            {
                MessageBox.Show("Dados inválidos");
                
            }
            else
            {
                MessageBox.Show("Logado com sucesso");
                
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo com segurança");
            Application.Exit();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin tl = new TelaLogin();
            tl.Show();
        }
    }
}
