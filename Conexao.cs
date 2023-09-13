using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    public class Conexao
    {
        SqlConnection conn = new SqlConnection();

        //Contrutor
        public Conexao()
        {
            conn.ConnectionString = @"Data Source=DESKTOP-MQ8UDKK\SQLEXPRESS;Initial Catalog=BDCadastro;Integrated Security=True";
        }    

        //Metodo conectar
        public SqlConnection conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
                return conn; 

        }
        //Metodo desconctar
        public void desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
