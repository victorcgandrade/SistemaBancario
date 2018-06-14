using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaBancario.Models
{
    class MySQLFunctions
    {
        //Conexa com o banco de dados remoto online
        static private MySqlConnection connection = new MySqlConnection("SERVER=db4free.net;PORT=3306;DATABASE=sistemabancario;UID=bancario;PWD=sb100001;");

        //Criar novo usuario no banco de dados
        static public Boolean InserirUsuario(string primeiroNome, string sobrenome, string cpf, string rg)
        {
            Boolean sucesso;

            try
            {
                if (connection.State == ConnectionState.Closed)
                connection.Open();
                MySqlCommand inserirUsuario = new MySqlCommand("INSERT INTO Usuario(primeiroNome, sobrenome, cpf, rg) VALUES(@primeiroNome, @sobrenome, @cpf, @rg)", connection);
                inserirUsuario.Parameters.AddWithValue("@primeiroNome", primeiroNome);
                inserirUsuario.Parameters.AddWithValue("@sobrenome", sobrenome);
                inserirUsuario.Parameters.AddWithValue("@cpf", cpf);
                inserirUsuario.Parameters.AddWithValue("@rg", rg);

                inserirUsuario.ExecuteNonQuery();
                inserirUsuario.Parameters.Clear();

                sucesso = true;
            }
            catch (MySqlException exception)
            {
                sucesso = false;
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return sucesso;
        }

        //Criar novo endereco no banco de dados
        static public Boolean InserirEndereco(string logradouro, string rua, int numero, string bairro, string complemento, string cep, string cidade, string estado)
        {
            Boolean sucesso;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand inserirEndereco = new MySqlCommand(
                    "INSERT INTO Endereco(logradouro, rua, numero, bairro, complemento, cep, cidade, estado_id) VALUES(@logradouro, @rua, @numero, @bairro, @complemento, @cep, @cidade, (SELECT id FROM Estado WHERE sigla = @estado))", connection);
                inserirEndereco.Parameters.AddWithValue("@logradouro", logradouro);
                inserirEndereco.Parameters.AddWithValue("@rua", rua);
                inserirEndereco.Parameters.AddWithValue("@numero", numero);
                inserirEndereco.Parameters.AddWithValue("@bairro", bairro);
                inserirEndereco.Parameters.AddWithValue("@complemento", complemento);
                inserirEndereco.Parameters.AddWithValue("@cep", cep);
                inserirEndereco.Parameters.AddWithValue("@cidade", cidade);
                inserirEndereco.Parameters.AddWithValue("@estado", estado);

                inserirEndereco.ExecuteNonQuery();
                inserirEndereco.Parameters.Clear();

                sucesso = true;
            }
            catch (MySqlException exception)
            {
                sucesso = false;
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return sucesso;
        }

        //Criar novo cliente no banco de dados
        static public Boolean InserirCliente(string dataNascimento, string email, string telefone, string celular, string dataCadastro, string estado, string estadoCivil, string cep, string cpf)
        {
            Boolean sucesso;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand inserirCliente = new MySqlCommand(
                    "INSERT INTO Cliente(data_nascimento, email, telefone, celular, data_cadastro, id_endereco, estado_cliente, estado_civil, id_usuario) VALUES(STR_TO_DATE(@dataNascimento, \"%d/%m/%Y\"), @email, @telefone, @celular, STR_TO_DATE(@dataCadastro, \"%d/%m/%Y\"), (SELECT id FROM Endereco WHERE cep = @cep), @estado, @estadoCivil, (SELECT id FROM Usuario WHERE cpf = @cpf))", connection);
                inserirCliente.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                inserirCliente.Parameters.AddWithValue("@email", email);
                inserirCliente.Parameters.AddWithValue("@telefone", telefone);
                inserirCliente.Parameters.AddWithValue("@celular", celular);
                inserirCliente.Parameters.AddWithValue("@dataCadastro", dataCadastro);
                inserirCliente.Parameters.AddWithValue("@estado", estado);
                inserirCliente.Parameters.AddWithValue("@estadoCivil", estadoCivil);
                inserirCliente.Parameters.AddWithValue("@cep", cep);
                inserirCliente.Parameters.AddWithValue("@cpf", cpf);

                inserirCliente.ExecuteNonQuery();
                inserirCliente.Parameters.Clear();

                sucesso = true;
            }
            catch (MySqlException exception)
            {
                sucesso = false;
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return sucesso;
        }

        //Criar novo Titular Pessoa Fisica
        static public Boolean InserirTitularPessoaFisica(string profissao, decimal rendaMensal, string email)
        {
            Boolean sucesso;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand inserirTitularPessoaFisica = new MySqlCommand(
                    "INSERT INTO PessoaFisica(profissao, rendaMensal, id_cliente) VALUES(@profissao, @rendaMensal, (SELECT id FROM Cliente WHERE email = @email))", connection);

                inserirTitularPessoaFisica.Parameters.AddWithValue("@profissao", profissao);
                inserirTitularPessoaFisica.Parameters.AddWithValue("@rendaMensal", rendaMensal);
                inserirTitularPessoaFisica.Parameters.AddWithValue("@email", email);

                inserirTitularPessoaFisica.ExecuteNonQuery();
                inserirTitularPessoaFisica.Parameters.Clear();

                sucesso = true;
            }
            catch (MySqlException exception)
            {
                sucesso = false;
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return sucesso;
        }

        //Criar novo Titular Pessoa Juridica
        static public Boolean InserirTitularPessoaJuridica(string cnpj, string razaoSocial, string tipoPessoaJuridica, string email)
        {
            Boolean sucesso;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand inserirTitularPessoaJuridica = new MySqlCommand(
                    "INSERT INTO PessoaJuridica(cnpj, razaoSocial, tipo, id_cliente) VALUES(@cnpj, @razaoSocial, @tipo, (SELECT id FROM Cliente WHERE email = @email))", connection);

                inserirTitularPessoaJuridica.Parameters.AddWithValue("@cnpj", cnpj);
                inserirTitularPessoaJuridica.Parameters.AddWithValue("@razaoSocial", razaoSocial);
                inserirTitularPessoaJuridica.Parameters.AddWithValue("@tipo", tipoPessoaJuridica);
                inserirTitularPessoaJuridica.Parameters.AddWithValue("@email", email);

                inserirTitularPessoaJuridica.ExecuteNonQuery();
                inserirTitularPessoaJuridica.Parameters.Clear();

                sucesso = true;
            }
            catch (MySqlException exception)
            {
                sucesso = false;
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return sucesso;
        }

        //Criar novo Dependente - VERIFICAR NO BANCO DE DADOS AS COLUNAS
        static public Boolean InserirDependente(string cpfResponsavel, string email)
        {
            Boolean sucesso;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand inserirDependente = new MySqlCommand(
                    "INSERT INTO Dependente(id_titular, id_cliente) VALUES((SELECT id FROM Cliente WHERE id_usuario = (SELECT id FROM Usuario WHERE cpf = @cpfResponsavel)), (SELECT id FROM Cliente WHERE email = @email))", connection);

                inserirDependente.Parameters.AddWithValue("@cpfResponsavel", cpfResponsavel);
                inserirDependente.Parameters.AddWithValue("@email", email);

                inserirDependente.ExecuteNonQuery();
                inserirDependente.Parameters.Clear();

                sucesso = true;
            }
            catch (MySqlException exception)
            {
                sucesso = false;
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return sucesso;
        }


        //Funcao para conferir se uma dada string apenas contem digitos
        public static bool ApenasDigitos(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        //Funcao para conferir se uma dada string apenas contem letras
        public static bool ApenasLetras(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }


        //Exibir resultado da busca por um cliente
        static public Boolean BuscarCliente(DataGridView dataGridView, string identificador)
        {
            bool sucesso;

            string query = "";
            string parametro = "";

            if (!ApenasDigitos(identificador) && !ApenasLetras(identificador)) //Se ambas funcoes forem falsas, o identificador esta incorreto (nem nome nem cpf)
            {
                sucesso = false;
                return sucesso;
            }
            else
            {
                if (ApenasDigitos(identificador)) //Se a string apenas conter digitos, entao a busca sera feita pelo cpf
                {
                    query = "SELECT Cliente.id, Usuario.primeiroNome, data_nascimento, estado_cliente FROM Cliente, Usuario WHERE Usuario.cpf = @cpf AND Cliente.id_usuario = Usuario.id";
                    parametro = "@cpf";

                }
                else if (ApenasLetras(identificador)) //Se a string apenas conter letras, entao a busca sera feita pelo primeiro nome
                {
                    query = "SELECT Cliente.id, Usuario.primeiroNome, data_nascimento, estado_cliente FROM Cliente, Usuario WHERE Cliente.id_usuario = ANY (SELECT id FROM Usuario WHERE primeiroNome = @nome) AND Cliente.id_usuario = Usuario.id";
                    parametro = "@nome";
                }

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    MySqlCommand buscarCliente = new MySqlCommand(query, connection);
                    buscarCliente.Parameters.AddWithValue(parametro, identificador);


                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(buscarCliente);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;

                    sucesso = true;
                }
                catch (MySqlException exception)
                {
                    sucesso = false;
                    Console.WriteLine(exception.ToString());
                }
                finally
                {
                    connection.Close();
                }

                return sucesso;
            }
        }

        //Exibir todos os dados de um cliente
        static public int VisualizarCliente(string identificador)
        {
            int idCliente = -1;

            try
            {
                if (Int32.TryParse(identificador, out int idBusca)) //tenta converter a string informada em numero
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    //Comando SQL refere-se a chamada de procedimento no banco
                    MySqlCommand visualizarCliente = new MySqlCommand("ID_TIPO_CLIENTE", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Informando o valor do parametro de entrada do procedimento (id cliente)
                    visualizarCliente.Parameters.AddWithValue("@idCli", idBusca);

                    //Adicionado os parametros de saida do procedimento
                    visualizarCliente.Parameters.Add("@t1", MySqlDbType.Int16).Direction = ParameterDirection.Output;
                    visualizarCliente.Parameters.Add("@t2", MySqlDbType.Text).Direction = ParameterDirection.Output;

                    //Execucao da query
                    visualizarCliente.ExecuteNonQuery();

                    //Obtendo retorno do procedimento (Tipo de cliente [Dependente, PessoaFisica ou PessoaJuridica] e seu id)
                    string tipo = visualizarCliente.Parameters["@t2"].Value.ToString();
                    int id = int.Parse(visualizarCliente.Parameters["@t1"].Value.ToString());

                    Console.WriteLine(tipo);
                    Console.WriteLine(id);

                    visualizarCliente.Parameters.Clear();
                }
                else
                {
                    idCliente = -2;
                };
            }
            catch (MySqlException exception)
            {
                idCliente = -2;
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return idCliente;
        }

        //Exibir todos os clientes cadastrados no banco de dados
        static public void ListarCliente(DataGridView dataGridView)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT Cliente.id, Usuario.primeiroNome, data_nascimento, estado_cliente FROM Cliente, Usuario WHERE Cliente.id_usuario = Usuario.id", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (MySqlException exception)
            {
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        //Remover um determinado cliente
        static public Boolean RemoverCliente(string cpf)
        {
            bool sucesso;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand removerCliente = new MySqlCommand("DELETE FROM Usuario WHERE cpf = @cpf", connection);
                removerCliente.Parameters.AddWithValue("@cpf", cpf);

                removerCliente.ExecuteNonQuery();
                removerCliente.Parameters.Clear();

                sucesso = true;
            }
            catch (MySqlException exception)
            {
                sucesso = false;
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return sucesso;
        }

    }
}
