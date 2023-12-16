using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPK_PDPTA.Class
{
    abstract class SQLConn
    {
        public abstract int ExecNonQuery(String query);
        public abstract DataTable ExecQuery(String query);
    }
}
