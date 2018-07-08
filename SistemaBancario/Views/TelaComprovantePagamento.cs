using SistemaBancario.Models;
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SistemaBancario.Views
{
    public partial class TelaComprovantePagamento : TemplateInicialCliente
    {
        public TelaComprovantePagamento(InstanciaLogin il)
        {
            InitializeComponent();
            LabelConta = il.conta;
            LabelAgencia = il.agencia;
            MySQLFunction.ListarPagamentos(dataGridView_Pagamentos, LabelConta);
        }

        private void EnviarComprovantePagamentoSMS()
        {
            int id = Convert.ToInt16(textBox_VisualizarPagamento.Text);
            var comprovantePagamento = MySQLFunction.BuscarComprovantePagamento(id);

            TwilioClient.Init(
                "ACde2b9e4a1819220a7f99c105dd9a8936",
                "724c13ba84e0c418762082427284e315");

            MessageResource.Create(
                to: new PhoneNumber("+5521999053734"),
                from: new PhoneNumber("18123591194"),
                body: $"Comprovante de Pagamento:" +
                $"\r\nID: {comprovantePagamento.id}" +
                $"\r\nBoleto: {comprovantePagamento.numeroBoleto}" +
                $"\r\nValor: {comprovantePagamento.valor}" +
                $"\r\nOrigem: {comprovantePagamento.id_contaOrigem}" +
                $"\r\nDestino: {comprovantePagamento.cod_bancoDestino}");
        }

        private void btn_Retornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
            EnviarComprovantePagamentoSMS();
        }
    }
}
