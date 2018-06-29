using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using SistemaBancario.Views;
using SistemaBancario.Models;
//using SistemaBancario.Log;

namespace Main
{
    public partial class TelaLogin : Form
    {

        InstanciaLogin il = new InstanciaLogin();

        public TelaLogin()
        {
            InitializeComponent();
            cmbBoxTipoUser.Items.Add("Administrador");
            cmbBoxTipoUser.Items.Add("Cliente");
        }

        private bool ChecaLogin()
        {
            bool sucessoCliente = false;
            bool sucessoAdministrador = false;

            if (cmbBoxTipoUser.SelectedItem == "Cliente")
            {


                string agencia = txtBoxAgencia.Text;
                string conta = txtBoxConta.Text;
                if (agencia != "" && conta != "")
                {
                    if (SistemaBancario.Models.MySQLFunctions.SelecionarCliente(agencia, conta))
                    {
                        //Logger.logger.Information("Cliente logado com sucesso.");
                        sucessoCliente = true;
                        il = new InstanciaLogin(agencia, conta);
                    }
                }
            }
            else
            {
                string login = txtBoxLogin.Text;
                string senha = txtBoxSenha.Text;
                if (login != "" && senha != "")
                {
                    if (SistemaBancario.Models.MySQLFunctions.SelecionarAdministrador(login, senha))
                    {
                        //Logger.logger.Information("Administrador logado com sucesso.");
                        sucessoAdministrador = true;
                    }
                }
            }
            if (sucessoCliente == false && sucessoAdministrador == false)
            {
                //Logger.logger.Information("Falha ao tentar logar.");
                MessageBox.Show("Dados inválidos");
                return false;
            }
            else
            {
                MessageBox.Show("Logado com sucesso");

                if (cmbBoxTipoUser.SelectedItem == "Cliente")
                {
                    this.Hide();
                    TelaSenhaCliente tsc = new TelaSenhaCliente(il);
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

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
    }
