using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class Administrador : Usuario
    {
        private string login;
        private string senha;
        
        public Administrador()
        {

        }

        public Administrador(string login, string senha, string cpf)
        {
            this.login = login;
            this.senha = senha;
            this.Cpf = cpf;
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }
    }
}
