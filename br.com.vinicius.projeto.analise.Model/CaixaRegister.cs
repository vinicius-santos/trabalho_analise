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
            throw new NotImplementedException();
        }
    }
}
