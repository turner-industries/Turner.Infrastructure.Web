using System.Web.Http;

namespace Turner.Infrastructure.Web.Versioning
{
    public class ApiVersion1RoutePrefixAttribute : RoutePrefixAttribute
    {
        // The way this works with Web Api 2's route constraints ability.  I created a
        // new IHttpRouteConstraint named apiVersionConstraint that exposes one constructor
        // that takes a string for allowed version - that's the v1 in this example.
        // apiVersion is merely the parameter and it's constrainted to v1.

        // See http://www.asp.net/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
        // for more constraint examples.
        private const string RouteBase = "api/{apiVersion:apiVersionConstraint(v1)}";

        private const string PrefixRouteBase = RouteBase + "/";

        public ApiVersion1RoutePrefixAttribute(string routePrefix) :
            base(string.IsNullOrWhiteSpace(routePrefix) ? RouteBase : PrefixRouteBase + routePrefix)
        {
        }
    }
}