using PrimeLogic;
using PrimeNumbers.Models;
using System.Web.Mvc;

namespace PrimeNumbers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new PrimeModel());
        }

        [HttpPost]
        public ActionResult Index(PrimeModel model)
        {
            model.Message = PrimeNumbersLogic.GetPrimeNumbers(model.Number);

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}