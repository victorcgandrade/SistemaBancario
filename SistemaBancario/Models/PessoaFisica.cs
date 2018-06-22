using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class PessoaFisica : Cliente
    {
        private string profissao;
        private decimal rendaMensal;

        public PessoaFisica()
        {

        }

        //Construtor contendo todos os atributos de Usuario e Cliente, alem de PessoaFisica.
        public PessoaFisica(string primeiroNome, string sobrenome, string cpf, string rg, string data_nascimento, string email, string telefone, 
            string celular, DateTime data_cadastro, Endereco endereco, string status, string estado_civil, string profissao, decimal rendaMensal)
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
            this.profissao = profissao;
            this.rendaMensal = rendaMensal;
        }

        public string Profissao
        {
            get
            {
                return profissao;
            }
            set
            {
                profissao = value;
            }
        }

        public decimal RendaMensal
        {
            get
            {
                return rendaMensal;
            }
            set
            {
                rendaMensal = value;
            }
        }
    }
}
