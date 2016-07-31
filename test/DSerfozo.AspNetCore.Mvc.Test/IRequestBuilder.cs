using System.Net.Http;

namespace DSerfozo.AspNetCore.Mvc.Test
{
    public interface IRequestBuilder
    {
        HttpRequestMessage Build();
    }
}
