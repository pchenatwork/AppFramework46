using Framework.Core.Common;
using Framework.Core.DataAccess;
using Framework.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.DataAccess
{
    public class DaoFactory<T> : FactoryBase<DaoFactory<T>>
        where T : IValueObject
    {
        /// Job (JobEnum) need to be defined in the context
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        public IRepository<T> GetDao(string DaoTypeName, DataSourceSettingObject dataSource)
        {
            IRepository<T> _dao = null;
            object[] args = { dataSource };  // For parametered Constructor 

            try
            {
                Type t = Type.GetType(DaoTypeName);
                _dao  = (IRepository<T>)Activator.CreateInstance(t, args);
                //_dao = Activator.CreateInstance(t,
                //    BindingFlags.NonPublic | BindingFlags.Instance, null,
                //    args, null) as IDataAccessObject<T>;

                /* parameterless
                  _job = (IJob)Activator.CreateInstance(Type.GetType(job.Description));
                    */
            }
            catch (TargetInvocationException e)
            {
                throw new SystemException(e.InnerException.Message, e.InnerException);
            }

            return _dao;
        }
    }
}

