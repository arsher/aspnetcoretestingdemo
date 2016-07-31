namespace DSerfozo.AspNetCore.Mvc.Test.Result
{
    public static class MockMvcResultMatchers
    {
        public static StatusResultMatchers Status()
        {
            return new StatusResultMatchers();
        }

        public static ContentResultMatchers Content()
        {
            return new ContentResultMatchers();
        }
    }
}
