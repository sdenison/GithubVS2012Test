using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GithubVS2012Test.Web.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Person/ShowAll

        public ActionResult ShowAll()
        {
            var people = Domain.PersonList.GetPeople();
            return View();
        }

    }
}
