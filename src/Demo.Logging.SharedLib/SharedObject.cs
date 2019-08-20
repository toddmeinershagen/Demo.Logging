using Common.Logging;
using Common.Logging.Simple;

namespace Demo.Logging.SharedLib
{
    public class SharedObject
    {
        private static readonly ILog Logger = LogManager.GetLogger<SharedObject>();

        public void Execute()
        {
            Logger.Info("This is a test message.");
        }
    }
}
