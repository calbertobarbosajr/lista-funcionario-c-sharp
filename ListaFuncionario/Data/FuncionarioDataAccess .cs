using ListaFuncionario.Model;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFuncionario.Data
{
    internal class FuncionarioDataAccess
    {
        private static string connectionString = "Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=ListaFuncionario;Integrated Security=True";
        public static List<Funcionario> ObterTodosFuncionarios()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM [ListaFuncionario].[dbo].[Funcionario]";
                var funcionarios = connection.Query<Funcionario>(query).AsList();
                return funcionarios;
            }
        }

        public static bool SalvarFuncionario(Funcionario funcionario)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO [Funcionario] (Nome, Email, Salario, Sexo, TipoContrato, DataCadastro) VALUES (@Nome, @Email, @Salario, @Sexo, @TipoContrato, @DataCadastro)";
                con.Open();
                int rowsAffected = con.Execute(sql, funcionario);
                return rowsAffected > 0;
            }
        }

        public static Funcionario PegarFuncionario(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM [Funcionario] WHERE Id = @id";
                con.Open();
                return con.QueryFirstOrDefault<Funcionario>(sql, new { id });
            }
        }

        public static bool AtualizarFuncionario(Funcionario funcionario)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "UPDATE [Funcionario] SET Nome = @Nome, Email = @Email, Salario = @Salario, Sexo = @Sexo, TipoContrato = @TipoContrato, DataAtualizacao = @DataAtualizacao WHERE Id = @Id";
                con.Open();
                int rowsAffected = con.Execute(sql, funcionario);
                return rowsAffected > 0;
            }
        }

        public static bool ExcluirFuncionario(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM [Funcionario] WHERE Id = @id";
                con.Open();
                int rowsAffected = con.Execute(sql, new { id });
                return rowsAffected > 0;
            }
        }


    }
}
