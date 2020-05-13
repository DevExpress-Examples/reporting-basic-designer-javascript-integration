using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXWebApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Designer() {
            Models.ReportsModel model = new Models.ReportsModel();
            return View(model);
        }

        public ActionResult Viewer() {
            return View();
        }
    }
}