using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.vinicius.projeto.analise.Model
{
    public abstract class RegisterBase
    {
        //protected string connectionString = "server=127.0.0.1;uid=root;pwd=admin;database=analise";
        protected string connectionString = @"data source=VINICIUS-PC\SQLEXPRESS;Initial Catalog=Analise; Integrated Security = SSPI";
        //"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)" +
        //"(HOST=MYHOST)(PORT=1527))(CONNECT_DATA=(SID=MYSERVICE)));" +
        //"User Id=MYUSER;Password=MYPASS;";
        public  string provider = @"System.Data.SqlClient"; // sqlserver
       // public  string provider = @"MySql.Data.MySqlClient";  //mysql
        public DbConnection connection = null;
        public DbProviderFactory factory;

        public abstract string Insert(Object obj);
        public abstract string Edit(Object obj);
        public abstract string Delete(Object obj);
        public abstract List<Dictionary<string, object>> SelectAll();

    }
}
