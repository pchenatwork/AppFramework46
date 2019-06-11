using Framework.Core.Common;
using Framework.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Framework.Core.DataAccess
{
    /// <summary>
    /// Wrapper to IDbConnection
    /// </summary>
    public interface IDataSource
    {
        #region Properties
        string Name { get; }
        IDbConnection DbConnection { get;}
        #endregion
    }
}
