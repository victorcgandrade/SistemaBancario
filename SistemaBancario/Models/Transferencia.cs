using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class Transferencia
    {
        private int id;
        private DateTime dataHoraTransacao;
        private decimal valor;
        private string cod_bancoDestino;
        private string tipo;
        private Conta contaOrigem;
        private Conta contaDest;
        private string num_contaOB;
        private string agencia_contaOB;

        public Transferencia()
        {

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

        public Conta ContaDest
        {
            get
            {
                return contaDest;
            }
            set
            {
                contaDest = value;
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

        public string NumeroContaOB
        {
            get
            {
                return num_contaOB;
            }
            set
            {
                num_contaOB = value;
            }
        }

        public string AgenciaContaOB
        {
            get
            {
                return agencia_contaOB;
            }
            set
            {
                agencia_contaOB = value;
            }
        }
    }
}
