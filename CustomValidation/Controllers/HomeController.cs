using System.Web.Mvc;
using CustomValidation.Enums;

namespace CustomValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            this.AddValidationMessage("Congratulations", "You made it all the way here!", ValidationType.Success);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            this.AddValidationMessage("Application Error", "There was a problem saving changes. Please try your request again.", ValidationType.Error);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}