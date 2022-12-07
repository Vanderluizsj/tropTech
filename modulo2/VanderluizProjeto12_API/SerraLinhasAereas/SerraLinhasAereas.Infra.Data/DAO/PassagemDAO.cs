using System;
using SerraLinhasAereas.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SerraLinhasAereas.Infra.Data
{
    public class PassagemDAO
    {
        private const string _connectionString = @"server=.\SQLEXPRESS;initial catalog=CONTA_DE_LUZ;integrated security=true;";

        public PassagemDAO()
        {
            
        }
        public void AdicionarPassagem(Passagem novaPassagem)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    string sql = @"INSERT SERRA_LINHAS_AEREAS VALUES (@ID_PASSAGEM, @ORIGEM, @DESTINO, @DATA_ORIGEM, @DATA_DESTINO, @VALOR);";

                    ConverteObjetoParaSql(novaPassagem, comando);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public List<Passagem> BuscarTodos()
        {
            var listaPassagens= new List<Passagem>();

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
                      
                        Passagem passagemBuscada = ConverterSqlParaObjeto(leitor);

                        listaPassagens.Add(passagemBuscada);
                        
                    }
                   
                }
            }

            return listaPassagens;
        }
        public void DeletarPassagem(Passagem passagemBuscada)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"DELETE FROM CLIENTE WHERE ID_PASSAGEM = @ID_PASSAGEM;";

                    comando.Parameters.AddWithValue("@ID_PASSAGEM", passagemBuscada.IdPassagem);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }        
        public Passagem BuscarPorId(int id)
        {
            var passagemBuscada = new Passagem();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"SELECT ID_PASSAGEM, ORIGEM, DESTINO, DATA_ORIGEM, DATA_DESTINO, VALOR FROM PASSAGEM WHERE ID_PASSAGEM = @ID_PASSAGEM;"; 

                    comando.Parameters.AddWithValue("@ID_PASSAGEM", id);

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader(); 
                    
                    while (leitor.Read())
                    {
                        
                        passagemBuscada = ConverterSqlParaObjeto(leitor);
                    }
                    
                }
            }

            return passagemBuscada;
        }
        
        public void AtualizarPassagem(Passagem passagemBuscada) 
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open(); 

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"UPDATE PASSAGEM SET ORIGEM, DESTINO, DATA_ORIGEM, DATA_DESTINO, VALOR FROM PASSAGEM WHERE ID_PASSAGEM = @ID_PASSAGEM;";

                    ConverteObjetoParaSql(passagemBuscada, comando);
                    comando.Parameters.AddWithValue("@ID_PASSAGEM", passagemBuscada.IdPassagem);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        private void ConverteObjetoParaSql(Passagem passagem, SqlCommand comando)
        {
                comando.Parameters.AddWithValue("@ID_PASSAGEM", passagem.IdPassagem);
                comando.Parameters.AddWithValue("@ORIGEM", passagem.Origem);
                comando.Parameters.AddWithValue("@DESTINO", passagem.Destino);
                comando.Parameters.AddWithValue("@DATA_ORIGEM", passagem.DataOrigem);
                comando.Parameters.AddWithValue("@DATA_DESTINO", passagem.DataDestino);
                comando.Parameters.AddWithValue("@VALOR", passagem.Valor);
                                                
        }

        private Passagem ConverterSqlParaObjeto(SqlDataReader leitor)
        {
            Passagem passagemBuscada = new Passagem();
            
            passagemBuscada.IdPassagem = int.Parse(leitor["ID_PASSAGEM"].ToString());            
            passagemBuscada.Origem = leitor["ORIGEM"].ToString();
            passagemBuscada.Destino = leitor["DESTINO"].ToString();
            passagemBuscada.DataOrigem = Convert.ToDateTime(leitor["DATA_ORIGEM"].ToString());
            passagemBuscada.DataDestino = Convert.ToDateTime(leitor["DATA_DESTINO"].ToString());
            passagemBuscada.Valor = float.Parse(leitor["DATA_DESTINO"].ToString());
            
            
            return passagemBuscada;
        }
    }
}
