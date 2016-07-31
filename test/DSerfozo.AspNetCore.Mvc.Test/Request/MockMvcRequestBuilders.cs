using System;

namespace DSerfozo.AspNetCore.Mvc.Test.Request
{
    public static class MockMvcRequestBuilders
    {
        public static IRequestBuilder Get(string url)
        {
            return new MockMvcHttpRequestBuilder()
                .Path(new Uri(url, UriKind.RelativeOrAbsolute));
        }
    }
}
