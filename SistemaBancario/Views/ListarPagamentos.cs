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
    public partial class ListarPagamentos : TemplateInicialCliente
    {
        public ListarPagamentos()
        {
            InitializeComponent();
            BuscarPagamentos();
        }

        private void BuscarPagamentos()
        {
            try
            {
                Models.MySQLFunction.ListarPagamentos(dataGridView_Pagamentos);
                dataGridView_Pagamentos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
    }
}
