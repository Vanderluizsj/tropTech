using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MercadoDoZe.Classes.DAO

{
    public class ClienteDAO
    {
        private const string _connectionString = @"server=.\SQLEXPRESS;initial catalog=MERCADO_DO_ZE;integrated security=true;";

        public ClienteDAO()
        {
            
        }
        public void AdicionarCliente(Cliente novoCliente)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    string sql = @"INSERT CLIENTE VALUES (@CPF, @NOME, @DATA_NASCIMENTO, @PONTOS_FIDELIDADE, @RUA, @NUMERO, @BAIRRO, @CEP, @COMPLEMENTO);";

                    ConverteObjetoParaSql(novoCliente, comando);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public List<Cliente> BuscarTodos()
        {
            var listaClientes= new List<Cliente>();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    string sql = @"SELECT * FROM CLIENTE";

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader();

                    bool validarConsulta = false; 
                    while (leitor.Read())
                    {
                        validarConsulta = true;
                        Cliente clienteBuscado = ConverterSqlParaObjeto(leitor);

                        listaClientes.Add(clienteBuscado);
                        
                    }
                    if (!validarConsulta)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("A tabela CLIENTE esta vazia.");
                    }
                }
            }

            return listaClientes;
        }
        public void DeletarCliente(Cliente clienteBuscado)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"DELETE FROM CLIENTE WHERE CPF = @CPF;";

                    comando.Parameters.AddWithValue("@CPF", clienteBuscado.Cpf);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public void DeletarTodosOsClientes()
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"DELETE FROM CLIENTE;";

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public void AtualizarCliente(Cliente clienteBuscado) 
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open(); 

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"UPDATE CLIENTE SET            
                                        NOME = @NOME,
                                        DATA_NASCIMENTO = @DATA_NASCIMENTO,
                                        RUA = @RUA,
                                        NUMERO = @NUMERO,
                                        BAIRRO = @BAIRRO,
                                        CEP = @CEP,
                                        COMPLEMENTO = @COMPLEMENTO
                                 WHERE CPF = @CPF_CLIENTE;";

                    ConverteObjetoParaSql(clienteBuscado, comando);
                    comando.Parameters.AddWithValue("@CPF_CLIENTE", clienteBuscado.Cpf);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        
        public List<Cliente> BuscaPorNome(string nome)
        {
            var listaClientes= new List<Cliente>(); 

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"SELECT CPF, NOME, DATA_NASCIMENTO, PONTOS_FIDELIDADE, RUA, NUMERO, BAIRRO, CEP, COMPLEMENTO FROM CLIENTE WHERE NOME LIKE @TEXTO;"; 

                    comando.Parameters.AddWithValue("@TEXTO", $"%{nome}%");

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader(); 
                    bool validarConsulta = false; 
                    while (leitor.Read())
                    {
                        validarConsulta = true;
                        var clienteBuscado = ConverterSqlParaObjeto(leitor);
                        
                        listaClientes.Add(clienteBuscado);
                    }
                    if (!validarConsulta)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine($"Não tem nenhum cliente na tabela CLIENTE "
                                                +$"com o nome indicado.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            return listaClientes;
        }
        
        public Cliente BuscarPorCpf(long cpf)
        {
            var clienteBuscado = new Cliente();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"SELECT CPF, NOME, DATA_NASCIMENTO, PONTOS_FIDELIDADE, RUA, NUMERO, BAIRRO, CEP, COMPLEMENTO FROM CLIENTE WHERE CPF = @CPF_CLIENTE;"; 

                    comando.Parameters.AddWithValue("@CPF_CLIENTE", cpf);

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader(); 
                    bool validarConsulta = false; 
                    while (leitor.Read())
                    {
                        validarConsulta = true;
                        clienteBuscado = ConverterSqlParaObjeto(leitor);
                    }
                    if (!validarConsulta)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine($"Não tem nenhum cliente na tabela CLIENTE "
                                                +$"com o CPF indicado.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            return clienteBuscado;
        }
        private void ConverteObjetoParaSql(Cliente cliente, SqlCommand comando)
        {
                comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
                comando.Parameters.AddWithValue("@NOME", cliente.Nome);
                comando.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
                comando.Parameters.AddWithValue("@PONTOS_FIDELIDADE", cliente.PontosFidelidade);
                comando.Parameters.AddWithValue("@RUA", cliente.Endereco.Rua);
                comando.Parameters.AddWithValue("@NUMERO", cliente.Endereco.Numero);
                comando.Parameters.AddWithValue("@BAIRRO", cliente.Endereco.Bairro);
                comando.Parameters.AddWithValue("@CEP", cliente.Endereco.Cep);
                comando.Parameters.AddWithValue("@COMPLEMENTO", cliente.Endereco.Complemento);
                
        }

        private Cliente ConverterSqlParaObjeto(SqlDataReader leitor)
        {
            Cliente clienteBuscado = new Cliente();
            Endereco endereco = new Endereco();
            clienteBuscado.Cpf = long.Parse(leitor["CPF"].ToString());
            clienteBuscado.Nome = leitor["NOME"].ToString();
            clienteBuscado.DataNascimento = Convert.ToDateTime(leitor["DATA_NASCIMENTO"].ToString());
            clienteBuscado.PontosFidelidade = int.Parse(leitor["PONTOS_FIDELIDADE"].ToString());
            endereco.Rua = leitor["RUA"].ToString();
            endereco.Numero = int.Parse(leitor["NUMERO"].ToString());
            endereco.Bairro = leitor["BAIRRO"].ToString();
            endereco.Cep = long.Parse(leitor["CEP"].ToString());
            endereco.Complemento = leitor["COMPLEMENTO"].ToString();

            clienteBuscado.Endereco = endereco;

            return clienteBuscado;
        }

    }
}