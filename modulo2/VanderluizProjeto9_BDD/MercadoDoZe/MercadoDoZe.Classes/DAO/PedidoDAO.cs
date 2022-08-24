using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MercadoDoZe.Classes.DAO

{
    public class PedidoDAO
    {
        private const string _connectionString = @"server=.\SQLEXPRESS;initial catalog=MERCADO_DO_ZE;integrated security=true;";

        public PedidoDAO()
        {
            
        }
        public void AdicionarPedido(Pedido novoPedido)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    string sql = @"INSERT PEDIDO VALUES (@DATA_HORA, @CPF_CLIENTE, @ID_PRODUTO, @QTD_RESERVADA, @VALOR_TOTAL);";

                    ConverteObjetoParaSql(novoPedido, comando);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public List<Pedido> BuscarTodos()
        {
            var listaPedidos= new List<Pedido>();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    string sql = @"SELECT * FROM PEDIDO";

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader();

                    bool validarConsulta = false; 
                    while (leitor.Read())
                    {
                        validarConsulta = true;
                        Pedido pedidoBuscado = ConverterSqlParaObjeto(leitor);

                        listaPedidos.Add(pedidoBuscado);
                        
                    }
                    if (!validarConsulta)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("A tabela PEDIDO esta vazia.");
                    }
                }
            }

            return listaPedidos;
        }
        public void DeletarPedido(Pedido pedidoBuscado)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"DELETE FROM PEDIDO WHERE ID = @ID;";

                    comando.Parameters.AddWithValue("@ID", pedidoBuscado.Id);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public void DeletarTodosOsPedidos()
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"DELETE FROM PEDIDO;"
                                + @"DBCC CHECKIDENT ('PEDIDO', RESEED, 0);";

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        
        public Pedido BuscarPorId(int id)
        {
            var pedidoBuscado = new Pedido();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"SELECT ID, DATA_HORA, CPF_CLIENTE, ID_PRODUTO, QTD_RESERVADA, VALOR_TOTAL FROM PEDIDO WHERE ID = @ID_PEDIDO;"; 

                    comando.Parameters.AddWithValue("@ID_PEDIDO", id);

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader(); 
                    bool validarConsulta = false; 
                    while (leitor.Read())
                    {
                        validarConsulta = true;
                        pedidoBuscado = ConverterSqlParaObjeto(leitor);
                    }
                    if (!validarConsulta)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine($"Não tem nenhum pedido na tabela PEDIDO"
                                                +$"com o ID indicado.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            return pedidoBuscado;
        }
        private void ConverteObjetoParaSql(Pedido pedido, SqlCommand comando)
        {
                comando.Parameters.AddWithValue("@DATA_HORA", pedido.DataPedido);
                comando.Parameters.AddWithValue("@CPF_CLIENTE", pedido.CpfCliente);
                comando.Parameters.AddWithValue("@ID_PRODUTO", pedido.IdProduto);
                comando.Parameters.AddWithValue("@QTD_RESERVADA", pedido.QtdReservado);
                comando.Parameters.AddWithValue("@VALOR_TOTAL", pedido.ValorTotalPedido);
                                
        }

        private Pedido ConverterSqlParaObjeto(SqlDataReader leitor)
        {
            Pedido pedidoBuscado = new Pedido();

            pedidoBuscado.Id = int.Parse(leitor["ID"].ToString());            
            pedidoBuscado.DataPedido = Convert.ToDateTime(leitor["DATA_HORA"].ToString());
            pedidoBuscado.CpfCliente = long.Parse(leitor["CPF_CLIENTE"].ToString());
            pedidoBuscado.IdProduto = int.Parse(leitor["ID_PRODUTO"].ToString());
            pedidoBuscado.QtdReservado = int.Parse(leitor["QTD_RESERVADA"].ToString());
            pedidoBuscado.ValorTotalPedido = decimal.Parse(leitor["VALOR_TOTAL"].ToString());
            
            return pedidoBuscado;
        }

    }
}