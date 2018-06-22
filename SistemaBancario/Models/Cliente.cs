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
        //Enumeracoes para restringir os valores de status e estado civil

        public enum Status
        {
            Ativo,
            Inativo,
            Bloqueado
        };

        public enum Estado_Civil
        {
            Solteiro,
            Casado,
            Divorciado,
            Viuvo,
            Separado
        };

        private string data_nascimento;
        private string email;
        private string telefone;
        private string celular;
        private string data_cadastro;
        private Endereco endereco;
        private Status status = Status.Ativo; //inicialmente, por padrao, todos os clientes estao ativos
        private Estado_Civil estado_civil;

        public Cliente()
        {

        }

        public Cliente(string data_nascimento, string email, string telefone, string celular, string data_cadastro, Endereco endereco, Status status, Estado_Civil estado_civil)
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

        public String getStatus //Retorna o valor do status em string
        {
            get
            {
                return Enum.GetName(typeof(Status), status);
            }
        }

        public Status setStatus
        {
            set
            {
                status = value;
            }
        }

        public String getEstado_Civil //Retorna o valor do estado civil em string
        {
            get
            {
                return Enum.GetName(typeof(Estado_Civil), estado_civil);
            }
        }

        public Estado_Civil setEstado_Civil
        {
            set
            {
                estado_civil = value;
            }
        }
    }
}
