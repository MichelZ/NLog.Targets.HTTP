using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using NLog.Common;

namespace UnitTests_ConfigurationAndLayout
{
    [Ignore]
    [TestClass]
    public class SplunkTests
    {
        [TestInitialize]
        public void TestSetUp()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        [TestCleanup]
        public void TestShutdown()
        {
            LogManager.Flush(TimeSpan.FromHours(1));
            LogManager.Shutdown();
        }

        private ILogger _logger;
        private readonly Guid _guid = Guid.NewGuid();

        [TestMethod]
        public void LoadTest()
        {
            Parallel.For(0, 1000000, i => _logger.Info($"{_guid} {i} at {DateTime.Now}"));
            InternalLogger.Debug(_guid.ToString());
        }

        [TestMethod]
        public void LogTests()
        {
            for (var i = 0; i < 5; i++) _logger.Warn($"{i} !!! {DateTime.Now} - Confirm visually ");
        }
    }
}