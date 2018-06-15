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
        private int id { get; set; }
        private long numero { get; set; }
        private decimal saldo { get; set; }
        private int id_agencia { get; set; }
        private int senha { get; set; }
        private EstadoConta.Estado_Conta estadoConta { get; set; }
        private int id_cliente { get; set; }

        public Conta(int id,long numero,decimal saldo,int id_agencia,int senha, int id_cliente)
        {
            this.id = id;
            this.numero = numero;
            this.saldo = saldo;
            this.id_agencia = id_agencia;
            this.senha = senha;
            this.estadoConta = EstadoConta.Estado_Conta.Criada;
            this.id_cliente = id_cliente;
            
        }
    }
}
