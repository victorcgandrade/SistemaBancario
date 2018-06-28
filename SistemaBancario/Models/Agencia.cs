using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class Agencia
    {
        private int id;
        private int numero;
        private Endereco endereco;

        public Agencia()
        {

        }

        public Agencia(int id,int numero, Endereco endereco)
        {
            this.id = id;
            this.numero = numero;
            this.endereco = endereco;
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
