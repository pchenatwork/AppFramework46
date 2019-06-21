using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.DataAccess
{
    /// <summary>
    /// Struct for Data Source Parameters
    /// </summary>
    public struct DataSourceParams
    {
        public string Name;
        public string DbConnectionType;
        public string ConnectionString;
        public DataSourceParams(string DataSourceName, string DbConnectionType, string ConnectionString)
        {
            this.Name = DataSourceName; this.DbConnectionType = DbConnectionType; this.ConnectionString = ConnectionString;
        }
    }

    public class DataSource : IDataSource
    {
        private Lazy<IDbConnection> _conn;
        private DataSourceParams _dsParams;

        #region constructor
        public DataSource(DataSourceParams dataSourceParams)
        {
            _dsParams = dataSourceParams;
            _conn = new Lazy<IDbConnection>(() =>
            {
                //////return (IDbConnection)((ICloneable)DbConnectionFactory.Instance.GetConnection(_dataSouceSetting.DbConnectionTypeName)).Clone();
                return DbConnectionFactory.Instance.GetConnection(_dsParams.DbConnectionType);
            });
        }
        #endregion

        #region Properties
        public string Name { get { return _dsParams.Name; } } 
        public IDbConnection DbConnection
        {
            ////***** Failed thread testing **************
            get
            {
                IDbConnection x = _conn.Value;
                if (x.ConnectionString.Length == 0)
                {
                    x.ConnectionString = _dsParams.ConnectionString;
                }
                return x;
            }
        }
        #endregion

    }
}
