using System.Net;
using Xunit;

namespace DSerfozo.AspNetCore.Mvc.Test.Result
{
    public sealed class StatusResultMatchers
    {
        public ResultMatcher IsOk()
        {
            return _ => Assert.Equal(HttpStatusCode.OK, _.StatusCode);
        }

        public ResultMatcher IsNotFound()
        {
            return _ => Assert.Equal(HttpStatusCode.NotFound, _.StatusCode);
        }
    }
}
