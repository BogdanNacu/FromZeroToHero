using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercitii
{
    class Program
    {
        enum Season
        { 
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {
            /****************
             * Exercise 1
            bool isWeekend = true;
            DateTime azi = DateTime.Now;
            
            isWeekend = IsWeekendDay(azi);
            Console.WriteLine("Is " + azi.ToString() + " a weekend day? " + isWeekend);

            DateTime date = new DateTime(2015, 5, 10);
            isWeekend = IsWeekendDay(date);
            Console.WriteLine("Is " + date.ToString() + " a weekend day? " + isWeekend);

            DateTime date2 = new DateTime(2015, 5, 2);
            isWeekend = IsWeekendDay(date2);
            Console.WriteLine("Is " + date2.ToString() + " a weekend day? " + isWeekend);
            
             * Exercise 2

            Season s = Season.Winter;
            PrintSeason(s);

             * Exercise 3+4
            
            string aCountry = LongestCountryName("Bulgaria11111", "Italy", "Israel", "Romania", "Bulgaria2");
            Console.WriteLine("The country with the longest name is {0}, and it has {1} letters.", aCountry, aCountry.Length);

            string[] countryArray = { "Italy", "Cuba" };
            aCountry = LongestCountryName(countryArray);
            Console.WriteLine("The country with the longest name is {0}, and it has {1} letters.", aCountry, aCountry.Length);
             * 
            ****************/

            double finalPrice = 0;
            GetPriceWithDiscount(200.10, 5, out finalPrice);
            Console.WriteLine("The final price is: " + finalPrice);
        }


        static bool IsWeekendDay(DateTime date)
        {
            return ((date.DayOfWeek == DayOfWeek.Sunday) || (date.DayOfWeek == DayOfWeek.Saturday));
        }


        static void PrintSeason(Season aSeason)
        {
            switch (aSeason)
            {
                case Season.Spring:
                    Console.WriteLine("Spring is here!");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer time!");
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's autumn!");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter is coming!");
                    break;
            }
        }


        static string LongestCountryName(params string[] names)
        {
            string maxCountry = names[0];
            int i = 0;
            for (i = 1; i < names.Length - 1; i++)
            {
                if (names[i].Length > maxCountry.Length)
                {
                    maxCountry = names[i];
                }
            }

            return maxCountry;
        }


        static void GetPriceWithDiscount(double price, int age, out double priceWithDiscount)
        {
            double discount = 0;

            if (age < 7)
            {
                discount = 0.25;
            }
            else if (age < 14)
            {
                discount = 0.15;
            }
            else 
            {
                discount = 0.5;
            }

            priceWithDiscount = discount * price;
        }
    }
}
