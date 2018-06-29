using System;
using System.IO;
using System.Windows.Forms;

namespace SistemaBancario.Views
{
    public partial class LogAtividades : TemplateInicialAdministrador
    {
        public LogAtividades()
        {
            InitializeComponent();
            try
            {
                var pathLog = Directory.GetCurrentDirectory() + "\\Log\\log.txt";
                string log = System.IO.File.ReadAllText(pathLog);
                richTextBox1.Text = log;
            }
            catch(Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

    }
}
