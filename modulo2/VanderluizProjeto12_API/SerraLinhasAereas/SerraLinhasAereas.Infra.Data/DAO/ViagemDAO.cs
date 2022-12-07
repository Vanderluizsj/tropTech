using System;
using SerraLinhasAereas.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SerraLinhasAereas.Infra.Data
{
    public class ViagemDAO
    {
        private const string _connectionString = @"server=.\SQLEXPRESS;initial catalog=CONTA_DE_LUZ;integrated security=true;";

        public ViagemDAO()
        {
            
        }
        public void AdicionarViagem(Viagem novaViagem)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    string sql = @"INSERT VIAGEM VALUES (@CODIGO_RESERVA, @IDA_VOLTA, @DATA_COMPRA, @VALOR_TOTAL, @PASSAGEM_IDA, @PASSAGEM_VOLTA, @CPF_CLIENTE);";

                    ConverteObjetoParaSql(novaViagem, comando);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public List<Viagem> BuscarTodos()
        {
            var listaViagem = new List<Viagem>();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    string sql = @"SELECT * FROM SERRA_LINHAS_AEREAS";

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                      
                        Viagem viagemBuscada = ConverterSqlParaObjeto(leitor);

                        listaViagem.Add(viagemBuscada);
                        
                    }
                   
                }
            }

            return listaViagem;
        }
        public void DeletarViagem(Viagem viagemBuscada)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"DELETE FROM VIAGEM WHERE CODIGO_RESERVA = @CODIGO_RESERVA;";

                    comando.Parameters.AddWithValue("@CODIGO_RESERVA", viagemBuscada.CodigoReserva);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }        
        public Viagem BuscarPorCodigo(string codigoReserva)
        {
            var viagemBuscada = new Viagem();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"SELECT CODIGO_RESERVA, IDA_VOLTA, DATA_COMPRA, VALOR_TOTAL, PASSAGEM_IDA, PASSAGEM_VOLTA, CPF_CLIENTE FROM VIAGEM WHERE CODIGO_RESERVA = @CODIGO_RESERVA;"; 

                    comando.Parameters.AddWithValue("@CODIGO_RESERVA", codigoReserva);

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader(); 
                    
                    while (leitor.Read())
                    {
                        
                        viagemBuscada = ConverterSqlParaObjeto(leitor);
                    }
                    
                }
            }

            return viagemBuscada;
        }
        
        public void AtualizarViagem(Viagem viagemBuscada) 
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open(); 

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"UPDATE VIAGEM SET IDA_VOLTA, DATA_COMPRA, VALOR_TOTAL, PASSAGEM_IDA, PASSAGEM_VOLTA, CPF_CLIENTE FROM VIAGEM WHERE CODIGO_RESERVA = @CODIGO_RESERVA;";

                    ConverteObjetoParaSql(viagemBuscada, comando);
                    comando.Parameters.AddWithValue("@CODIGO_RESERVA", viagemBuscada.CodigoReserva);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        private void ConverteObjetoParaSql(Viagem viagem, SqlCommand comando)
        {
                comando.Parameters.AddWithValue("@CODIGO_RESERVA", viagem.CodigoReserva);
                comando.Parameters.AddWithValue("@IDA_VOLTA", viagem.IdaVolta);
                comando.Parameters.AddWithValue("@DATA_COMPRA", viagem.DataCompra);
                comando.Parameters.AddWithValue("@VALOR_TOTAL", viagem.ValorTotal);
                comando.Parameters.AddWithValue("@PASSAGEM_IDA", viagem.PassagemIda);
                comando.Parameters.AddWithValue("@PASSAGEM_VOLTA", viagem.PassagemVolta);
                comando.Parameters.AddWithValue("@CPF_CLIENTE", viagem.Cliente.Cpf);
                                
        }

        private Viagem ConverterSqlParaObjeto(SqlDataReader leitor)
        {
            Viagem viagemBuscada = new Viagem();
            Cliente cliente = new Cliente();

            viagemBuscada.CodigoReserva = leitor["CODIGO_RESERVA"].ToString();            
            viagemBuscada.IdaVolta = bool.Parse(leitor["IDA_VOLTA"].ToString());
            viagemBuscada.DataCompra = Convert.ToDateTime(leitor["DATA_COMPRA"].ToString());
            viagemBuscada.ValorTotal = float.Parse(leitor["VALOR_TOTAL"].ToString());
            viagemBuscada.PassagemIda = bool.Parse(leitor["PASSAGEM_IDA"].ToString());
            viagemBuscada.PassagemVolta = bool.Parse(leitor["PASSAGEM_VOLTA"].ToString());
            cliente.Cpf = long.Parse(leitor["CPF_CLIENTE"].ToString());
            
            viagemBuscada.Cliente = cliente;
            
            return viagemBuscada;
        }
    }
}
