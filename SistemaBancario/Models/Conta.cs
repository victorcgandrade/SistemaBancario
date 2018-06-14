using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    class Conta
    {
        private int id { get; set; }
        private long nuemro { get; set; }
        private decimal saldo { get; set; }
        private int id_agencia { get; set; }
        private int senha { get; set; }
        private EstadoConta estadoConta { get; set; }
        private int id_cliente { get; set; }

    }
}
