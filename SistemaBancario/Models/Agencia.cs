using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class Agencia
    {
        private int numero;
        private Endereco endereco;

        public Agencia()
        {

        }

        public Agencia(int numero, Endereco endereco)
        {
            this.numero = numero;
            this.endereco = endereco;
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

        public Endereco Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }

    }
}
