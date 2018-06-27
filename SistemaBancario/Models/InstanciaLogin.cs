using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class InstanciaLogin
    {
        public string agencia { get; set; }
        public string conta { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        public InstanciaLogin(string conta)
        {
            this.conta = conta;
        }

        


    }
    
}
