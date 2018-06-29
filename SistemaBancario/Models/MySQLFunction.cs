using System;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaBancario.Models
{
    class MySQLFunction
    {
        //Conecta com o banco de dados remoto online
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

        internal static bool AlterarAgencia(string textBox_NumeroAgencia, string textBox_identificadorAgencia)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand alterarAgencia = new MySqlCommand($"UPDATE Agencia SET numero = {textBox_NumeroAgencia} " +
                                                                $"WHERE id = {textBox_identificadorAgencia}", connection);
                alterarAgencia.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        internal static void CarregarAgenciaStr(string v, TextBox textBox_NumeroAgencia, string fieldDB)
        {
            int aux = Convert.ToInt32(v);
            try
            {

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand carregarAgencia = new MySqlCommand($"Select {fieldDB} from Agencia where id = @id", connection);
                carregarAgencia.Parameters.AddWithValue("@id", aux);

                textBox_NumeroAgencia.Text = (string)carregarAgencia.ExecuteScalar();
                carregarAgencia.Parameters.Clear();
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        internal static void CarregarEnderecoInt(string v, TextBox textBox_NumeroAgencia, string fieldDB)
        {
            int aux = Convert.ToInt32(v);
            try
            {

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand carregarEndereco = new MySqlCommand($"Select {fieldDB} from Endereco where id = @id", connection);
                carregarEndereco.Parameters.AddWithValue("@id", aux);
                
                textBox_NumeroAgencia.Text = Convert.ToString((int)carregarEndereco.ExecuteScalar());
                carregarEndereco.Parameters.Clear();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        /*internal static void CarregarEnderecoStr(string v, TextBox textBox_NumeroAgencia, string fieldDB)
        {
            int aux = Convert.ToInt32(v);
            try
            {

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand carregarEndereco = new MySqlCommand($"Select {fieldDB} from Endereco where id = @id", connection);
                carregarEndereco.Parameters.AddWithValue("@id", aux);

                textBox_NumeroAgencia.Text = (string)carregarEndereco.ExecuteScalar();
                carregarEndereco.Parameters.Clear();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        */
        internal static string CarregarAgenciaEndereco(string v, string fieldDB)
        {
            int aux = Convert.ToInt32(v);
            try
            {

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand carregarAgencia = new MySqlCommand($"Select {fieldDB} from Agencia where id = @id", connection);
                carregarAgencia.Parameters.AddWithValue("@id", aux);

                return Convert.ToString((int)carregarAgencia.ExecuteScalar());
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
            finally
            {
                connection.Close();
            }
        }



        //Pode ser útil no futuro mas não foi implementado e pode conter erros, cuidado ao usar... bjs do brenao
        //static public bool RemoverEnderecoByIdAgencia(int idAgencia)
        //{
        //    bool sucesso;

        //    try
        //    {
        //        if (connection.State == ConnectionState.Closed)
        //            connection.Open();

        //        MySqlCommand removerEndereco = new MySqlCommand(
        //            "DELETE FROM Endereco WHERE Endereco.id = (" +
        //                "SELECT id_endereco FROM Agencia WHERE Agencia.id = @idAgencia)", connection);
        //        removerEndereco.Parameters.AddWithValue("@idAgencia", idAgencia);
        //        removerEndereco.ExecuteNonQuery();
        //        removerEndereco.Parameters.Clear();

        //        sucesso = true;
        //    }
        //    catch(Exception ex)
        //    {
        //        sucesso = false;
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return sucesso;
        //}



        //static private int BuscarEndereco(int idAgencia)
        //{
        //    try
        //    {
        //        if (connection.State == ConnectionState.Closed)
        //            connection.Open();
        //        MySqlCommand enderecoPorIdAgencia = new MySqlCommand(
        //            "SELECT Endereco.id FROM Endereco INNER JOIN Agencia on Endereco.id = Agencia.id_endereco Where Agencia.id = @idAgencia", connection);
        //        enderecoPorIdAgencia.Parameters.AddWithValue("@idAgencia", idAgencia);
        //        enderecoPorIdAgencia.ExecuteNonQuery();
        //        int id = (int)enderecoPorIdAgencia.ExecuteScalar();
        //        return id;
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return 0;
        //}

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

        #region Agencias
        static public void ListarAgencias(DataGridView dataGridView)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                //numero as 'Número da Agência', id_endereco as 'Código do Endereço', E.cep  
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                    "SELECT A.id as 'Identificar da Agência', A.numero as 'Número da Agência', E.estado as Estado, E.cidade as Cidade, E.bairro as Bairro, E.tipo as Logradouro, " +
                    "E.logradouro as Rua, E.numero as Número, E.complemento as Complemento, E.cep as CEP FROM Agencia as A " +
                    "INNER JOIN Endereco as E ON A.id_endereco = E.id", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void ListarAgencias(DataGridView dataGridView, string id_endereco)
        {
            try
            {
                int aux = Convert.ToInt16(id_endereco);

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                //numero as 'Número da Agência', id_endereco as 'Código do Endereço', E.cep  
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                    "SELECT A.id as 'Identificar da Agência', A.numero as 'Número da Agência', E.cidade as Cidade, E.bairro as Bairro, E.tipo as Logradouro, " +
                    "E.logradouro as Rua, E.numero as Número, E.complemento as Complemento, E.cep as CEP FROM Agencia as A " +
                    "INNER JOIN Endereco as E ON A.id_endereco = E.id " +
                    $"WHERE E.id = {aux}", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public Boolean InserirAgencia(string numeroAgencia, string cep)
        {
            Boolean sucesso;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                MySqlCommand inserirCliente = new MySqlCommand(
                    "INSERT INTO Agencia(numero, id_endereco) VALUES(@numeroAgencia, (SELECT id FROM Endereco WHERE cep = @cep))", connection);
                inserirCliente.Parameters.AddWithValue("@numeroAgencia", numeroAgencia);
                inserirCliente.Parameters.AddWithValue("@cep", cep);

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

        static public void RemoverAgencia(int idAgencia)
        {
            bool sucesso;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                //int idEndereco = BuscarEndereco(idAgencia);

                MySqlCommand removerAgencia = new MySqlCommand(
                    "DELETE FROM Agencia WHERE id = @idAgencia", connection);
                removerAgencia.Parameters.AddWithValue("@idAgencia", idAgencia);
                removerAgencia.ExecuteNonQuery();
                removerAgencia.Parameters.Clear();

                sucesso = true;
            }
            catch (Exception ex)
            {
                sucesso = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            if (sucesso)
                MessageBox.Show("Agência removida com sucesso.");
            else
                MessageBox.Show("Ocorreu um erro ao remover a agência.");
        }

        #endregion

        static public void ListarPagamentos(DataGridView dataGridView)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                //numero as 'Número da Agência', id_endereco as 'Código do Endereço', E.cep  
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                    "SELECT id, dataHoraTransacao, numeroBoleto, valor, id_contaOrigem, cod_bancoDestino FROM Pagamento", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public ComprovantePagamento BuscarComprovantePagamento(int pagamentoId)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                var dataHoraTransacao = connection.ExecuteScalar<DateTime>("SELECT dataHoraTransacao FROM Pagamento WHERE id = @id", new { @id = pagamentoId });
                var numeroBoleto = connection.ExecuteScalar<string>("SELECT numeroBoleto FROM Pagamento WHERE id = @id", new { @id = pagamentoId });
                var valor = connection.ExecuteScalar<decimal>("SELECT valor FROM Pagamento WHERE id = @id", new { @id = pagamentoId });
                var id_contaOrigem = connection.ExecuteScalar<int>("SELECT id_contaOrigem FROM Pagamento WHERE id = @id", new { @id = pagamentoId });
                var cod_bancoDestino = connection.ExecuteScalar<string>("SELECT cod_bancoDestino FROM Pagamento WHERE id = @id", new { @id = pagamentoId });

                var result = new ComprovantePagamento(pagamentoId, dataHoraTransacao, numeroBoleto, valor, id_contaOrigem, cod_bancoDestino);

                return result;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
