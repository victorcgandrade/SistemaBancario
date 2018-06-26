using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class ContaCorrente : Conta
    {
        private decimal taxa;
        private decimal limite;
        private Conta conta;

        public ContaCorrente()
        {

        }

        public ContaCorrente(int numero, Agencia agencia, decimal saldo, string status, Cliente cliente, decimal taxa, decimal limite, Conta conta)
        {
            this.Numero = numero;
            this.Agencia = agencia;
            this.Saldo = saldo;
            this.Status = status;
            this.Cliente = cliente;
            this.taxa = taxa;
            this.limite = limite;
            this.conta = conta;
        }

        //Construtor facilitado para visualizacao
        public ContaCorrente(int numero, int numeroAgencia, decimal saldo, string status, decimal taxa, decimal limite)
        {
            this.Conta.Numero = numero;
            this.Agencia.Numero = numeroAgencia;
            this.Saldo = saldo;
            this.Status = status;
            this.taxa = taxa;
            this.limite = limite;
        }

        public decimal Taxa
        {
            get
            {
                return taxa;
            }
            set
            {
                taxa = value;
            }
        }

        public decimal Limite
        {
            get
            {
                return limite;
            }
            set
            {
                limite = value;
            }
        }

        public Conta Conta
        {
            get
            {
                return conta;
            }
            set
            {
                conta = value;
            }
        }
    }
}
