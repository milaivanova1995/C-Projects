using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PTS_eUniversity
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            InsertSampleData.Insert();
        }
    }
}
