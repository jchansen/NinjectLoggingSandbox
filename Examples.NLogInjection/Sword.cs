using Ninject.Extensions.Logging;
using System;
using System.Collections.Generic;
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
            logger.Info("Chopped {0} clean in half", target);
        }
    }
}
