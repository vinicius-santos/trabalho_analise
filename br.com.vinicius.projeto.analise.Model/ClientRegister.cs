using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    public class ClientRegister : RegisterBase
    {
        string provider =
        "Oracle.DataAccess.Client.OracleConnection, Oracle.DataAccess";

        string connectionString =
        "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)" +
        "(HOST=MYHOST)(PORT=1527))(CONNECT_DATA=(SID=MYSERVICE)));" +
        "User Id=MYUSER;Password=MYPASS;";

        public override void Select()
        {
            using (DbConnection conn = (DbConnection)Activator.CreateInstance(Type.GetType(provider), connectionString))
            {
                conn.Open();
                string sql =
                  "select distinct owner from sys.all_objects order by owner";
                using (DbCommand comm = conn.CreateCommand())
                {
                    comm.CommandText = sql;
                    using (DbDataReader rdr = comm.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string owner = rdr.GetString(0);
                            Console.WriteLine("{0}", owner);
                        }
                    }
                }

            }
        }

        public override string Insert(Object obj)
        {
            Client client = (Client)obj;
            using (DbConnection conn = (DbConnection)Activator.CreateInstance(Type.GetType(provider), connectionString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    using (DbCommand cmd = conn.CreateCommand())
                    {
                        try
                        {
                            var parameter = cmd.CreateParameter();
                            cmd.CommandText = "INSERT INTO Client(name, cellPhone,registration,city,state) VALUES(@param1, @param2, @param3, @param4, @param5)";
                            parameter.ParameterName = "@param1";
                            parameter.Value = client.Name;
                            cmd.Parameters.Add(parameter);
                            parameter.ParameterName = "@param2";
                            parameter.Value = client.CellPhone;
                            cmd.Parameters.Add(parameter);
                            parameter.ParameterName = "@param3";
                            parameter.Value = client.Registration;
                            cmd.Parameters.Add(parameter);
                            parameter.ParameterName = "@param4";
                            parameter.Value = client.City;
                            cmd.Parameters.Add(parameter);
                            parameter.ParameterName = "@param5";
                            parameter.Value = client.State;
                            cmd.Parameters.Add(parameter);
                            int modified = cmd.ExecuteNonQuery();
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
                            if (conn.State.Equals("Open")) conn.Close();
                        }

                    }
                }
            }
        }
    }
}