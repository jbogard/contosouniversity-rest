namespace ContosoUniversity.Helpers
{
    using System;
    using System.Linq.Expressions;
    using System.Web.Http;
    using System.Web.Http.Routing;
    using Ploeh.Hyprlinkr;

    public static class UrlHelperExtensions
    {
        public static Uri Link<T, TResult>(this UrlHelper helper, Expression<Func<T, TResult>> expression)
            where T : ApiController
        {
            var linker = new RouteLinker(helper.Request);

            return linker.GetUri(expression);
        }

        public static Uri Link<T>(this UrlHelper helper, Expression<Action<T>> expression)
            where T : ApiController
        {
            var linker = new RouteLinker(helper.Request);

            return linker.GetUri(expression);
        }
    }
}