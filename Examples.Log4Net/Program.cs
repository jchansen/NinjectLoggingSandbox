using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Log4Net
{
    class Program
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            // BasicConfigurator replaced with XmlConfigurator.
            var fileInfo = new FileInfo("log4net.config");
            XmlConfigurator.Configure(fileInfo);

            try
            {
                var stream = File.Open("not/a/real/path", FileMode.Open);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
    }
}
