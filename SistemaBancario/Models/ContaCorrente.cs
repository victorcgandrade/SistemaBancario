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

        public ContaCorrente()
        {

        }

        //Construtor referente apenas aos atributos da classe Conta, da qual esta herda
        public ContaCorrente(Agencia agencia, Cliente cliente, int numero, decimal saldo, string status)
        {
            this.Agencia = agencia;
            this.Cliente = cliente;
            this.Numero = numero;
            this.Saldo = saldo;
            this.Status = status;
        }

        public ContaCorrente(int numero, Agencia agencia, decimal saldo, string status, Cliente cliente, decimal taxa, decimal limite)
        {
            this.Numero = numero;
            this.Agencia = agencia;
            this.Saldo = saldo;
            this.Status = status;
            this.Cliente = cliente;
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
    }
}
