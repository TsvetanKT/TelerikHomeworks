namespace Log4NetTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using log4net;
    using log4net.Config;

    public class Program
    {
        /// <summary>
        /// Creating a logger.
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// The Main method.
        /// </summary>
        public static void Main()
        {
            BasicConfigurator.Configure();
            Log.Info("Info here");
            Log.Warn("Warning here");
            Log.Error("Error here");
        }
    }
}
