using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    public class FolhaRegister : RegisterBase
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
            FolhaBase folha = (FolhaBase)obj;
            var sql = @"INSERT INTO folha(numero,ph,smp,argila,mo,ca,mg,al,p,k,na,cu,zn,fe,mn,s,pResina,b) VALUES(@param1, @param2, @param3, @param4, @param5,@param6,@param7,@param8,@param9,@param10,@param11,@param12,@param13,@param14,@param15,@param16,@param17,@param18)";
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
                            parameter.Value = folha.Numero;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param2";
                            parameter.Value = folha.Ph;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param3";
                            parameter.Value = folha.Smp;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param4";
                            parameter.Value = folha.Argila;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param5";
                            parameter.Value = folha.Mo;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param6";
                            parameter.Value = folha.Ca;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param7";
                            parameter.Value = folha.Mg;
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param8";
                            parameter.Value = folha.Al;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param9";
                            parameter.Value = folha.P;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param10";
                            parameter.Value = folha.K;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param11";
                            parameter.Value = folha.Na;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param12";
                            parameter.Value = folha.Cu;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param13";
                            parameter.Value = folha.Zn;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param14";
                            parameter.Value = folha.Fe;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param15";
                            parameter.Value = folha.Mn;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param16";
                            parameter.Value = folha.S;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param17";
                            parameter.Value = folha.PResina;
                            cmd.Parameters.Add(parameter);
                            parameter = cmd.CreateParameter();
                            parameter.ParameterName = "@param18";
                            parameter.Value = folha.B;
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
