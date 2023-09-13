using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public Cadastro(String Nome, String Telefone, String Email)
        {
            //ComandoSql -- SqlCommand -- insert, update, delete
            cmd.CommandText = "insert into TBCadastro (Nome, Telefone, Email) values (@nome, @telefone, @email)"; 

            //parametros
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@telefone", Telefone);
            cmd.Parameters.AddWithValue("@email", Email);


            try
            {
                //conectar banco -- Conexao
                cmd.Connection = conexao.conectar();

                //executar comando
                cmd.ExecuteNonQuery();

                //desconectar
                conexao.desconectar();

                //mostrar mensagem de erro ou sucesso -- erro ou sucesso
                this.mensagem = "Cadastrado com sucesso!";

            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o Banco de Dados.";
            }
            
            
           

        }
    }
}
