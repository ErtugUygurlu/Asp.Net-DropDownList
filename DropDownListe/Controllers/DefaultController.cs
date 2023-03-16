using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDownListe.Models.ENTITY;

namespace DropDownListe.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        dropdownEntities db = new dropdownEntities();
        public ActionResult Index()
        {
            List<SelectListItem> degerler = (from i in db.TBLSEHIR.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.SEHIR,
                                                 Value = i.ID.ToString(),
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
    }
}