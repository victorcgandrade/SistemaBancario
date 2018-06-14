using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class EstadoConta
    {
        enum Estado_Conta
        {
            Criada,
            Ativa,
            Com_pendências,
            Inativa
        };
    }
}
