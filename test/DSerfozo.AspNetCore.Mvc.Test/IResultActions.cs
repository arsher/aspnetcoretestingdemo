namespace DSerfozo.AspNetCore.Mvc.Test
{
    public interface IResultActions
    {
        IResultActions AndExpect(ResultMatcher matcher);
    }
}
