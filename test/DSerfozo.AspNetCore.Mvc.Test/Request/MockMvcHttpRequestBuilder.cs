using System;
using System.Net.Http;

namespace DSerfozo.AspNetCore.Mvc.Test.Request
{
    public sealed class MockMvcHttpRequestBuilder : IRequestBuilder
    {
        private readonly HttpRequestMessage message = new HttpRequestMessage();

        public HttpRequestMessage Build()
        {
            return message;
        }

        public MockMvcHttpRequestBuilder Path(Uri path)
        {
            message.RequestUri = path;
            return this;
        }
    }
}
