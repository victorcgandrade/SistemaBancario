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
    public partial class TelaTransferencia : TemplateInicialCliente
    {
        InstanciaLogin LoginAtual = new InstanciaLogin();
        List<string> ListaComboDe = new List<string>();

        public TelaTransferencia(InstanciaLogin il)
        {
            InitializeComponent();
            LoginAtual = il;
            LabelAgencia = il.agencia;
            LabelConta = il.conta;
            dtpDataTransferencia.Format = DateTimePickerFormat.Custom;
            dtpDataTransferencia.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            CarregaCombos();
            //cmbEscolhaBanco.SelectedIndex = -1;
            txtBoxContaOrigem.Text = il.conta;
        }

        public void CarregaCombos()
        {
            ListaComboDe.Add("Banco A&A");
            ListaComboDe.Add("Outros Bancos");
            cmbEscolhaBanco.DataSource = ListaComboDe;

        }

        private void ExibePanelOutrosBancos()
        {
            if (cmbEscolhaBanco.SelectedValue.Equals("Banco A&A"))
            {
                pnlDadosOutro.Visible = false;
                return;
            }
            else if (cmbEscolhaBanco.SelectedValue.Equals("Outros Bancos"))
            {
                pnlDadosOutro.Visible = true;
                return;
            }
            pnlDadosOutro.Visible = false;
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbEscolhaBanco.SelectedIndex = -1;
            cmbBoxTipo.SelectedIndex = -1;
            dtpDataTransferencia.Value = DateTime.Now;
            txtBoxContaOrigem.Text = "";
            txtBoxContaDestino.Text = "";
            txtBoxValor.Text = "";
            cmbBoxCodigo.SelectedIndex = -1;
            txtBoxAgenciaOutro.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TemplateInicialCliente tic = new TemplateInicialCliente(LoginAtual);
            tic.Show();
        }

        private void cmbEscolhaBanco_SelectedValueChanged(object sender, EventArgs e)
        {
            ExibePanelOutrosBancos();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if ((cmbEscolhaBanco.SelectedIndex != -1 
                && txtBoxContaOrigem.Text != String.Empty 
                && cmbBoxTipo.SelectedIndex != -1 
                && txtBoxContaDestino.Text != String.Empty
                && txtBoxValor.Text != String.Empty
                && Convert.ToDecimal(txtBoxValor.Text)>=1) || (cmbEscolhaBanco.SelectedIndex == 1 && txtBoxContaOrigem.Text != String.Empty
                && cmbBoxTipo.SelectedIndex != -1
                && txtBoxContaDestino.Text != String.Empty
                && txtBoxValor.Text != String.Empty
                && Convert.ToDecimal(txtBoxValor.Text) >= 1
                && cmbBoxCodigo.SelectedIndex != -1 
                && txtBoxAgenciaOutro.Text != String.Empty))
            {

                List<String> informacoesTransferencia = new List<string>();
                informacoesTransferencia.Add(cmbEscolhaBanco.SelectedValue.ToString());
                informacoesTransferencia.Add(txtBoxContaOrigem.Text);
                informacoesTransferencia.Add(cmbBoxTipo.SelectedText.ToString());
                informacoesTransferencia.Add(txtBoxContaDestino.Text);
                informacoesTransferencia.Add(dtpDataTransferencia.Text);
                informacoesTransferencia.Add(txtBoxValor.Text);
                informacoesTransferencia.Add(cmbBoxCodigo.SelectedText.ToString());
                informacoesTransferencia.Add(txtBoxAgenciaOutro.Text);


                ResumoTransferencia rt = new ResumoTransferencia(LoginAtual, informacoesTransferencia);
                this.Hide();
                rt.Show();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }


        }
    }
}
