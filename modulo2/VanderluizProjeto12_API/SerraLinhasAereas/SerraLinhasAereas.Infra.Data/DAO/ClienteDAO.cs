using SerraLinhasAereas.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SerraLinhasAereas.Infra.Data
{
    public class ClienteDAO
    {
        private const string _connectionString = @"server=.\SQLEXPRESS;initial catalog=CONTA_DE_LUZ;integrated security=true;";

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

                    string sql = @"INSERT SERRA_LINHAS_AEREAS VALUES (@CPF, @NOME, @SOBRENOME, @RUA, @NUMERO, @BAIRRO, @CEP, @COMPLEMENTO);";

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

                    string sql = @"SELECT * FROM SERRA_LINHAS_AEREAS";

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                      
                        Cliente clienteBuscado = ConverterSqlParaObjeto(leitor);

                        listaClientes.Add(clienteBuscado);
                        
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
        public Cliente BuscarPorCpf(long cpf)
        {
            var clienteBuscado = new Cliente();

            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"SELECT CPF, NOME, SOBRENOME, RUA, NUMERO, BAIRRO, CEP, COMPLEMENTO FROM PEDIDO WHERE CPF = @CPF;"; 

                    comando.Parameters.AddWithValue("@CPF", cpf);

                    comando.CommandText = sql;

                    SqlDataReader leitor = comando.ExecuteReader(); 
                    
                    while (leitor.Read())
                    {
                        
                        clienteBuscado = ConverterSqlParaObjeto(leitor);
                    }
                    
                }
            }

            return clienteBuscado;
        }
        
        public void AtualizarCliente(Cliente clienteBuscado) 
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Open(); 

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao; 

                    string sql = @"UPDATE CONTA_DE_LUZ SET NOME, SOBRENOME, RUA, NUMERO, BAIRRO, CEP, COMPLEMENTO FROM PEDIDO WHERE CPF = @CPF;";

                    ConverteObjetoParaSql(clienteBuscado, comando);
                    comando.Parameters.AddWithValue("@CPF", clienteBuscado.Cpf);

                    comando.CommandText = sql;

                    comando.ExecuteNonQuery();
                }
            }
        }
        private void ConverteObjetoParaSql(Cliente cliente, SqlCommand comando)
        {
                comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
                comando.Parameters.AddWithValue("@NOME", cliente.Nome);
                comando.Parameters.AddWithValue("@SOBRENOME", cliente.Sobrenome);
                comando.Parameters.AddWithValue("@RUA", cliente.endereco.Rua);
                comando.Parameters.AddWithValue("@NUMERO", cliente.endereco.Numero);
                comando.Parameters.AddWithValue("@BAIRRO", cliente.endereco.Bairro);
                comando.Parameters.AddWithValue("@CEP", cliente.endereco.Cep);
                comando.Parameters.AddWithValue("@COMPLEMENTO", cliente.endereco.Complemento);
                                
        }

        private Cliente ConverterSqlParaObjeto(SqlDataReader leitor)
        {
            Cliente clienteBuscado = new Cliente();
            Endereco endereco = new Endereco();

            clienteBuscado.Cpf = long.Parse(leitor["CPF"].ToString());            
            clienteBuscado.Nome = leitor["NOME"].ToString();
            clienteBuscado.Sobrenome = leitor["SOBRENOME"].ToString();
            endereco.Rua = leitor["RUA"].ToString();
            endereco.Numero = int.Parse(leitor["NUMERO"].ToString());
            endereco.Bairro = leitor["BAIRRO"].ToString();
            endereco.Cep = leitor["CEP"].ToString();
            endereco.Complemento = leitor["COMPLEMENTO"].ToString();
            
            clienteBuscado.endereco = endereco;
            return clienteBuscado;
        }
    }
}
