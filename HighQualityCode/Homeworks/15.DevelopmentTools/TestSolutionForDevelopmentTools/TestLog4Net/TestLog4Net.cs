using log4net;
using log4net.Config;
using System;
using System.Linq;

namespace TestLog4Net
{
    class Log4NetExample
    {
        private static readonly ILog log =
          LogManager.GetLogger(typeof(Log4NetExample));
        static void Main()
        {
            BasicConfigurator.Configure();
            log.Debug("Debug msg");
            log.Error("Error msg");
        }
    }
}