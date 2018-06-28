using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class TelaBuscarAgencia : TemplateInicialCliente
    {
        public TelaBuscarAgencia()
        {
            InitializeComponent();
            CarregarAgencias();
        }
        public void CarregarAgencias()
        {
            List<String> listaConcatenada = new List<String>();
            dgvAgencias.DataSource = MySQLFunctions.ListaAgencias();
            

        }

    }
}
