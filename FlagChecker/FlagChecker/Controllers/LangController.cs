using System.Globalization;
using System.Web.Mvc;

namespace FlagChecker.Controllers
{
    public class LangController : Controller
    {
        public ActionResult SwitchLanguage()
        {
            if (CultureInfo.CurrentCulture.Name != "pl-PL")
            {
                this.Session["Culture"] = new CultureInfo("pl-PL");
                return Redirect(Request.UrlReferrer.PathAndQuery);
            }
            this.Session["Culture"] = new CultureInfo("en-US");
            return Redirect(Request.UrlReferrer.PathAndQuery);
        }
    }
}