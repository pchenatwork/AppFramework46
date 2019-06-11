
using Framework.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.JobServices
{
    public sealed class JobFactory : FactoryBase<JobFactory>
    {
        /// Job (JobEnum) need to be defined in the context
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        public IJob GetJob(JobEnum job)
        {
            IJob _job = null;
            object[] args = { "ConstructorParameter1" };  // For parametered Constructor 

            try
            {
                // create IJob incident using reflection (parameters)
                _job = Activator.CreateInstance(Type.GetType(job.Description),
                    BindingFlags.NonPublic | BindingFlags.Instance, null,
                    args, null) as IJob;

                /* parameterless
                  _job = (IJob)Activator.CreateInstance(Type.GetType(job.Description));
                    */
            }
            catch (TargetInvocationException e)
            {
                throw new SystemException(e.InnerException.Message, e.InnerException);
            }

            return _job;
        }

    }
}
