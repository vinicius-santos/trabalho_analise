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
using System.Data.OleDb;

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
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            Client client = (Client)obj;
            var sql = @"INSERT INTO Client(name, cellPhone,registration,city,state) VALUES(@param1, @param2, @param3, @param4, @param5)";
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
                            parameter.Value = client.Name;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param2";
                            parameter.Value = client.CellPhone;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param3";
                            parameter.Value = client.Registration;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param4";
                            parameter.Value = client.City;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param5";
                            parameter.Value = client.State;
                            cmd.Parameters.Add(parameter);
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


        public override string Edit(Object obj)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            Client client = (Client)obj;
            var sql = @"UPDATE  Client Set name = @param1 , cellPhone = @param2,registration = @param3,city =@param4,state =@param5 Where id = @id";
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
                            parameter.ParameterName = "@id";
                            parameter.Value = client.Id;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param1";
                            parameter.Value = client.Name;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param2";
                            parameter.Value = client.CellPhone;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param3";
                            parameter.Value = client.Registration;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param4";
                            parameter.Value = client.City;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param5";
                            parameter.Value = client.State.ToUpper();
                            cmd.Parameters.Add(parameter);
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

        public override string Delete(Object obj)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            Client client = (Client)obj;
            var sql = @"Delete FROM   Client  Where id = @id";
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
                            parameter.ParameterName = "@id";
                            parameter.Value = client.Id;
                            cmd.Parameters.Add(parameter);
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