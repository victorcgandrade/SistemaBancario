using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class Aplicacao
    {
        //Enumeracoes para tipos de Aplicacao

        public string tipoAplicacao;
        public string status;
        public decimal valorMinimo;
        public decimal valorInicial;
        public decimal taxaRendimento;
        public decimal resgateMinimo;
        public string vencimento;
        public decimal valorIOF;
        public decimal impostoRenda;
        public ContaCorrente contaCorrente;

        public Aplicacao() { }

        public Aplicacao(string tipoAplicacao, string status, decimal valorMinimo, decimal valorInicial, decimal taxaRendimento, decimal resgateMinimo, string vencimento, decimal valorIOF, decimal impostoRenda, ContaCorrente conta)
        {
            this.tipoAplicacao = tipoAplicacao;
            this.status = status;
            this.valorMinimo = valorMinimo;
            this.valorInicial = valorInicial;
            this.taxaRendimento = taxaRendimento;
            this.resgateMinimo = resgateMinimo;
            this.vencimento = vencimento;
            this.valorIOF = valorIOF;
            this.impostoRenda = impostoRenda;
            this.contaCorrente = conta;
        }

        public string TipoAplicacao
        {
            get
            {
                return tipoAplicacao;
            }
            set
            {
                tipoAplicacao = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public decimal ValorMinimo
        {
            get
            {
                return valorMinimo;
            }
            set
            {
                valorMinimo = value;
            }
        }

        public decimal ValorInicial
        {
            get
            {
                return valorInicial;
            }
            set
            {
                valorInicial = value;
            }
        }

        public decimal TaxaRendimento
        {
            get
            {
                return taxaRendimento;
            }
            set
            {
                taxaRendimento = value;
            }
        }

        public decimal ResgateMinimo
        {
            get
            {
                return resgateMinimo;
            }
            set
            {
                resgateMinimo = value;
            }
        }

        public string Vencimento
        {
            get
            {
                return vencimento;
            }
            set
            {
                vencimento = value;
            }
        }

        public decimal ValorIOF
        {
            get
            {
                return valorIOF;
            }
            set
            {
                valorIOF = value;
            }
        }

        public decimal ImpostoRenda
        {
            get
            {
                return impostoRenda;
            }
            set
            {
                impostoRenda = value;
            }
        }

        public ContaCorrente ContaCorrente
        {
            get
            {
                return contaCorrente;
            }
            set
            {
                contaCorrente = value;
            }
        }
    }
}
