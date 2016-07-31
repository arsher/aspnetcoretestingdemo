using ConsoleApp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;
using DSerfozo.AspNetCore.Mvc.Test;
using static DSerfozo.AspNetCore.Mvc.Test.MockMvcRequestBuilders;
using static DSerfozo.AspNetCore.Mvc.Test.MockMvcResultMatchers;

namespace DSerfozo.AspNetCore.TestingDemoLib.Integration
{
    public class GreetingControllerTest
    {
        private readonly TestServer testServer;

        public GreetingControllerTest()
        {
            testServer = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }

        [Fact]
        public void Api_Returns()
        {
            var mockMvc = new MockMvc<Startup>();
            mockMvc.Perform(Get("/api/greeting"))
                .AndExpect(Status().IsOk())
                .AndExpect(Content().String("str"));
        }
    }
}
