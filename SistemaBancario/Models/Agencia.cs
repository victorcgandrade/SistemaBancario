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
        private int id_endereco;

        public Agencia()
        {

        }

        public Agencia(int id,int numero, int id_endereco)
        {
            this.id = id;
            this.numero = numero;
            this.id_endereco = id_endereco;
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

        public int Id_endereco
        {
            get
            {
                return id_endereco;
            }
            set
            {
                id_endereco = value;
            }
        }

    }
}
