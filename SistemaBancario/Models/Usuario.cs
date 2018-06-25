using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class Usuario
    {
        private string primeiroNome;
        private string sobrenome;
        private string cpf;
        private string rg;

        public Usuario()
        {

        }

        public Usuario(string primeiroNome, string sobrenome, string cpf, string rg)
        {
            this.primeiroNome = primeiroNome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.rg = rg;
        }

        public string PrimeiroNome
        {
            get
            {
                return primeiroNome;
            }
            set
            {
                primeiroNome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }
            set
            {
                rg = value;
            }
        }

        public string NomeCompleto()
        {
            return primeiroNome + " " + sobrenome;
        }

    }
}
