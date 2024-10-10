using System.Net;
using System.Net.Http;
using NUnit.Framework;

namespace UnitTests_Core
{
    public class HttpResponseCodesTests
    {
        [Test]
        public void Test429()
        {
            var httpResponseMessage = new HttpResponseMessage { StatusCode = HttpStatusCode.TooManyRequests };
            Assert.That(httpResponseMessage.StatusCode == HttpStatusCode.TooManyRequests);
            Assert.That((int)httpResponseMessage.StatusCode == 429);
        }
    }
}