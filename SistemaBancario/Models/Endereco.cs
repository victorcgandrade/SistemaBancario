using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class Endereco
    {
        private string tipo;
        private string logradouro;
        private int numero;
        private string bairro;
        private string complemento;
        private string cep;
        private string cidade;
        private string estado;

        public Endereco()
        {

        }

        public Endereco(string tipo, string logradouro, int numero, string bairro, string complemento, string cep, string cidade, string estado)
        {
            this.tipo = tipo;
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
        }

        public string Logradouro
        {
            get
            {
                return logradouro;
            }
            set
            {
                logradouro = value;
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

        public string Bairro
        {
            get
            {
                return bairro;
            }
            set
            {
                bairro = value;
            }
        }

        public string Complemento
        {
            get
            {
                return complemento;
            }
            set
            {
                complemento = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }
            set
            {
                cep = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        public String Tipo //Retorna o valor de tipo em string
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
    }
}
