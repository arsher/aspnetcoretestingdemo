using System.Net.Http;
using Xunit;

namespace DSerfozo.AspNetCore.Mvc.Test.Result
{
    public sealed class ContentResultMatchers
    {
        public ResultMatcher ContentType(string contentType)
        {
            return _ => Assert.Equal(contentType, _.Content.Headers.ContentType.MediaType);
        }

        public ResultMatcher String(string content)
        {
            return _ => Assert.Equal(content, _.Content.ReadAsStringAsync().Result);
        }
    }
}
