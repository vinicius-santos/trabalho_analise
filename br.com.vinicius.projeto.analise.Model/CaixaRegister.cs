using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    public class CaixaRegister : RegisterBase
    {
        private List<Dictionary<string, object>> objectList;

        public override string Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public override string Edit(object obj)
        {
            throw new NotImplementedException();
        }

        public override string Insert(Object obj)
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            Caixa caixa = (Caixa)obj;
            var sql = @"INSERT INTO Caixa(idAnalise) VALUES(@param1)";
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
                            parameter.Value = caixa.IdAmostra;
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

        
        public override List<Dictionary<string, object>> SelectAll()
        {
            factory = DbProviderFactories.GetFactory(provider);
            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;

            using (DbConnection conn = connection)
            {
                conn.Open();
                string sql = "select top 12 * from  Amostra" +
                    " inner join Caixa on Amostra.id = Caixa.idAnalise where analisada is null or analisada !=@status";
                using (DbCommand cmd = conn.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;
                        var parameter = cmd.CreateParameter();
                        parameter.ParameterName = "@status";
                        parameter.Value = 1;
                        cmd.Parameters.Add(parameter);
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
    }
}
