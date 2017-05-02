using RocketryMath.Interfaces;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RocketryMath
{
    public class MvcApplication : System.Web.HttpApplication
    {
        #region Protected Methods

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ModelBinders.Binders.Add(typeof(IFormula), new IFormulaBinder());
        }

        #endregion Protected Methods
    }
}