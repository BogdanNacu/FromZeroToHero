using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FZTH.MVC.Data
{
    public static class Data
    {
        public static List<Hotel> Hotels
        {
            get
            {
                return new List<Hotel>()
                {
                    new Hotel
                    {
                        Id = 1,
                        Name = "Hotel International",
                        Description = "DFescriere hotel International",
                        Rating = 4,
                        City = "Iasi",
                        Country = "Iasi"
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Hotel Unique",
                        Description = "Un hotel unic in Bucuresti",
                        Rating = 4,
                        City = "Bucuresti",
                        Country = "Bucuresti"
                    },
                    new Hotel
                    {
                        Id = 3,
                        Name = "Hotel Mariko Inn",
                        Description = "Descriere a la Mariko",
                        Rating = 3,
                        City = "Roman",
                        Country = "Neamt"
                    }
                };
            }
        }
    }

}