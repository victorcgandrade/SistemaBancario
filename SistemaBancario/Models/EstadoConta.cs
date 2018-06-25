using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class EstadoConta
    {
        public enum Estado_Conta
        {
            Criada,
            Ativa,
            Com_pendências,
            Inativa
        };
        public EstadoConta()
        {
            EstadoConta.Estado_Conta ec = new Estado_Conta();
        }

    }
}
