using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.DataAccess
{
    public struct DataSourceSettingObject
    {
        public string Name;
        public string DbConnectionTypeName;
        public string ConnectionString;
        public DataSourceSettingObject(string DataSourceName, string DbConnectionTypeName, string ConnectionString)
        {
            this.Name = DataSourceName; this.DbConnectionTypeName = DbConnectionTypeName; this.ConnectionString = ConnectionString;
        }
    }

    public class DataSource : IDataSource
    {
        private Lazy<IDbConnection> _conn;
        private DataSourceSettingObject _dataSouceSetting;

        #region constructor
        public DataSource(DataSourceSettingObject datasource)
        {
            _dataSouceSetting = datasource;
            _conn = new Lazy<IDbConnection>(() =>
            {
                //////return (IDbConnection)((ICloneable)DbConnectionFactory.Instance.GetConnection(_dataSouceSetting.DbConnectionTypeName)).Clone();
                return DbConnectionFactory.Instance.GetConnection(_dataSouceSetting.DbConnectionTypeName);
            });
        }
        #endregion

        #region Properties
        public string Name { get { return _dataSouceSetting.Name; } } 
        public IDbConnection DbConnection
        {
            ////***** Failed thread testing **************
            get
            {
                IDbConnection x = _conn.Value;
                if (x.ConnectionString.Length == 0)
                {
                    x.ConnectionString = _dataSouceSetting.ConnectionString;
                }
                return x;
            }
        }
        #endregion

    }
}
