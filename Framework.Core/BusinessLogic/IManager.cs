using Framework.Core.Common;
using Framework.Core.DataAccess;
using Framework.Core.ValueObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Framework.Core.BusinessLogic
{
    public interface IManager<T> : IRepository<T> where T : IValueObject
    {
        /* ---------------------------
         * Implemented a Facade Pattern
         * 1. Get DbConnection
         * 2. Inject the DbConnection to Dao and Call Dao
         * --------------------------- */
        IRepository<T> Dao { get; }
        #region Manager
        /// <summary>
        /// DataSource related to this Manager.
        /// </summary>
        ///IDataSource DataSource { get; }

        /// <summary>
        /// Cached DataAccessObject.
        /// </summary>
        // IRepository<T> Dao { get; }

        /// <summary>
        /// Force to tell the Dao Class Name. This means all implementatins should have the same class name.
        /// </summary>
        //// string DaoClassName { get; }

        /// <summary>
        /// Create a value object in memory.
        /// </summary>
        T CreateObject();
        #endregion

    }
}
