﻿using Framework.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.JobServices
{
    public class JobEnum : EnumBase<JobEnum>
    {

        #region Enumeration Elements
        /* ==========================================================================
         * Name: 
         * Description:  TypeName for reflection
         * ==========================================================================*/
        public static readonly JobEnum Job1 = new JobEnum(1, nameof(Job1), typeof(Job1).FullName);
        public static readonly JobEnum Job2 = new JobEnum(1, nameof(Job2), typeof(Job2).FullName);
        #endregion

        #region Constructors
        private JobEnum(int id, string name, string description)
            : base(id, name, description)
        {
        }
        #endregion
    }
}
