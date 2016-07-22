using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Mail;
using System.Threading.Tasks;

using log4net;
using log4net.Config;

namespace Logging {
    class Program {
        private static readonly log4net.ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args) {
            XmlConfigurator.Configure();
            Logger.Info("Program started");

            try {
                //exception simulation
                string test = null;
                test = test.Trim();
            } catch (Exception ex) {
                Logger.Error("Unexpected Error", ex);
            }

            Logger.Info("Program finished");
            LogManager.Shutdown();
        }
    }
}
