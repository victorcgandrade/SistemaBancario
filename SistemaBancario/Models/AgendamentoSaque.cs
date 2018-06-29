using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class AgendamentoSaque
    {
        private DateTime dataHoraTransacao;
        private decimal valor;
        private Conta contaOrigem;
        private DateTime dataAgendamento;
        private string beneficiario;

        public AgendamentoSaque()
        {

        }

        public DateTime DataHoraTransacao
        {
            get
            {
                return dataHoraTransacao;
            }
            set
            {
                dataHoraTransacao = value;
            }
        }

        public decimal Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public Conta ContaOrigem
        {
            get
            {
                return contaOrigem;
            }
            set
            {
                contaOrigem = value;
            }
        }

        public DateTime DataAgendamento
        {
            get
            {
                return dataAgendamento;
            }
            set
            {
                dataAgendamento = value;
            }
        }

        public string Beneficiario
        {
            get
            {
                return beneficiario;
            }
            set
            {
                beneficiario = value;
            }
        }

    }
}
