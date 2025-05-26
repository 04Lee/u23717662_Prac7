using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23717662_Prac7.Models;

namespace u23717662_Prac7.Controllers
{
    public class PublicationController : Controller
    {
        
        public ActionResult Index()
        {
            FakeRepository repository = new FakeRepository();
            return View(repository.GetPublications());
        }
    }
}