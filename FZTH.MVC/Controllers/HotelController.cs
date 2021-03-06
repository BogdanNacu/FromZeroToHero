﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FZTH.MVC.Data;
using NHibernate;

namespace FZTH.MVC.Controllers
{
    public class HotelController : Controller
    {
        //
        // GET: /Hotel/
        [HttpGet]
        public ActionResult Index()
        {
            ISession aSession = NHibernateHelper.OpenSession();
            var databaseHelper = new DatabaseHelper(aSession);
            var entityList = databaseHelper.GetHotels();
            var hotelList = new List<Hotel>();
            for (int i = 0; i < entityList.Count; i++)
            {
                hotelList.Add(HotelEntityToModelConverter.ConvertHotelFromEntityToModel(entityList[i]));  
            }

            //return View("HotelListView", Data.Data.Hotels);  --- hard-coded hotel list
            return View("HotelListView", hotelList);
        }

        /*
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
        */

        public ActionResult Delete(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var hotel = session.Get<Entities.Hotel>(id);
                var hotelModel = HotelEntityToModelConverter.ConvertHotelFromEntityToModel(hotel);
                return View(hotelModel);
            }
        }


        [HttpPost]
        public ActionResult Delete(int id, Hotel hotel)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(HotelEntityToModelConverter.ConvertHotelFromModelToEntity(hotel));
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                return View();
            }
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

        /*
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
        }*/

        [HttpPost]
        public ActionResult Create(Hotel hotel)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        var hotelEntity = new Entities.Hotel();
                        hotelEntity = HotelEntityToModelConverter.ConvertHotelFromModelToEntity(hotel);
                        session.Save(hotelEntity);
                        transaction.Commit();
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                return View();
            }
        }

        /*
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
         * */

        public ActionResult Edit(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var hotel = session.Get<Entities.Hotel>(id);
                return View(HotelEntityToModelConverter.ConvertHotelFromEntityToModel(hotel));
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, Hotel hotel)
        {
            DatabaseHelper.UpdateHotel(id, hotel);
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

        [HttpGet]
        public ActionResult GetJSON()
        {
            var hotel = Data.Data.Hotels;
            if (hotel != null)
            {
                return Json(hotel, JsonRequestBehavior.AllowGet);
            }
            return HttpNotFound();
        }
    }
}