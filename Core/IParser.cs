using AngleSharp.Html.Dom;

namespace HabrHtmlParser.Core
{
    interface IParser<T> where T: class
    {
        T Parse(IHtmlDocument document);
    }
}
