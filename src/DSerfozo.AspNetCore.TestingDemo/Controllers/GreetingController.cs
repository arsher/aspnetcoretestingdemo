using Microsoft.AspNetCore.Mvc;
using DSerfozo.AspNetCore.TestingDemoLib;

namespace ConsoleApp.Controllers
{
    [Route("api/[controller]")]
    public class GreetingController
    {
        private Class1 class1 = new Class1();

        [HttpGet]
        public string Get()
        {
            return class1.GetString();
        }
    }
}
