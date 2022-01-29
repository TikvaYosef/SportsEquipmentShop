using SportsEquipmentShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsEquipmentShop.Controllers.API
{
    public class ClothingController : Controller
    {
        ShoesDataContext datacontext = new ShoesDataContext();

        public ActionResult ShowAllTshirt()
        {
            return View(datacontext.Clothings);
        }


        public ActionResult managersTableShirts()
        {
            return View(datacontext.Clothings);
        }

        public ActionResult IdentificationWindow()
        {
            return View();
        }
        public ActionResult LongTshirt()
        {

            return View(datacontext.Clothings);
        }

        public ActionResult DryFitShirts()
        {

            return View(datacontext.Clothings);
        }
        public ActionResult SortByPrice()
        {
            List<Clothing> clothings = datacontext.Clothings.OrderBy(item => item.price).ToList();
            return View(clothings);
        }

        public ActionResult TShirts()
        {
            return View(datacontext.Clothings);

        }

        public ActionResult ShowAllPants()
        {
            return View(datacontext.Clothings);
        }

        public ActionResult managersTablePants()
        {
            return View(datacontext.Clothings);
        }
        public ActionResult IdentificationPants()
        {
            return View();
        }
        public ActionResult LongPants()
        {
            return View(datacontext.Clothings);
        }
        public ActionResult ShortPants()
        {
            return View(datacontext.Clothings);

        }
        public ActionResult DryFitPants()
        {
            return View(datacontext.Clothings);

        }
        public ActionResult SortByPricePants()
        {
            List<Clothing> clothes = datacontext.Clothings.OrderBy(item => item.price).ToList();
            return View(clothes);

        }
        public ActionResult AllWomen()
        { 
            return View(datacontext.Clothings);

        }
        public ActionResult Allmen()
        {
            return View(datacontext.Clothings);

        }

    }
}
