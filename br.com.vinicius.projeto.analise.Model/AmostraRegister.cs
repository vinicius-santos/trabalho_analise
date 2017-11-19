using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{

    public class AmostraRegister : RegisterBase
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
                string sql = "select * from  Amostra";
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
                                var amostra = new Dictionary<string, object>();
                                {
                                    amostra.Add("Id", Convert.ToInt32(reader["id"]));
                                    amostra.Add("TipoAnalise", reader["tipoAnalise"]?.ToString());
                                    amostra.Add("GeoReferencia", reader["geoReferencia"].ToString());
                                    amostra.Add("Complemento", reader["complemento"].ToString());
                                    amostra.Add("IdCliente", Convert.ToInt32(reader["idCliente"]));
                                    amostra.Add("IdSolicitante", Convert.ToInt32(reader["idSolicitante"]));
                                    amostra.Add("Status", reader["status"].ToString());
                                };
                                objectList.Add(amostra);
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
            Amostra amostra = (Amostra)obj;
            var sql = @"INSERT INTO Amostra(tipoAnalise,geoReferencia,complemento,idCliente,idSolicitante,status) VALUES(@param1, @param2, @param3, @param4, @param5,@param6)";
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
                            parameter.Value = amostra.TipoAnalise;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param2";
                            parameter.Value = amostra.GeoReferencia;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param3";
                            parameter.Value = amostra.Complemento;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param4";
                            parameter.Value = amostra.IdCliente;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param5";
                            parameter.Value = amostra.IdSolicitante;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param6";
                            parameter.Value = amostra.Status;
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

        public override string Edit(object obj)
        {
            throw new NotImplementedException();
        }

        public override string Delete(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
