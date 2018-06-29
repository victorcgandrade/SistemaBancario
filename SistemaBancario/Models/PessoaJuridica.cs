using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class PessoaJuridica : Cliente
    {
        private string cnpj;
        private string razaoSocial;
        private string tipo;

        public PessoaJuridica()
        {

        }

        //Construtor contendo todos os atributos de Usuario e Cliente, alem de PessoaJuridica.
        public PessoaJuridica(string primeiroNome, string sobrenome, string cpf, string rg, DateTime data_nascimento, string email, string telefone,
            string celular, DateTime data_cadastro, Endereco endereco, string status, string estado_civil, string cnpj, string razaoSocial, string tipo)
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
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;
            this.tipo = tipo;
        }

        public string Cnpj
        {
            get
            {
                return cnpj;
            }
            set
            {
                cnpj = value;
            }
        }

        public string RazaoSocial
        {
            get
            {
                return razaoSocial;
            }
            set
            {
                razaoSocial = value;
            }
        }

        public String Tipo //Retorna o valor do estado civil em string
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
