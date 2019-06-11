using Framework.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.DataAccess
{
    internal class DbConnectionEnum : EnumBase<DbConnectionEnum>
    {
        #region Enumeration Elements
        public static readonly DbConnectionEnum SqlClient = new DbConnectionEnum(1, nameof(SqlClient), typeof(SqlConnection).AssemblyQualifiedName);
        public static readonly DbConnectionEnum OleDb = new DbConnectionEnum(1, nameof(OleDb), typeof(OleDbConnection).AssemblyQualifiedName); 
        #endregion

        #region Constructors
        private DbConnectionEnum(int id, string name, string description)
            : base(id, name, description)
        {
        }
        #endregion
    }
}