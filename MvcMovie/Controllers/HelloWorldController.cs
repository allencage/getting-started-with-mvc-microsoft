using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View(); 
        }

        public string Welcome(string name, int id)
        {
            //Note - use HttpUtility to encode the items you receive as parameters because you could receive malicious javascript
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = id;

            return View();
        }

    }
}