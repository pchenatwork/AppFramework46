using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Utilities
{
    public class LoggingUtility
    {
        private static ILogger _logger;
        static LoggingUtility()
        {
            Log.Logger = new LoggerConfiguration()
                .CreateLogger();
        }
    }
}
