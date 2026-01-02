using System;

namespace NLog.Targets.Http
{
    public class TooManyRequestsException : Exception
    {
        public TooManyRequestsException()
            : base("The server returned a 429 Too Many Requests response.")
        {
        }
    }
}
