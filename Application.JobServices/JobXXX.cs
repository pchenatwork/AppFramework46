using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.JobServices
{
    public sealed class Job1 : JobBase
    {
        #region Constructor
        internal Job1(string s) : base(s) { }
        #endregion
        protected override void Run()
        {
            throw new NotImplementedException();
        }
    }

    public sealed class Job2 : JobBase
    {
        #region Constructor
        internal Job2(string s) : base(s) { }
        #endregion
        protected override void Run()
        {
            throw new NotImplementedException();
        }
    }
}
