using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.NLog
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
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
