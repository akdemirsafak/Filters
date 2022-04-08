namespace AuthorizationFilters.Filters
{
    public class MyCustomAuthorizationFilter : FilterAttribute, IAuthorizationFilter
    {
        public void AuthorizationControl(AuthorizationContext filterContext)
        {

        }
    }
}