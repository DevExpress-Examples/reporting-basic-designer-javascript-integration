using DevExpress.Web.Mvc.Controllers;
using System.Web.Mvc;

namespace DXWebApplication1.Controllers
{
    public class WebDocumentViewerController : WebDocumentViewerApiControllerBase
    {
        //
        // GET: /WebDocumentViewer/

        public override ActionResult Invoke()
        {
            var result = base.Invoke();
            // Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return result;
        }

    }
}