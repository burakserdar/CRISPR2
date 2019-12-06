using CRISPR2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRISPR2.Entity;

namespace CRISPR2.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Home()
        {

            return View();
        }
        public ActionResult Order()
        {
            ModelOrder modelorder = new ModelOrder()
            {
                OrganismList = _context.Organism.ToList(),
                ImplementList = _context.ImplementType.ToList(),
                SgrnaList=_context.Sgrna.ToList(),
                OfftargetList=_context.OffTarget.ToList()
            };

            return View(modelorder);
        }

        public ActionResult Deneme()
        {

            return View();
        }
    }
}