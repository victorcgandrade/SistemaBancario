using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class Aplicacao
    {
        //Cada indice somado 1 corresponde ao valor de IOF que deve ser cobrado de acordo com a quantidade de dias do resgate
        private readonly int[] VALORES_IOF_DIA = { 96, 96, 90, 86, 83, 80, 76, 73, 70, 66, 63, 60, 56, 53, 50,
                                                    46, 43, 40, 36, 33, 30, 26, 23, 20, 16, 13, 10, 6, 3, 0};

        private int id;
        private string tipoAplicacao = "Pré-Fixada";
        private string status = "Em rendimento";
        private decimal valorMinimo = 50;
        private decimal valorInicial;
        private decimal valorResgate;
        private decimal taxaRendimento = 12;
        private decimal resgateMinimo = 150;
        private string vencimento;
        private decimal valorIOF;
        private ContaCorrente contaCorrente;
        private DateTime dataInicio;

        public Aplicacao() { }

        public Aplicacao(int id, decimal valorInicial, string vencimento, DateTime dataInicio, ContaCorrente conta)
        {
            this.id = id;
            this.valorInicial = valorInicial;
            this.valorResgate = valorInicial;
            this.vencimento = vencimento;
            this.contaCorrente = conta;
            this.dataInicio = dataInicio;
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

        public decimal ValorResgate
        {
            get
            {
                return this.valorInicial + RetornarRendimento();
            }
            set
            {
                valorResgate = value;
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

        public DateTime DataInicio
        {
            get
            {
                return dataInicio;
            }
            set
            {
                dataInicio = value;
            }
        }

        public decimal RetornarRendimento()
        {
            DateTime dataAtual = DateTime.Today;
            Decimal valorRendido = 0;

            if (tipoAplicacao == "Pré-Fixada")
            {
                int diasCorridos = (dataAtual.Date - dataInicio.Date).Days;

                if (diasCorridos >= 1)
                {
                    Decimal valorBruto = 0;

                    if (valorResgate <= valorInicial)
                    {
                        Double taxa = Convert.ToDouble(taxaRendimento);

                        Decimal taxaDia = Convert.ToDecimal(Math.Pow((1 + (taxa / 100)), (diasCorridos / 360))); //considerando taxa com base 360 dias corridos

                        valorBruto = valorInicial * taxaDia;
                    }
                    else
                    {
                        Double taxa = Convert.ToDouble(taxaRendimento);

                        Decimal taxaDia = Convert.ToDecimal(Math.Pow((1 + (taxa / 100)), (diasCorridos / 360))); //considerando taxa com base 360 dias corridos

                        valorBruto = ValorResgate * taxaDia;
                    }

                    if (diasCorridos <= 30)
                    {
                        //Apenas cobrado taxa de IOF se o resgate for feito com 30 ou menos dias
                        Decimal taxaIOF = VALORES_IOF_DIA[diasCorridos - 1];
                        valorRendido = valorBruto - (valorBruto * (taxaIOF / 100));
                    }
                    else
                    { 
                        valorRendido = valorBruto;
                    }
                }
                else
                {
                    valorRendido = this.valorResgate;
                }

            }
            else
            {
                valorRendido = this.valorResgate;
            }

            return valorRendido;
        }
    }
}
