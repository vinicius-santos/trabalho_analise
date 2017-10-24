using IBM.Data.DB2;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.DB
{
    public class FactoryDB
    {
        static public DbConnection GetDBInstance(string type, string connectionString)
        {
            if (type.Equals("Oracle"))
            {
                return new OracleConnection(connectionString);
            }
            else if (type.Equals("DB2"))
            {
                return new DB2Connection(connectionString);
            }
            else if (type.Equals("SqlServer"))
            {
                return new SqlConnection(connectionString);
            }
            return null;
        }
    }
}
