using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class IngredienteRegistro
    {
        protected string connectionString = "server=127.0.0.1;uid=root;pwd=admin;database=analise";
        public string provider = @"MySql.Data.MySqlClient";
        public DbConnection connection = null;
        public DbProviderFactory factory;
        private List<Dictionary<string, object>> objectList;


        public  List<Dictionary<string, object>> SelectAll()
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;

            using (DbConnection conn = connection)
            {
                conn.Open();
                string sql = "select * from  ingrediente";
                using (DbCommand cmd = conn.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;
                        using (DbDataReader reader = cmd.ExecuteReader())
                        {
                            objectList = new List<Dictionary<string, object>>();
                            while (reader.Read())
                            {
                                var ingrediente = new Dictionary<string, object>();
                                {
                                    ingrediente.Add("Id", Convert.ToInt32(reader["id"]));
                                    ingrediente.Add("Nome", reader["nome"]?.ToString());
                                };
                                objectList.Add(ingrediente);
                            }
                            return objectList;
                        }
                    }
                    catch (DbException ex)
                    {
                        return null;
                    }
                }

            }

        }


        public string Insert(Object obj)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            Ingrediente ingrediente = (Ingrediente)obj;
            var sql = @"INSERT INTO ingrediente(Nome) VALUES(@param1)";
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
                            parameter.Value = ingrediente.Nome;
                            cmd.Parameters.Add(parameter);
                            cmd.ExecuteNonQuery();
                            tran.Commit();
                            return "Cadastrado com sucesso";
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
