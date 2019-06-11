﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;
using System.Text;
using System.Xml;
using Framework.Core.Common;
using Framework.Core.Utilities;
using Framework.Core.ValueObjects;

namespace Framework.Core.DataAccess
{

    /// <summary>
    /// Data Access Object
    /// </summary>
    public abstract class DaoBase<T> : IRepository<T> where T: IValueObject
    {
        /* ==========================================================================
         * PCHEN  201903: Created
         * Abstract Job that ALL Job needs to be based on
         * ==========================================================================*/
        #region Proteccted variables
        protected Lazy<IDataSource> _dataSource; // = new Lazy<IDbConnection>(() => DbConnectionFactory.Instance.GetConnection(_dataSourceName));
        #endregion

        #region Constructors
        /// <summary>
        /// Inject DbConnection to DAO
        /// </summary>
        /// <param name=""></param>
        protected DaoBase(DataSourceSettingObject dataSource)
        {
            _dataSource = new Lazy<IDataSource>(() => new DataSource(dataSource));
        }

        static DaoBase()
        {
            //_logger = LoggingUtility.GetLogger(typeof(JobBase).FullName);
        }
        #endregion

        public abstract T Get(int id);
        public abstract int Create(T newObject);
        public abstract bool Update(T newObject);
        public abstract bool Delete(int Id);
        public abstract IEnumerable<T> GetAll();
        public abstract IEnumerable<T> FindByCriteria(string finderType, object[] criteria);
        public virtual object InvokeByMethodName(string methodName, object[] parameters)
        {
            Type type = this.GetType();
            return type.InvokeMember(methodName, BindingFlags.DeclaredOnly |
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                null, this, parameters);
        }
        protected T Deserialize(XmlReader reader)
        {
            object result = XMLUtility.Deserialize<T>(reader);
            return (T)result;
        }
        protected IEnumerable<T> DeserializeCollection(XmlReader reader)
        {
            object result = XMLUtility.Deserialize<ValueObjectCollection<T>>(reader);
            return (IEnumerable<T>)result;
        }
    }
}