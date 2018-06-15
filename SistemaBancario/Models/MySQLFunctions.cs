﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Main;
using System.Windows.Forms;

namespace SistemaBancario.Models
{
    class MySQLFunctions
    {
        //Conexa com o banco de dados remoto online
        static private MySqlConnection connection = new MySqlConnection("SERVER=db4free.net;PORT=3306;DATABASE=sistemabancario;UID=bancario;PWD=sb100001;");
        static string treatment = "Sem alteração";

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
        static public bool SelecionarCliente(string agencia, string conta)
        {
            bool sucesso = false;
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT Conta.id, Agencia.id FROM Conta JOIN Agencia ON Conta.id_agencia = Agencia.id AND Conta.numero= @conta AND Agencia.numero= @agencia;", connection);
                command.Parameters.AddWithValue("@conta", conta);
                command.Parameters.AddWithValue("@agencia", agencia);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        treatment = reader[0].ToString();

                    }
                    reader.Close();
                    if (treatment != "Sem alteração") sucesso = true;
                    else sucesso = false;
                }
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
                    "INSERT INTO Dependente (id_titular, id_cliente) VALUES((SELECT PessoaFisica.id FROM PessoaFisica JOIN Cliente ON PessoaFisica.id_cliente = Cliente.id JOIN Usuario ON Cliente.id_usuario = Usuario.id WHERE Usuario.cpf = @cpfResponsavel), (SELECT id FROM Cliente WHERE email = @email))", connection);

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


        //Funcao para conferir se uma dada string contem apenasdigitos
        public static bool ApenasDigitos(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        //Funcao para conferir se uma dada string contem apenas letras
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
        static public DataTable AcessarDadosCliente(string identificador)
        {
            DataTable dadosCliente = new DataTable(); //valor inicial vazio
            int idBusca;
            try
            {
                if (Int32.TryParse(identificador, out idBusca)) //tenta converter a string informada em numero
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    //Comando SQL refere-se a chamada de procedimento no banco para determinal qual tipo de cliente
                    MySqlCommand determinarTipoCliente = new MySqlCommand("ID_TIPO_CLIENTE", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Informando o valor do parametro de entrada do procedimento (id cliente)
                    determinarTipoCliente.Parameters.AddWithValue("@idCli", idBusca);

                    //Adicionado os parametros de saida do procedimento
                    determinarTipoCliente.Parameters.Add("@t1", MySqlDbType.Int16).Direction = ParameterDirection.Output;
                    determinarTipoCliente.Parameters.Add("@t2", MySqlDbType.Text).Direction = ParameterDirection.Output;

                    //Execucao da query
                    determinarTipoCliente.ExecuteNonQuery();

                    //Obtendo retorno do procedimento (Tipo de cliente [Dependente, PessoaFisica ou PessoaJuridica] e seu id)
                    string tipoCliente = determinarTipoCliente.Parameters["@t2"].Value.ToString();
                    int id = int.Parse(determinarTipoCliente.Parameters["@t1"].Value.ToString());
                    determinarTipoCliente.Parameters.Clear();

                    //Outro comando SQL para retornar os dados do cliente
                    string query = "";
                    string parametro = "";

                    //Determina a consulta adequada para retornar TODOS os dados de cada tipo de cliente diferente 
                    if (tipoCliente == "Dependente")
                    {
                        query = "SELECT Usuario.primeiroNome, Usuario.sobrenome, Usuario.cpf, Usuario.rg, Cliente.data_nascimento, Cliente.email, Cliente.telefone, Cliente.celular, Cliente.data_cadastro, Cliente.estado_cliente, Cliente.estado_civil," +
                            " Dependente.id_titular AS 'CPF_Responsavel', Endereco.logradouro, Endereco.rua, Endereco.numero, Endereco.bairro, Endereco.complemento, Endereco.cep, Endereco.cidade, Estado.sigla FROM Dependente JOIN Cliente ON Dependente.id_cliente = Cliente.id JOIN Endereco ON Endereco.id = Cliente.id_endereco JOIN Estado ON Endereco.estado_id = Estado.id JOIN Usuario ON Cliente.id_usuario = Usuario.id WHERE Dependente.id = @idDependente";

                        parametro = "@idDependente";

                    }
                    else if (tipoCliente == "PessoaFisica")
                    {
                        query = "SELECT Usuario.primeiroNome, Usuario.sobrenome, Usuario.cpf, Usuario.rg, Cliente.data_nascimento, Cliente.email, Cliente.telefone, Cliente.celular, Cliente.data_cadastro, Cliente.estado_cliente, Cliente.estado_civil, PessoaFisica.profissao, PessoaFisica.rendaMensal, " +
                            "Endereco.logradouro, Endereco.rua, Endereco.numero, Endereco.bairro, Endereco.complemento, Endereco.cep, Endereco.cidade, Estado.sigla FROM PessoaFisica JOIN Cliente ON PessoaFisica.id_cliente = Cliente.id JOIN Endereco ON Endereco.id = Cliente.id_endereco JOIN Estado ON Endereco.estado_id = Estado.id JOIN Usuario ON Cliente.id_usuario = Usuario.id WHERE PessoaFisica.id = @idPessoaFisica";
                        parametro = "@idPessoaFisica";

                    }
                    else if (tipoCliente == "PessoaJuridica")
                    {
                        query = "SELECT Usuario.primeiroNome, Usuario.sobrenome, Usuario.cpf, Usuario.rg, Cliente.data_nascimento, Cliente.email, Cliente.telefone, Cliente.celular, Cliente.data_cadastro, Cliente.estado_cliente, Cliente.estado_civil, PessoaJuridica.cnpj, PessoaJuridica.razaoSocial, PessoaJuridica.tipo, Endereco.logradouro," +
                            " Endereco.rua, Endereco.numero, Endereco.bairro, Endereco.complemento, Endereco.cep, Endereco.cidade, Estado.sigla FROM PessoaJuridica JOIN Cliente ON PessoaJuridica.id_cliente = Cliente.id JOIN Endereco ON Endereco.id = Cliente.id_endereco JOIN Estado ON Endereco.estado_id = Estado.id JOIN Usuario ON Cliente.id_usuario = Usuario.id WHERE PessoaJuridica.id = @idPessoaJuridica";
                        parametro = "@idPessoaJuridica";
                    }

                    //Executa a consulta caso as variaveis da mesma nao sao nulas
                    if (query != "" && parametro != "")
                    {
                        MySqlCommand visualizarCliente = new MySqlCommand(query, connection);
                        visualizarCliente.Parameters.AddWithValue(parametro, id);

                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(visualizarCliente);

                        //Todos os dados retornados em formato de tabela para variavel dadosCliente
                        dataAdapter.Fill(dadosCliente);
                        visualizarCliente.Parameters.Clear();
                    }
                }
                else
                {
                    dadosCliente = null; //valor informado para identificador esta incorreto
                }
            }
            catch (MySqlException exception)
            {
                dadosCliente = null; //erro
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return dadosCliente;
        }

        //Exibir todos os clientes cadastrados no banco de dados
        static public DataTable ListarCliente()
        {
            DataTable listagemCliente = new DataTable();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT Cliente.id, Usuario.primeiroNome, data_nascimento, estado_cliente FROM Cliente, Usuario WHERE Cliente.id_usuario = Usuario.id", connection);

                //Todos os dados retornados em formato de tabela para variavel dadosCliente
                dataAdapter.Fill(listagemCliente);

            }
            catch (MySqlException exception)
            {
                listagemCliente = null;
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return listagemCliente;
        }

        //Remover um determinado cliente
        static public Boolean RemoverCliente(string identificador)
        {
            bool sucesso;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand removerCliente = new MySqlCommand("DELETE FROM Usuario WHERE cpf = @identificador", connection);
                removerCliente.Parameters.AddWithValue("@identificador", identificador);

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

        //Exibir resultado da busca por uma aplicacao
        static public DataTable BuscarAplicacao(string numeroContaCorrente)
        {
            DataTable buscaAplicacao = new DataTable();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand buscarAplicacao = new MySqlCommand("SELECT Aplicacao.id, tipoAplicacao, valorInicial, vencimento FROM Aplicacao JOIN ContaCorrente ON Aplicacao.id_contacorrente = ContaCorrente.id JOIN Conta ON ContaCorrente.id_conta = Conta.id WHERE Conta.numero = @numeroCC", connection);
                buscarAplicacao.Parameters.AddWithValue("@numeroCC", numeroContaCorrente);


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(buscarAplicacao);

                dataAdapter.Fill(buscaAplicacao);
            }
            catch (MySqlException exception)
            {
                buscaAplicacao = null;
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return buscaAplicacao;
        }

        //Exibir todas aplicacoes cadastradas no banco de dados
        static public DataTable ListarAplicacao()
        {
            DataTable listagemAplicacao = new DataTable();

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT Aplicacao.id, tipoAplicacao, valorInicial, taxaRendimento, vencimento FROM Aplicacao JOIN ContaCorrente ON Aplicacao.id_contacorrente = ContaCorrente.id JOIN Conta ON ContaCorrente.id_conta = Conta.id", connection);

                //Todos os dados retornados em formato de tabela para variavel dadosCliente
                dataAdapter.Fill(listagemAplicacao);

            }
            catch (MySqlException exception)
            {
                listagemAplicacao = null;
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }

            return listagemAplicacao;
        }

        //Exibir resultado da busca por uma aplicacao
        static public DataTable AcessarDadosAplicacao(string identificador)
        {

            DataTable dadosAplicacao = new DataTable();

            if (Int32.TryParse(identificador, out int idBusca)) //tenta converter a string informada em numero
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    MySqlCommand buscarAplicacao = new MySqlCommand("SELECT Aplicacao.id, tipoAplicacao, valorMinimo, valorInicial, taxaRendimento, resgateMinimo, vencimento, valorIOF, impostoRenda, Conta.numero AS NumeroConta, Agencia.numero AS NumeroAgencia, Usuario.cpf FROM Aplicacao JOIN ContaCorrente ON Aplicacao.id_contacorrente = ContaCorrente.id JOIN Conta ON ContaCorrente.id_conta = Conta.id JOIN Agencia ON Conta.id_agencia = Agencia.id JOIN Cliente ON Conta.id_cliente = Cliente.id JOIN Usuario ON Cliente.id_usuario = Usuario.id WHERE Aplicacao.id = @identificador", connection);
                    buscarAplicacao.Parameters.AddWithValue("@identificador", identificador);


                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(buscarAplicacao);

                    dataAdapter.Fill(dadosAplicacao);
                }
                catch (MySqlException exception)
                {
                    dadosAplicacao = null;
                    Console.WriteLine(exception.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                dadosAplicacao = null;
            }

            return dadosAplicacao;
        }

        //Remover uma determinada aplicacao
        static public Boolean RemoverAplicacao(string identificador)
        {
            bool sucesso;

            if (Int32.TryParse(identificador, out int idBusca)) //tenta converter a string informada em numero
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    MySqlCommand removerCliente = new MySqlCommand("DELETE FROM Aplicacao WHERE id = @identificador", connection);
                    removerCliente.Parameters.AddWithValue("@identificador", idBusca);

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
            } else
            {
                sucesso = false;
            }

            return sucesso;
        }

        static public bool SelecionarAdministrador(string login, string senha)
        {
            bool sucesso = false;
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT Administrador.login FROM Administrador WHERE login = @login AND senha=@senha;", connection);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@senha", senha);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        treatment = reader[0].ToString();
                    }
                    reader.Close();
                    if (treatment != "Sem alteração") sucesso = true;
                    else sucesso = false;
                }
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
        static public bool LoginCliente(string _numeroConta, string senha)
        {
            bool sucesso = false;
            try
            {
                if (senha.Length == 4)
                {
                    MySqlConnection connection = new MySqlConnection("SERVER=db4free.net;PORT=3306;DATABASE=sistemabancario;UID=bancario;PWD=sb100001");
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT Conta.senha FROM Conta WHERE Conta.numero = @conta;", connection);
                    command.Parameters.AddWithValue("@conta", _numeroConta);
                    MySqlDataReader reader3 = command.ExecuteReader();
                    while (reader3.Read())
                    {
                        treatment = reader3[0].ToString();

                    }
                    reader3.Close();
                    if (treatment != "Sem alteração") sucesso = true;
                    else sucesso = false;
                }
                else
                {
                    MessageBox.Show("Senha incompleta");
                }
            }

            catch (MySqlException ex)
            {
                sucesso = false;
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return sucesso;
        }
        static public Boolean InserirConta(int agencia,int numero,int senha,int cpf)
        {
            Boolean sucesso;
            int idUsuario=0;
            int idAgencia=0;
            int idCliente = 0;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    
                    connection.Open();
                MySqlCommand selecionarUsuarioID = new MySqlCommand("SELECT id FROM Usuario where cpf=@cpf",connection);
                selecionarUsuarioID.Parameters.AddWithValue("@cpf", cpf);
                MySqlDataReader reader1 = selecionarUsuarioID.ExecuteReader();
                while (reader1.Read())
                {
                    idUsuario = (int)reader1[0];

                }
                reader1.Close();
                MySqlCommand selecionarClienteID = new MySqlCommand("SELECT id FROM Cliente where id_usuario=@idUsuario", connection);
                selecionarClienteID.Parameters.AddWithValue("@idUsuario", idUsuario);
                reader1 = selecionarClienteID.ExecuteReader();
                while (reader1.Read())
                {
                    idCliente = (int)reader1[0];

                }
                reader1.Close();
                MySqlCommand selecionarAgenciaID = new MySqlCommand("SELECT id FROM Agencia where numero=@numero",connection);
                selecionarClienteID.Parameters.AddWithValue("@numero", numero);
                reader1 = selecionarAgenciaID.ExecuteReader();
                while (reader1.Read())
                {
                    idAgencia = (int)reader1[0];

                }
                reader1.Close();
                MySqlCommand inserirConta = new MySqlCommand(
                    "INSERT INTO Conta(numero, id_agencia,saldo,senha,estado,id_cliente) VALUES(@numero, @agencia, 0, @senha, Criada, @cliente;", connection);
                inserirConta.Parameters.AddWithValue("@numero", numero);
                inserirConta.Parameters.AddWithValue("@agencia", idAgencia);
                inserirConta.Parameters.AddWithValue("@senha", senha);
                inserirConta.Parameters.AddWithValue("@cliente", idCliente);
                inserirConta.ExecuteNonQuery();
                inserirConta.Parameters.Clear();

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

