using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();

            conexao.ConnectionString = "User Id=Teste; Password=123456; server=localhost;DataBase=teste";
            conexao.Open();

            return conexao;
        }
    }
}
