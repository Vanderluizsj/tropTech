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
        public List<Produto> BuscarTodos()
        {
            var listaProdutos= new List<Produto>();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    string sql = @"SELECT * FROM PRODUTO";

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader();

                    bool validarConsulta = false; 
                    while (leitor.Read())
                    {
                        validarConsulta = true;
                        Produto produtoBuscado = ConverterSqlParaObjeto(leitor);

                        listaProdutos.Add(produtoBuscado);
                        
                    }
                    if (!validarConsulta)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("A tabela PRODUTO esta vazia.");
                    }
                }
            }

            return listaProdutos;
        }
        public void DeletarProduto(Produto produtoBuscado)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"DELETE FROM PRODUTO WHERE ID = @ID;";

                    comando.Parameters.AddWithValue("@ID", produtoBuscado.Id);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public void DeletarTodosOsProdutos()
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"DELETE FROM PRODUTO;"
                               + @"DBCC CHECKIDENT ('PRODUTO', RESEED, 0);";

                    //comando.ExecuteScalar();

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public void AtualizarProduto(Produto produtoBuscado) 
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open(); 

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"UPDATE PRODUTO SET            
                                        NOME = @NOME,
                                        DESCRICAO = @DESCRICAO,
                                        DATA_VENCIMENTO = @VENCIMENTO,
                                        PRECO_UNITARIO = @PRECO,
                                        UNIDADE = @UNIDADE
                                 WHERE ID = @ID;";

                    ConverteObjetoParaSql(produtoBuscado, comando);
                    comando.Parameters.AddWithValue("@ID", produtoBuscado.Id);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public void EntradaESaidaEstoque(Produto produtoBuscado)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"UPDATE PRODUTO SET QTD_ESTOQUE = @QUANTIDADE_ESTOQUE WHERE ID = @ID;";

                    ConverteObjetoParaSql(produtoBuscado, comando);
                    comando.Parameters.AddWithValue("@ID", produtoBuscado.Id);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public List<Produto> BuscaPorTexto(string descricao)
        {
            var listaProduto = new List<Produto>(); 

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"SELECT ID, NOME, DESCRICAO, DATA_VENCIMENTO, 
                    PRECO_UNITARIO,  UNIDADE, QTD_ESTOQUE FROM PRODUTO WHERE DESCRICAO LIKE @TEXTO;"; 

                    comando.Parameters.AddWithValue("@TEXTO", $"%{descricao}%");

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader(); 
                    bool validarConsulta = false; 
                    while (leitor.Read())
                    {
                        validarConsulta = true;
                        var produtoBuscado = ConverterSqlParaObjeto(leitor);
                        
                        listaProduto.Add(produtoBuscado);
                    }
                    if (!validarConsulta)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine($"Não tem nenhum produto na tabela PRODUTO "
                                                +$"com a descrição indicada.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            return listaProduto;
        }
        public Produto BuscarPorId(int id)
        {
            var produtoBuscado = new Produto();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"SELECT ID, NOME, DESCRICAO, DATA_VENCIMENTO, PRECO_UNITARIO, UNIDADE,QTD_ESTOQUE FROM PRODUTO WHERE ID = @ID;"; 

                    comando.Parameters.AddWithValue("@ID", id);

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader(); 
                    bool validarConsulta = false; 
                    while (leitor.Read())
                    {
                        validarConsulta = true;
                        produtoBuscado = ConverterSqlParaObjeto(leitor);
                    }
                    if (!validarConsulta)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine($"Não tem nenhum produto na tabela PRODUTO "
                                                +$"com o ID indicado.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            return produtoBuscado;
        }
        public void EntradaSaidaEstoque(Produto produtoBuscado)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open(); 

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"UPDATE PRODUTO SET QTD_ESTOQUE = @QTD_ESTOQUE WHERE ID = @ID;";

                    ConverteObjetoParaSql(produtoBuscado, comando);
                    comando.Parameters.AddWithValue("@ID", produtoBuscado.Id);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
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