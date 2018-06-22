using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class AlterarCliente : SistemaBancario.Views.AdicionarCliente
    {
        public AlterarCliente(DataTable dt)
        {
            InitializeComponent();
        }

        //Botao confirmar ao ser clicado
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
