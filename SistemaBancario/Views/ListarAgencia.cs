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
    public partial class ListarAgencia : Form
    {
        public ListarAgencia()
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
    }
}
