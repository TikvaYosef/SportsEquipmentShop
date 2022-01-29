using SportsEquipmentShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsEquipmentShop.Controllers.API
{
    public class SportsEquipmentController : Controller
    {

        ShoesDataContext datacontext = new ShoesDataContext();

        public ActionResult ShowAllSportsEquipments()
        {
            return View(datacontext.SportsEquipments);
        }
        public ActionResult IdentificationEquipment()
        {
            return View(datacontext.SportsEquipments);

        }
        
        public ActionResult managersTableEquipment()
        {
            return View(datacontext.SportsEquipments);

        }
        public ActionResult OnlyFootball()
        {
            return View(datacontext.SportsEquipments);

        }
        public ActionResult OnlyBasketball()
        {
            return View(datacontext.SportsEquipments);

        }
        public ActionResult SortByPrice()
        {
            List<SportsEquipment> SportE = datacontext.SportsEquipments.OrderBy(item => item.price).ToList();
            return View(SportE);
        }
    }
}
