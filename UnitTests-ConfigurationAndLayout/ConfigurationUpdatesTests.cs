// Licensed Materials - Property of Quaterne
// 
// (C) Copyright Quaterne, LLC - 2019

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using NLog.Targets.Http;

// ReSharper disable NotAccessedField.Local

namespace UnitTests_ConfigurationAndLayout
{
    [TestClass]
    public class ConfigurationUpdatesTests
    {
        [TestInitialize]
        public void SetUp()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        private Logger _logger;

        [TestMethod]
        public void HeadersAreNotEmpty()
        {
            Assert.IsGreaterThan(0, LogManager.Configuration.AllTargets.Count);
            var splunkTarget = (HTTP)LogManager.Configuration.FindTargetByName("splunk");
            Assert.AreEqual(2, splunkTarget.Headers.Count);
        }
    }
}