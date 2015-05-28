using FZTH.MVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FZTH.MVC
{
    public class HotelEntityToModelConverter
    {
        public static Hotel ConvertHotelFromEntityToModel(Entities.Hotel Hotel)
        {
            Hotel aHotel = new Hotel();
            aHotel.City = Hotel.Location.City;
            aHotel.Country = Hotel.Location.County;
            aHotel.Description = "No description.";
            aHotel.Name = Hotel.Name;
            aHotel.Id = Hotel.Id;
            aHotel.Rating = 1;
            return aHotel;
        }

        public static Entities.Hotel ConvertHotelFromModelToEntity(Hotel hotel)
        {
            Entities.Hotel aHotel = new Entities.Hotel();
            aHotel.Id = hotel.Id;

            if (DatabaseHelper.ContainsLocation(hotel.City, hotel.Country))
            {
                aHotel.Id = DatabaseHelper.GetLocation(hotel.City, hotel.Country).Id;
                aHotel.Location.City = hotel.City;
                aHotel.Location.County = hotel.Country;
            }
            else
            {
                Entities.Location loc = new Entities.Location();
                loc.City = hotel.City;
                loc.County = hotel.Country;
                aHotel.Location = loc;
            }
            
            aHotel.Name = hotel.Name;
            return aHotel;
        }
    }
}