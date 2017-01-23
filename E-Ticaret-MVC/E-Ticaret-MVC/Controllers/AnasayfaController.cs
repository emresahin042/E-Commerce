using E_Ticaret_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret_MVC.Controllers
{
    public class AnasayfaController : Controller
    {

        EShopperEntities veri = new EShopperEntities();
        // GET: Anasayfa
        public ActionResult Index()
        {

            var data = veri.v_VitrinUrunler.OrderByDescending(i => i.VitrineCikisTarih).Take(6).ToList();
            return View(data);
        }
    }
}