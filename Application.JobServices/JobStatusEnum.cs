using Framework.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.JobServices
{
    public class JobStatusEnum : EnumBase<JobStatusEnum>
    {
        #region Enumeration Elements
        public static readonly JobStatusEnum Failed = new JobStatusEnum(-1, nameof(Failed), "Failed");
        public static readonly JobStatusEnum Started = new JobStatusEnum(0, nameof(Started), "Started");
        public static readonly JobStatusEnum Completed = new JobStatusEnum(1, nameof(Completed), "Completed");
        public static readonly JobStatusEnum CompletedWithError = new JobStatusEnum(2, nameof(CompletedWithError), "Completed with errors");

        /// Conversion Operator     
        /// It has to be here if we need (int)-1 => JobStatus.Failed conversion.
        /// This can not put into the generic EnumBase
        public static implicit operator JobStatusEnum(int id)
        {
            return GetById(id);
        }
        #endregion

        #region Constructors
        private JobStatusEnum(int id, string name, string description)
            : base(id, name, description)
        {
        }
        #endregion

    }
}