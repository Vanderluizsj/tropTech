using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MercadoDoZe.Classes.DAO

{
    public class ProdutoDAO
    {
        private const string _connectionString = @"server=.\SQLEXPRESS;initial catalog=MERCADO_DO_ZE;integrated security=true;";

        public ProdutoDAO()
        {
            
        }
        public void AdicionarProduto(Produto novoProduto)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    string sql = @"INSERT PRODUTO VALUES (@NOME, @DESCRICAO, @VENCIMENTO, @PRECO, @UNIDADE, @QTD_ESTOQUE);";

                    ConverteObjetoParaSql(novoProduto, comando);

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

        private void ConverteObjetoParaSql(Produto produto, SqlCommand comando)
        {
                comando.Parameters.AddWithValue("@NOME", produto.Nome);
                comando.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
                comando.Parameters.AddWithValue("@VENCIMENTO", produto.Vencimento);
                comando.Parameters.AddWithValue("@PRECO", produto.Preco);
                comando.Parameters.AddWithValue("@UNIDADE", produto.Unidade);
                comando.Parameters.AddWithValue("@QTD_ESTOQUE", produto.QuantidadeEstoque);
        }

        private Produto ConverterSqlParaObjeto(SqlDataReader leitor)
        {
            Produto produtoBuscado = new Produto();
            produtoBuscado.Id = int.Parse(leitor["ID"].ToString());
            produtoBuscado.Nome = leitor["NOME"].ToString();
            produtoBuscado.Descricao = leitor["DESCRICAO"].ToString();
            produtoBuscado.Vencimento = Convert.ToDateTime(leitor["DATA_VENCIMENTO"].ToString());
            produtoBuscado.Preco = float.Parse(leitor["PRECO_UNITARIO"].ToString());
            produtoBuscado.Unidade = leitor["UNIDADE"].ToString();
            produtoBuscado.QuantidadeEstoque = int.Parse(leitor["QTD_ESTOQUE"].ToString());

            return produtoBuscado;
        }

    }
}