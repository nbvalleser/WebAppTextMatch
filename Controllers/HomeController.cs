using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebTextMatch.Models;
using MyWebTextMatch.Repository;

namespace MyWebTextMatch.Controllers
{
    public class HomeController : Controller
    {
        TextMatchModule _MatchRequest = new TextMatchModule();
        public ActionResult Index()
        {
            //GetMatchText("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Polly");
            return View();
        }

        [HttpPost]
        public JsonResult MatchText(string MainText, string SubText)
        {
            IList<Matchresult> getResults = _MatchRequest.TextTrigger(MainText, SubText);
            return Json(getResults, JsonRequestBehavior.AllowGet);
        }
    }
}