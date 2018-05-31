using System;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class RemoverAgencia : Form
    {
        public RemoverAgencia()
        {
            InitializeComponent();
            ListarAgencias();
        }

        private void ListarAgencias()
        {
            try
            {
                SistemaBancario.Models.MySQLFunctions.ListarAgencias(dataGridView_ListarAgencias);
                dataGridView_ListarAgencias.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Retornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ExcluirAgencia_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja remover esta agência?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SistemaBancario.Models.MySQLFunctions.RemoverAgencia(Convert.ToInt32(textBox_NumeroAgenciaRemover.Text));
                ListarAgencias();
            }
        }
    }
}
