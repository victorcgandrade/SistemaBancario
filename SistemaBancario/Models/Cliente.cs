using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class Cliente : Usuario
    {

        private string data_nascimento;
        private string email;
        private string telefone;
        private string celular;
        private string data_cadastro;
        private Endereco endereco;
        private string status; //inicialmente, por padrao, todos os clientes estao ativos
        private string estado_civil;

        public Cliente()
        {

        }

        public Cliente(string data_nascimento, string email, string telefone, string celular, string data_cadastro, Endereco endereco, string status, string estado_civil)
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

        public string DataNascimento
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

        public string DataCadastro
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
