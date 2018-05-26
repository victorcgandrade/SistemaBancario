using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaBancario.Views;

namespace Main
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            cmbBoxTipoUser.Items.Add("Administrador");
            cmbBoxTipoUser.Items.Add("Cliente");



        }

        private bool ChecaLogin()
        {
            string treatment = "Sem alteração";
            string treatment2 = "Sem alteração";
            try
            {


                if (cmbBoxTipoUser.SelectedItem == "Cliente")
                {
                    using (MySqlConnection connection = new MySqlConnection("SERVER=db4free.net;PORT=3306;DATABASE=sistemabancario;UID=bancario;PWD=sb100001"))
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand("SELECT Conta.id, Agencia.id FROM Conta JOIN Agencia ON Conta.id_agencia = Agencia.id AND Conta.numero= @conta AND Agencia.numero= @agencia;", connection);
                        command.Parameters.AddWithValue("@conta", txtBoxConta.Text);
                        command.Parameters.AddWithValue("@agencia", txtBoxAgencia.Text);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                treatment = reader[0].ToString();

                            }
                            reader.Close();
                        }
                        connection.Close();
                    }
                }
                else
                {
                    using (MySqlConnection connection = new MySqlConnection("SERVER=db4free.net;PORT=3306;DATABASE=sistemabancario;UID=bancario;PWD=sb100001"))
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand("SELECT Administrador.login FROM Administrador WHERE login = @login AND senha=@senha;", connection);
                        command.Parameters.AddWithValue("@login", txtBoxLogin.Text);
                        command.Parameters.AddWithValue("@senha", txtBoxSenha.Text);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                treatment2 = reader[0].ToString();

                            }
                            reader.Close();
                        }
                        connection.Close();
                    }
                }
            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (treatment.Equals("Sem alteração") && treatment2.Equals("Sem alteração"))
            {
                MessageBox.Show("Dados inválidos");
                return false;
            }
            else
            {
                MessageBox.Show("Logado com sucesso");

                if (cmbBoxTipoUser.SelectedItem == "Cliente")
                {
                    this.Hide();
                    TelaSenhaCliente tsc = new TelaSenhaCliente(txtBoxConta.Text);
                    tsc.Show();
                }
                else
                {
                    this.Hide();
                    InicialAdministrador tia = new InicialAdministrador();
                    tia.Show();
                }
                return true;
            }


        }

        private void cmbBoxTipoUser_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbBoxTipoUser.SelectedItem.Equals("Administrador"))
            {
                tlpDadosAdm.Visible = true;
                tlpDadosCliente.Visible = false;
            }
            else if (cmbBoxTipoUser.SelectedItem.Equals("Cliente"))
            {
                tlpDadosAdm.Visible = false;
                tlpDadosCliente.Visible = true;
            }
        }

        private void btnAcessar_Click_1(object sender, EventArgs e)
        {
            ChecaLogin();
        }
    }
}
