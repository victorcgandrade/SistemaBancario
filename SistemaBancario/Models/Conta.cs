using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBancario.Models;

namespace SistemaBancario.Models
{
    class Conta
    {
        private int numero;
        private Agencia agencia;
        private decimal saldo;
        private string status;
        private Cliente cliente;

        public Conta()
        {

        }

        public Conta(int numero, Agencia agencia, decimal saldo, string status, Cliente cliente)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.saldo = saldo;
            this.status = status;
            this.cliente = cliente;
        }

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public Agencia Agencia
        {
            get
            {
                return agencia;
            }
            set
            {
                agencia = value;
            }
        }

        public decimal Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
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

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }

    }
}
