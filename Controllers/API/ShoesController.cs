using SportsEquipmentShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsEquipmentShop.Controllers.API
{
    public class ShoesController : Controller
    {
        ShoesDataContext datacontext = new ShoesDataContext();
        // GET: Shoes
        public ActionResult ShowShoes()
        {


            return View(datacontext.Shoes);

        }

        public ActionResult managersTable()
        {

            return View(datacontext.Shoes);
        }

        public ActionResult IdentificationWindow()
        {

            return View();
        }
        public ActionResult OnSale()
        {


            return View(datacontext.Shoes);

        }
    }
}
