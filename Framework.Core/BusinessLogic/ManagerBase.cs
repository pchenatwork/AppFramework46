using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using Framework.Core.Common;
using Framework.Core.DataAccess;
using Framework.Core.ValueObjects;

namespace Framework.Core.BusinessLogic
{
   //// public abstract class ManagerBase<T> : FactoryBase<ManagerBase<T>>, IManager<T> where T : IValueObject, new()
    public abstract class ManagerBase<TManager, TValueObject> : FactoryBase<TManager>, IManager<TValueObject>
        where TManager : ManagerBase<TManager, TValueObject>
        where TValueObject : IValueObject, new()
    {
        #region Private Variables
        protected DataSourceSettingObject _DataSource;
        protected string _DaoTypeName;
        private IRepository<TValueObject> _Dao;
        //protected Lazy<IRepository<T>> _Dao;
        #endregion

        #region Constructors
        static ManagerBase()
        {
           
        }
        #endregion

        public IRepository<TValueObject> Dao
        {
            get
            {
                if (_Dao == null)
                {
                    _Dao = DaoFactory<TValueObject>.Instance.GetDao(_DaoTypeName, _DataSource);
                }
                return _Dao;
            }
        }

        public TValueObject CreateObject()
        {
            return new TValueObject();
        }
        public int Create(TValueObject entity)
        {
            return this.Dao.Create(entity);
        }

        public bool Update(TValueObject entity)
        {
            return this.Dao.Update(entity);
        }

        public bool Delete(int Id)
        {
            return this.Dao.Delete(Id);
        }

        public IEnumerable<TValueObject> FindByCriteria(string finderType, object[] criteria)
        {
            return this.Dao.FindByCriteria(finderType, criteria);
        }

        public TValueObject Get(int id)
        {
            return this.Dao.Get(id);
        }

        public IEnumerable<TValueObject> GetAll()
        {
            return this.Dao.GetAll();
        }

        public object InvokeByMethodName(string methodName, object[] parameters)
        {
            return this.Dao.InvokeByMethodName(methodName, parameters);
        }
    }
}
