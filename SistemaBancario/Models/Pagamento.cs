using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class Pagamento
    {
        private int id;
        private DateTime dataHoraTransacao;
        private string numeroBoleto;
        private decimal valor;
        private DateTime dataProgramada;
        private DateTime dataEfetivada;
        private Conta contaOrigem;
        private string bancoDestino;

        public Pagamento() { }

        public Pagamento(DateTime dataHoraTransacao, string numeroBoleto, decimal valor, DateTime dataProgramada, DateTime dataEfetivada, Conta contaOrigem, string bancoDestino)
        {
            this.dataHoraTransacao = dataHoraTransacao;
            this.numeroBoleto = numeroBoleto;
            this.valor = valor;
            this.dataProgramada = dataProgramada;
            this.dataEfetivada = dataEfetivada;
            this.contaOrigem = contaOrigem;
            this.bancoDestino = bancoDestino;
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

        public string NumeroBoleto
        {
            get
            {
                return numeroBoleto;
            }
            set
            {
                numeroBoleto = value;
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

        public DateTime DataProgramada
        {
            get
            {
                return dataProgramada;
            }
            set
            {
                dataProgramada = value;
            }
        }

        public DateTime DataEfetivada
        {
            get
            {
                return dataEfetivada;
            }
            set
            {
                dataEfetivada = value;
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

        public string BancoDestino
        {
            get
            {
                return bancoDestino;
            }
            set
            {
                bancoDestino = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

    }
}
