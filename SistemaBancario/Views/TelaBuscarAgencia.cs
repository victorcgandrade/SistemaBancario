using SistemaBancario.Models;
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
    public partial class TelaBuscarAgencia : TemplateInicialCliente
    {
        List<StringBuilder> enderecos = new List<StringBuilder>();
        DataRowCollection agencias = MySQLFunctions.ListaAgencias().Rows;
        public TelaBuscarAgencia(InstanciaLogin il)
        {
            InitializeComponent();
            CarregarAgencias();
            ConstroiMapa();
            LabelAgencia = il.agencia;
            LabelConta = il.conta;
        }
        public void CarregarAgencias()
        {
            List<String> listaConcatenada = new List<String>();
            dgvAgencias.DataSource = MySQLFunctions.ListaAgencias();
        }


        public void ConstroiMapa()
        {
            List<string> tipos = new List<string>();
            List<string> logradouros = new List<string>();
            List<string> ruas = new List<string>();
            List<string> numeros = new List<string>();
            List<string> bairros = new List<string>();
            List<string> cidades = new List<string>();
            List<string> estados = new List<string>();
            
            try
            {
                foreach(DataRow row in agencias)
                {
                    
                    tipos.Add(row.ItemArray[1].ToString());
                    logradouros.Add(row.ItemArray[2].ToString());
                    numeros.Add(row.ItemArray[3].ToString());
                    bairros.Add(row.ItemArray[4].ToString());
                    cidades.Add(row.ItemArray[7].ToString());
                    estados.Add(row.ItemArray[8].ToString());

                }

                

                for (int i = 0; i < agencias.Count; i++)
                {
                    enderecos.Add(new StringBuilder());
                    enderecos[i].Append("https://www.google.com.br/maps/place/".ToString());
                    if (tipos[i] != "")
                    {
                        enderecos[i].Append(tipos[i] + ",+");
                    }
                    if (logradouros[i] != "")
                    {
                        enderecos[i].Append(logradouros[i] + ",+");
                    }
                    if (numeros[i] != "")
                    {
                        enderecos[i].Append(numeros[i] + ",+");
                    }
                    if (bairros[i] != "")
                    {
                        enderecos[i].Append(bairros[i] + ",+");
                    }
                    if (cidades[i] != "")
                    {
                        enderecos[i].Append(cidades[i] + ",+");
                    }
                    if (estados[i] != "")
                    {
                        enderecos[i].Append(estados[i] + ",+");
                    }
                }
                List<String> ruasApresentaveis = new List<String>();

                cmbBoxAgencias.DataSource = logradouros;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void cmbBoxAgencias_SelectedValueChanged(object sender, EventArgs e)
        {
            wbAgencias.Navigate(enderecos[cmbBoxAgencias.SelectedIndex].ToString());
        }
    }
}
