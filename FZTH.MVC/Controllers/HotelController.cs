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

        [HttpGet]
        public ActionResult Delete(Int32 id)
        {
            for (int i = 0; i <= Data.Data.Hotels.Count; i++)
                if (Data.Data.Hotels[i].Id == id)
                    return View("Delete", Data.Data.Hotels[i]);
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Hotel h = null;
            for (int i = 0; i < Data.Data.Hotels.Count; i++)
                if (Data.Data.Hotels[i].Id == id)
                    h = Data.Data.Hotels[i];
            Data.Data.Hotels.Remove(h);
            return RedirectToAction("Index");
        }
        
        
        public ActionResult Create()
        {
            return View("Create");
        }

        /*
        [HttpPost]
        public ActionResult Create(Hotel h)
        {
            int idmax = 0;
            for(int i = 0; i< Data.Data.Hotels.Count; i++)
                if(Data.Data.Hotels[i].Id > idmax)
                    idmax = i;
            h.Id = idmax;
            Data.Data.Hotels.Add(h);

            return RedirectToAction("Index");
        }
         * */

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return View(hotel);
            }
            var id = Data.Data.Hotels.Max(x => x.Id);
            hotel.Id = id + 1;
            Data.Data.Hotels.Add(hotel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var hotel = Data.Data.Hotels.FirstOrDefault(x => x.Id == id);
            if (hotel != null)
            {
                return View(hotel);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Hotel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var hotel = Data.Data.Hotels.FirstOrDefault(x => x.Id == model.Id);
            if (hotel != null)
            {
                hotel.Name = model.Name;
                hotel.Description = model.Description;
                hotel.Country = model.Country;
                hotel.City = model.City;
                hotel.Rating = model.Rating;
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Detail(Int32 id)
        {
            var hotel = Data.Data.Hotels.FirstOrDefault(x => x.Id == id);
            if (hotel != null)
            {
                return Json(hotel, JsonRequestBehavior.AllowGet);
            }
            return HttpNotFound();
        }
    }
}