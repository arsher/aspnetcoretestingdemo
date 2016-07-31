using Xunit;
using DSerfozo.AspNetCore.TestingDemoLib;

namespace DSerfozo.AspNetCore.TestingDemoLib.Test
{
    public class Class1Test
    {
        [Fact]
        public void Returns_Str()
        {
            Assert.Equal("str", new Class1().GetString());            
        }
    }
}
