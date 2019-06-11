using Framework.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Framework.Core.DataAccess
{
    public interface IDataAccessObject<T> where T: IValueObject
    {
        int Create(T newObject);
        bool Update(T newObject);
        bool Delete(int Id);
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> FindByCriteria(string finderType, object[] criteria);

        /// <summary>
        /// This is a generic function to invoke any function of a DAO.
        /// Note: IDataSource must be the first parameter of  parameters array.
        /// </summary>
        /// <param name="methodName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        object InvokeByMethodName(string methodName, object[] parameters);
    }
}
