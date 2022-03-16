using Microsoft.AspNetCore.Mvc.Filters;

namespace Mvc1.ActionFilters;

public class DenemeActionFilter:IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine();
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine();
    }
}