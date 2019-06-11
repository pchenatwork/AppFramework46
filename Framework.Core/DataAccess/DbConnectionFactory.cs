using Framework.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Text;
using System.Reflection;
using Framework.Core.Common;

namespace Framework.Core.DataAccess
{
    public class DbConnectionFactory : FactoryBase<DbConnectionFactory>
    {

        /// <summary>
        /// For now, hardcoded connection string, "dataSourceName" has not been utilized yet
        /// </summary>
        /// <param name="connectionTypeName"></param>
        /// <returns></returns>
        public IDbConnection GetConnection(string connectionTypeName)
        {
           // string connStr = "server=scazvassqldev01.nycsca.org; user id=aec; password=brApHa7B; database=NYCSCA_VAS;";  // SCAZVASSQLDEV01          SCAVASSQLTEST01
           // DbConnectionEnum _typeEnum = DbConnectionEnum.GetByName(connectionTypeName);

            IDbConnection conn = null;
            try
            {
                conn = (IDbConnection)Activator.CreateInstance(Type.GetType(DbConnectionEnum.GetByName(connectionTypeName).Description));
                //conn.ConnectionString = connStr;
            }
            catch (TargetInvocationException e)
            {
                throw new SystemException(e.InnerException.Message, e.InnerException);
            }
            return conn;
        }
    }
}
