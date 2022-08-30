using System.Collections.Generic;
using System.Data.SqlClient;
using ContaDeLuz.Domain;

namespace ContaDeLuz.Infra.SqlServer.DAO
{
    public class ContaDeLuzDAO
    {
        private const string _connectionString = @"server=.\SQLEXPRESS;initial catalog=CONTA_DE_LUZ;integrated security=true;";

        public ContaDeLuzDAO()
        {
            
        }
        public void AdicionarConta(ContaLuz novaConta)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    string sql = @"INSERT CONTA_DE_LUZ VALUES (@NUMERO_FATURA, @DATA_LEITURA, @QUANTIDADE_KW, @VALOR, @DATA_PAGAMENTO, @MEDIA_CONSUMO, @CADASTRADA);";

                    ConverteObjetoParaSql(novaConta, comando);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public List<ContaLuz> BuscarTodos()
        {
            var listaContas= new List<ContaLuz>();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;

                    string sql = @"SELECT * FROM CONTA_DE_LUZ";

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                      
                        ContaLuz contaBuscada = ConverterSqlParaObjeto(leitor);

                        listaContas.Add(contaBuscada);
                        
                    }
                   
                }
            }

            return listaContas;
        }
        public void DeletarConta(ContaLuz contaBuscada)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"DELETE FROM CONTA_DE_LUZ WHERE NUMERO_FATURA = @NUMERO_FATURA;";

                    comando.Parameters.AddWithValue("@NUMERO_FATURA", contaBuscada.NumeroFatura);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        public void DeletarTodasAsFaturas()
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"DELETE FROM CONTA_DE_LUZ;";

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        
        public ContaLuz BuscarPorNumeroFatura(int numeroFatura)
        {
            var contaBuscada = new ContaLuz();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"SELECT NUMERO_FATURA, DATA_LEITURA, QUANTIDADE_KW, VALOR, DATA_PAGAMENTO, MEDIA_CONSUMO FROM PEDIDO WHERE NUMERO_FATURA = @NUMERO_FATURA;"; 

                    comando.Parameters.AddWithValue("@NUMERO_FATURA", numeroFatura);

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader(); 
                    
                    while (leitor.Read())
                    {
                        
                        contaBuscada = ConverterSqlParaObjeto(leitor);
                    }
                    
                }
            }

            return contaBuscada;
        }
        
        public void AtualizarConta(ContaLuz contaBuscada) 
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open(); 

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"UPDATE CONTA_DE_LUZ SET            
                                        DATA_LEITURA = @DATA_LEITURA,
                                        QUANTIDADE_KW = @QUANTIDADE_KW,
                                        VALOR = @VALOR,
                                        DATA_PAGAMENTO = @DATA_PAGAMENTO,
                                        MEDIA_CONSUMO = @MEDIA_CONSUMO
                                 WHERE NUMERO_FATURA = @NUMERO_FATURA;";

                    ConverteObjetoParaSql(contaBuscada, comando);
                    comando.Parameters.AddWithValue("@NUMERO_FATURA", contaBuscada.NumeroFatura);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        private void ConverteObjetoParaSql(ContaLuz conta, SqlCommand comando)
        {
                comando.Parameters.AddWithValue("@NUMERO_FATURA", conta.NumeroFatura);
                comando.Parameters.AddWithValue("@DATA_LEITURA", conta.DataLeitura);
                comando.Parameters.AddWithValue("@QUANTIDADE_KW", conta.QuantidadeKw);
                comando.Parameters.AddWithValue("@VALOR", conta.Valor);
                comando.Parameters.AddWithValue("@DATA_PAGAMENTO", conta.DataPagamento);
                comando.Parameters.AddWithValue("@MEDIA_CONSUMO", conta.MediaConsumo);
                comando.Parameters.AddWithValue("@CADASTRADA", conta.Cadastrada);
                                
        }

        private ContaLuz ConverterSqlParaObjeto(SqlDataReader leitor)
        {
            ContaLuz contaBuscada = new ContaLuz();

            contaBuscada.NumeroFatura = int.Parse(leitor["NUMERO_FATURA"].ToString());            
            contaBuscada.DataLeitura = System.Convert.ToDateTime(leitor["DATA_LEITURA"].ToString());
            contaBuscada.QuantidadeKw = decimal.Parse(leitor["QUANTIDADE_KW"].ToString());
            contaBuscada.Valor = decimal.Parse(leitor["VALOR"].ToString());
            contaBuscada.DataPagamento = System.Convert.ToDateTime(leitor["DATA_PAGAMENTO"].ToString());
            contaBuscada.MediaConsumo = decimal.Parse(leitor["MEDIA_CONSUMO"].ToString());
            
            return contaBuscada;
        }


    }
}
