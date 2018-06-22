using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class PessoaJuridica : Cliente
    {
        //Enumeracao para restringir os valores de tipo
        public enum Tipo
        {
            Sociedade_Ltda,
            Associacao,
            Fundacao,
        };

        private string cnpj;
        private string razaoSocial;
        private Tipo tipo;

        public PessoaJuridica()
        {

        }

        //Construtor contendo todos os atributos de Usuario e Cliente, alem de PessoaJuridica.
        public PessoaJuridica(string primeiroNome, string sobrenome, string cpf, string rg, string data_nascimento, string email, string telefone,
            string celular, string data_cadastro, Endereco endereco, Status status, Estado_Civil estado_civil, string cnpj, string razaoSocial, Tipo tipo)
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
            this.setStatus = status;
            this.setEstado_Civil = estado_civil;
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

        public String getTipo //Retorna o valor do estado civil em string
        {
            get
            {
                return Enum.GetName(typeof(Tipo), tipo);
            }
        }

        public Tipo setTipo
        {
            set
            {
                tipo = value;
            }
        }
    }
}
