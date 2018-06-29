using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class Cliente : Usuario
    {

        private DateTime data_nascimento;
        private string email;
        private string telefone;
        private string celular;
        private DateTime data_cadastro;
        private Endereco endereco;
        private string status; //inicialmente, por padrao, todos os clientes estao ativos
        private string estado_civil;

        public Cliente()
        {

        }

        public Cliente(DateTime data_nascimento, string email, string telefone, string celular, DateTime data_cadastro, Endereco endereco, string status, string estado_civil)
        {
            this.data_nascimento = data_nascimento;
            this.email = email;
            this.telefone = telefone;
            this.celular = celular;
            this.data_cadastro = data_cadastro;
            this.endereco = endereco;
            this.status = status;
            this.estado_civil = estado_civil;
        }

        public DateTime DataNascimento
        {
            get
            {
                return data_nascimento;
            }
            set
            {
                data_nascimento = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }
            set
            {
                celular = value;
            }
        }

        public DateTime DataCadastro
        {
            get
            {
                return data_cadastro;
            }
            set
            {
                data_cadastro = value;
            }
        }

        public Endereco Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public string Estado_civil
        {
            get
            {
                return estado_civil;
            }
            set
            {
                estado_civil = value;
            }
        }

    }
}
