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
        public string Index()
        {
            return "Here will be the list of hotels.";
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

        public class Hotel
        {
            public Int32 Id { get; set; }
            public string Name { get; set; }
            public int Stars { get; set; }
            public string Description { get; set; }
            public string City { get; set; }
            public string County { get; set; }
        }

        public class HotelList
        {
            private List<Hotel> hotels;
            public List<Hotel> Hotels { get { return hotels; } }

            public HotelList()
            {
                hotels = new List<Hotel>();
            }
        }
	}
}