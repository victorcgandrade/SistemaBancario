using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class ComprovantePagamento
    {
        public int id { get; set; }
        public DateTime dataHoraTransacao { get; set; }
        public string numeroBoleto { get; set; }
        public decimal valor { get; set; }
        public int id_contaOrigem { get; set; }
        public string cod_bancoDestino { get; set; }

        public ComprovantePagamento(int id, DateTime data, string numero, decimal valor, int idOrigem, string codBanco)
        {
            this.id = id;
            this.dataHoraTransacao = data;
            this.numeroBoleto = numero;
            this.valor = valor;
            this.id_contaOrigem = idOrigem;
            this.cod_bancoDestino = codBanco;
        }
    }
}
