using System;
using SistemaBancario.Models;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class AlterarAgencia : Form
    {
        private string auxIdEndereco;
        public AlterarAgencia()
        {
            InitializeComponent();
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja alterar esta agência?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MySQLFunctions.AlterarAgencia(textBox_NumeroAgencia.Text, textBox_identificadorAgencia.Text))
                {
                    MessageBox.Show("A agência foi alterada com sucesso!");
                    MySQLFunctions.ListarAgencias(dataGridView_AlterarAgencia, auxIdEndereco);
                }
            }
        }

        private void btn_Retornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_CarregarAgencia_Click(object sender, EventArgs e)
        {
            MySQLFunctions.CarregarAgenciaStr(textBox_identificadorAgencia.Text, textBox_NumeroAgencia, "numero");
            string idEndereco = MySQLFunctions.CarregarAgenciaEndereco(textBox_identificadorAgencia.Text, "id_endereco");
            auxIdEndereco = idEndereco;
            MySQLFunctions.ListarAgencias(dataGridView_AlterarAgencia, idEndereco);
            //MySQLFunctions.CarregarEnderecoStr(idEndereco, textBox_Cep, "cep");
            //MySQLFunctions.CarregarEnderecoStr(idEndereco, textBox_Rua, "rua");
            //MySQLFunctions.CarregarEnderecoStr(idEndereco, textBox_Bairro, "bairro");
            //MySQLFunctions.CarregarEnderecoStr(idEndereco, textBox_Cidade, "cidade");
            //MySQLFunctions.CarregarEnderecoStr(idEndereco, textBox_Complemento, "complemento");
        }
    }
}
