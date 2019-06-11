using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.JobServices
{
    public interface IJob
    {
        JobStatusEnum Execute();
    }
    public abstract class JobBase : IJob
    {
        /* ==========================================================================
         * PCHEN  201903: Created
         * Abstract Job that ALL Job needs to be based on
         * ==========================================================================*/
        #region Proteccted variables
        protected int _cntErr = 0;
        protected int _cntFatal = 0;
        protected string _jobName = string.Empty;
        protected string _extra = string.Empty;
        #endregion

        #region constructor
        protected JobBase(string job)
        {
            _jobName = job;
        }
        static JobBase()
        {
            //_logger = LoggingUtility.GetLogger(typeof(JobBase).FullName);
        }
        #endregion

        #region Property
        /// <summary>
        /// Parameters in string format for the job(optional).
        /// Each job has to define its own demiliter for multiple parameters(if any)
        /// </summary>
        public string Params
        {
            set { _extra = value; }
        }
        #endregion

        #region Methods
        public JobStatusEnum Execute()
        {
            PreRun();
            Run();
            PostRun();
            return JobStatusEnum.Completed;
        }
        protected abstract void Run();
        /// <summary>
        /// Create the ScheduleHistory record
        /// </summary>
        protected virtual void PreRun()
        {
        }
        /// <summary>
        /// Update ScheduleHistory record with Finishs tatus
        /// </summary>
        protected virtual void PostRun()
        {
        }
        #endregion
    }
}

