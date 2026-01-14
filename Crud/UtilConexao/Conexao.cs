using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.UtilConexao
{
    public class Conexao
    {
        private static string connectionString = "Server=localhost;Database=TCC_GestaoDEpecas;Uid=root;Pwd=paiemae27;";
            

        public static MySqlConnection GetConexao()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
