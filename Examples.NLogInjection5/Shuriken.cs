using Ninject.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.NLogInjection
{
    class Shuriken : IWeapon
    {
        private readonly ILogger logger;

        public Shuriken(ILogger logger)
        {
            this.logger = logger;
        }

        public void Hit(string target)
        {
            try
            {
                var stream = File.Open("not/a/real/path", FileMode.Open);
            }
            catch (Exception ex)
            {
                logger.Info("Pierced {0}'s armor.  They oozed {1}", target, ex);
            }
        }
    }
}
