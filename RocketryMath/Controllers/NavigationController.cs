using System.Web.Mvc;

namespace RocketryMath.Controllers
{
    public class NavigationController : Controller
    {
        #region Public Methods

        // GET: Navigation
        public ActionResult Menu()
        {
            return View();
        }

        #endregion Public Methods
    }
}