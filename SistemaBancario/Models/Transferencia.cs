using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class Transferencia
    {
        int id;
        private DateTime dataHoraTransacao;
        private decimal valor;
        private string cod_bancoDestino;
        private string tipo;
        private Conta contaOrigem;
        private string num_contaDest;
        private string agencia_contaDest;

        public Transferencia()
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

        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        public string Num_contaDest
        {
            get
            {
                return num_contaDest;
            }
            set
            {
                num_contaDest = value;
            }
        }

        public string Agencia_contaDest
        {
            get
            {
                return agencia_contaDest;
            }
            set
            {
                agencia_contaDest = value;
            }
        }
    }
}
