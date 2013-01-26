using Ninject.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.NLogInjection
{
    class Sword : IWeapon
    {
        private readonly ILogger logger;

        public Sword(ILogger logger)
        {
            this.logger = logger;
        }

        public void Hit(string target)
        {
            //Console.WriteLine("Chopped {0} clean in half", target);
            try
            {
                var stream = File.Open("not/a/real/path", FileMode.Open);
            }
            catch (Exception ex)
            {
                logger.Info("Chopped {0} clean in half.  They exloded with {1}", target, ex);
            }
        }
    }
}
