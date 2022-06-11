using System.Data;
using System.Data.SqlClient;

namespace Factory
{
    class Program
    {
        /// <summary>
        /// FactoryGof - Similar ao Builder, porém o builder é mais utilizado
        /// quando há variações na criação dos objetos
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //IDbConnection conexao = new SqlConnection();
            //conexao.ConnectionString = "User Id=Teste; Password=123456; server=localhost;DataBase=teste";
            //conexao.Open();
            

            var conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM USUARIO WHERE ID = 10";
        }
    }
}
