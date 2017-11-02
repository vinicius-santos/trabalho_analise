using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace br.com.vinicius.projeto.analise.Model
{
    public class ClientRegister : RegisterBase
    {
        private List<Dictionary<string, object>> objectList;

        public override List<Dictionary<string, object>> SelectAll()
        {
            factory = DbProviderFactories.GetFactory(provider);

            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;

            using (DbConnection conn = connection)
            {
                conn.Open();
                string sql = "select * from  Client";
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
                                var client = new Dictionary<string, object>();
                                {
                                    client.Add("Id", Convert.ToInt32(reader["id"]));
                                    client.Add("CellPhone", reader["cellPhone"]?.ToString());
                                    client.Add("City", reader["city"].ToString());
                                    client.Add("Name", reader["name"].ToString());
                                    client.Add("Registration", Convert.ToInt32(reader["registration"]));
                                    client.Add("State", reader["state"].ToString());
                                };
                                objectList.Add(client);
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

        public override string Insert(Object obj)
        {
            Client client = (Client)obj;
            var sql = @"INSERT INTO Client(name, cellPhone,registration,city,state) VALUES(@param1, @param2, @param3, @param4, @param5)";
            using (SqlConnection conn = new SqlConnection(@"data source=VINICIUS-PC\SQLEXPRESS;Initial Catalog=Analise; Integrated Security = SSPI;"))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        try
                        {
                            cmd.Transaction = tran;
                            cmd.Parameters.Add("@param1", SqlDbType.VarChar, 200).Value = client.Name;
                            cmd.Parameters.Add("@param2", SqlDbType.VarChar, 20).Value = client.CellPhone;
                            cmd.Parameters.Add("@param3", SqlDbType.Int).Value = client.Registration;
                            cmd.Parameters.Add("@param4", SqlDbType.VarChar, 200).Value = client.City;
                            cmd.Parameters.Add("@param5", SqlDbType.Char, 2).Value = client.State;
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            tran.Commit();
                            return Messages.SuccesssDB;
                        }
                        catch (DbException ex)
                        {
                            tran.Rollback();
                            return Messages.ErrorDB(ex);
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