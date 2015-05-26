using FZTH.MVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FZTH.MVC
{
    public class HotelEntityToModelConverter
    {
        public static Hotel ConvertHotelToModel(Entities.Hotel Hotel)
        {
            Hotel aHotel = new Hotel();
            aHotel.City = Hotel.Location.City;
            aHotel.Country = Hotel.Location.County;
            aHotel.Name = Hotel.Name;
            aHotel.Id = Hotel.Id;
            return aHotel;
        }
    }
}