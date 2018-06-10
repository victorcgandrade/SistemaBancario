using Main;
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
    public partial class SistemaBancarioTela : Form
    {
        public SistemaBancarioTela()
        {
            
        }

        public void SairUsuario(Form form)
        {
            DialogResult res = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res.Equals(DialogResult.OK))
            {
                this.Hide();
                TelaLogin tl = new TelaLogin();
                tl.Show();
            }
        }
    }
}
