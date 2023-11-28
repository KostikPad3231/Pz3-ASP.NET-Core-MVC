using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication2.Helpers;

public static class LastImagesList
{
    public static HtmlString CreateImagesList(this IHtmlHelper html, List<string> images)
    {
        string result = "<ul class=\"list-group list-group-horizontal\">";
        foreach (string image in images)
        {
            result = $"{result}<li class=\"list-group-item\"><img src=\"data:image/png;base64,{image}\"></li>";
        }

        result = $"{result}</ul>";
        return new HtmlString(result);
    }
}