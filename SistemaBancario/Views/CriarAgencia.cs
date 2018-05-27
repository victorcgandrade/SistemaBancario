using System;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class CriarAgencia : Form
    {
        public CriarAgencia()
        {
            InitializeComponent();
        }

        private bool CriarEndereco()
        {
            bool sucesso = false;

            string cep = textBox_Cep.Text;
            string logradouro = textBox_Logradouro.Text;
            string rua = textBox_Rua.Text;
            int numero = Convert.ToInt32(textBox_Numero.Text);
            string bairro = textBox_Bairro.Text;
            string complemento = textBox_Complemento.Text;
            string cidade = textBox_Cidade.Text;
            string estado = comboBox_Estado.Text;

            if (cep != "" && logradouro != "" && rua != "" && bairro != "" && complemento != "" && cidade != "" && estado != "")
            {
                if (SistemaBancario.Models.MySQLFunctions.InserirEndereco(logradouro, rua, numero, bairro, complemento, cep, cidade, estado))
                {
                    sucesso = true;
                    MessageBox.Show("ENDERECO SUCESSO");
                }
            }

            return sucesso;
        }

        private bool AdicionarAgencia()
        {

            bool sucesso = false;

            string numeroAgencia = textBox_NumeroAgencia.Text;
            string cep = textBox_Cep.Text;

            if (!string.IsNullOrEmpty(numeroAgencia) 
                && SistemaBancario.Models.MySQLFunctions.InserirAgencia(numeroAgencia, cep))
            {
                sucesso = true;
                MessageBox.Show("AGENCIA SUCESSO");
            }

            return sucesso;
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja adicionar esta agência?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CriarEndereco() && AdicionarAgencia())
                {
                    MessageBox.Show("A agência foi inserida com sucesso!");
                }
            }
        }
    }
}