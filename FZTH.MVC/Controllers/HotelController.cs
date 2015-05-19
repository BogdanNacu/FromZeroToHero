using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FZTH.MVC.Data;

namespace FZTH.MVC.Controllers
{
    public class HotelController : Controller
    {
        //
        // GET: /Hotel/
        [HttpGet]
        public ActionResult Index()
        {
            return View("HotelListView", Data.Data.Hotels);
        }

        /*[HttpGet]
        public ActionResult Detail(Int32 id)
        {
            var hotel = Data.Hotels.FirstOrDefault(x => x.Id == id);
            if (hotel != null)
            {
                return Json(hotel, JsonRequestBehavior.AllowGet);
            }
            return HttpNotFound();
        }*/

	}
}