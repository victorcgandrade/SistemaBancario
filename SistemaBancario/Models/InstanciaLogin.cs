using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class InstanciaLogin
    {
        //Atributos agencia e conta para o login de Cliente
        public string agencia { get; set; }
        public string conta { get; set; }
        public string login { get; set; } //Atributo login para administrador
        public string senha { get; set; }

        public InstanciaLogin()
        {

        }

        public InstanciaLogin(string conta)
        {
            this.conta = conta;
        }

        public InstanciaLogin(string agencia, string conta)
        {
            this.agencia = agencia;
            this.conta = conta;
        }

    }
}
