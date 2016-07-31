using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace DSerfozo.AspNetCore.Mvc.Test
{
    public sealed class MockMvc<TStartup> where TStartup : class
    {
        private sealed class ResultAction : IResultActions
        {
            private readonly HttpResponseMessage message;

            public ResultAction(HttpResponseMessage message)
            {
                this.message = message;
            }

            public IResultActions AndExpect(ResultMatcher matcher)
            {
                matcher(message);
                return this;
            }
        }

        private readonly TestServer testServer;

        public MockMvc()
        {
            testServer = new TestServer(new WebHostBuilder().UseStartup<TStartup>());
        }

        public IResultActions Perform(IRequestBuilder requestBuilder)
        {
            var result = testServer.CreateClient().SendAsync(requestBuilder.Build()).Result;
            return new ResultAction(result);
        }
    }
}
