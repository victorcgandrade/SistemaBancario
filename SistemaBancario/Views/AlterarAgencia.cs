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
    public partial class AlterarAgencia : Form
    {
        public AlterarAgencia()
        {
            InitializeComponent();
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja alterar esta agência?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (true)
                {
                    MessageBox.Show("A agência foi alterada com sucesso!");
                }
            }
        }

        private void btn_Retornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_CarregarAgencia_Click(object sender, EventArgs e)
        {
            
        }
    }
}
