using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class Pagamento
    {
        private int id;
        private DateTime dataHoraTransacao;
        private string numeroBoleto;
        private decimal valor;
        private Conta contaOrigem;
        private string cod_bancoDestino;

        public Pagamento() { }

        public Pagamento(DateTime dataHoraTransacao, string numeroBoleto, decimal valor, Conta contaOrigem, string bancoDestino)
        {
            this.dataHoraTransacao = dataHoraTransacao;
            this.numeroBoleto = numeroBoleto;
            this.valor = valor;
            this.contaOrigem = contaOrigem;
            this.cod_bancoDestino = bancoDestino;
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
                return cod_bancoDestino;
            }
            set
            {
                cod_bancoDestino = value;
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
