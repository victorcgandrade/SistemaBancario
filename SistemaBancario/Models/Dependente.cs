using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class Dependente : Cliente
    {
        private PessoaFisica titular;

        public Dependente()
        {

        }

        public Dependente(string primeiroNome, string sobrenome, string cpf, string rg, string data_nascimento, string email, string telefone,
            string celular, DateTime data_cadastro, Endereco endereco, string status, string estado_civil, PessoaFisica titular)
        {
            this.PrimeiroNome = primeiroNome;
            this.Sobrenome = sobrenome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.DataNascimento = data_nascimento;
            this.Email = email;
            this.Telefone = telefone;
            this.Celular = celular;
            this.DataCadastro = data_cadastro;
            this.Endereco = endereco;
            this.Status = status;
            this.Estado_civil = estado_civil;
            this.titular = titular;
        }

        public PessoaFisica Titular
        {
            get
            {
                return titular;
            }
            set
            {
                titular = value;
            }
        }
    }
}
