using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Retiro
{
    internal class RetiroDAO
    {

        String textoConexao =
            "Server=LAPTOP-D8OL4EF6\\PEDRO;Database=Retiro;Trusted_Connection=True;";


        public DataTable ListarTodas()
        {
            //cria uma conexão com banco de dados usando o texto acima
            SqlConnection conexao = new SqlConnection(textoConexao);
            //monta o comando sql que será executado
            SqlCommand comandoSql = new SqlCommand("SELECT * FROM Vacas", conexao);
            //cria a "ponte" entre seu programa e o banco de dados
            SqlDataAdapter adaptadorBanco = new SqlDataAdapter(comandoSql);
            //cria e executa o comando sql e joga os dados na variável
            DataTable tabelaResultado = new DataTable();
            adaptadorBanco.Fill(tabelaResultado);
            //retorna a tabela com os dados
            return tabelaResultado;
        }
        public void Adicionar(string nome)
        {
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "INSERT INTO vacas (NomeVaca) VALUES (@NomeVaca)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@NomeVaca", nome);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void Atualizar(int id, string nome)
        {
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "UPDATE vacas SET NomeVaca=@NomeVaca WHERE IDVaca=@IDVaca";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@IDVaca", id);
                    command.Parameters.AddWithValue("@NomeVaca", nome);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void Excluir(int id)
        {
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "DELETE FROM vacas WHERE ID=@ID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }



        }
    }
}
