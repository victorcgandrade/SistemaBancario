﻿using System;
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
    public partial class TelaInicialAdministradorConta : TemplateInicialAdministrador
    {
        public TelaInicialAdministradorConta()
        {
            InitializeComponent();
        }


        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdicionarConta ac = new AdicionarConta();
            ac.Show();
        }
    }
}
