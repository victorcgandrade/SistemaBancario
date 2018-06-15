using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
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
        static public Boolean InserirTitularPessoaFisica(string profissao, decimal rendaMensal, string cpf)
        {
            Boolean sucesso;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand inserirTitularPessoaFisica = new MySqlCommand(
                    "INSERT INTO PessoaFisica(profissao, rendaMensal, id_cliente) VALUES(@profissao, @rendaMensal, (SELECT Usuario.id FROM Cliente, Usuario WHERE Cliente.id_usuario = Usuario.id AND Usuario.cpf = @cpf))", connection);

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
