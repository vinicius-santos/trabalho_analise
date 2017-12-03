using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReceitaRegistro
    {
        protected string connectionString = "server=127.0.0.1;uid=root;pwd=admin;database=analise";
        public string provider = @"MySql.Data.MySqlClient";
        public DbConnection connection = null;
        public DbProviderFactory factory;
        private List<Dictionary<string, object>> objectList;


        public int  Insert(Object obj)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            Receita receita = (Receita)obj;
            var sql = @"INSERT INTO receita(Nome,comoFazer) VALUES(@param1,@param2)";
            using (DbConnection conn = connection)
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    using (DbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;
                        try
                        {
                            cmd.Transaction = tran;
                            var parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param1";
                            parameter.Value = receita.Nome;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param2";
                            parameter.Value = receita.ComoFazer;
                            cmd.Parameters.Add(parameter);
                            var id = cmd.ExecuteNonQuery();
                            tran.Commit();
                            return id;
                        }
                        catch (DbException ex)
                        {
                            tran.Rollback();
                            return -1;
                        }
                        finally
                        {
                            cmd.Dispose();
                            if (conn.State.Equals("Open")) conn.Close();
                        }

                    }
                }
            }
        }

        public string InsertIngredientsReceita(Object obj)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            IngredienteReceita ingredienteReceita = (IngredienteReceita)obj;
            var sql = @"INSERT INTO ingredienteReceita(idReceita,idIngrediente) VALUES(@param1,@param2)";
            using (DbConnection conn = connection)
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    using (DbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;
                        try
                        {
                            cmd.Transaction = tran;
                            var parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param1";
                            parameter.Value = ingredienteReceita.IdReceita;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param2";
                            parameter.Value = ingredienteReceita.IdIngrediente;
                            cmd.Parameters.Add(parameter);
                            var id = cmd.ExecuteNonQuery();
                            tran.Commit();
                            return "Sucesso ao cadastrar";
                        }
                        catch (DbException ex)
                        {
                            tran.Rollback();
                            return "Erro ao cadastrar";
                        }
                        finally
                        {
                            cmd.Dispose();
                            if (conn.State.Equals("Open")) conn.Close();
                        }

                    }
                }
            }
        }
        }
}
