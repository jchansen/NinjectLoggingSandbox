using Ninject.Extensions.Logging;
using System;
using System.Collections.Generic;
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
            //Console.WriteLine("Pierced {0}'s armor", target);
            logger.Info("Pierced {0}'s armor", target);
        }
    }
}
