using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGEducation.Core
{
    public class SqlTableManager
    {
        const string DEFAULT_CONNECT = "Server=localhost;Port=5432;Database=clients;User Id=postgres;Password=admin;";

        public SqlTableManager() : this(DEFAULT_CONNECT) { }

        public SqlTableManager(string connectString)
        {

        }
    }
}
