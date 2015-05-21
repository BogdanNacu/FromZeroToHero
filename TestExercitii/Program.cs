using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExercitii.Enums;

namespace TestExercitii
{
    class Program
    {
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

            Seasons s = Seasons.Winter;
            PrintSeason(s);

             * Exercise 3+4
            
            string aCountry = LongestCountryName("Bulgaria11111", "Italy", "Israel", "Romania", "Bulgaria2");
            Console.WriteLine("The country with the longest name is {0}, and it has {1} letters.", aCountry, aCountry.Length);

            string[] countryArray = { "Italy", "Cuba" };
            aCountry = LongestCountryName(countryArray);
            Console.WriteLine("The country with the longest name is {0}, and it has {1} letters.", aCountry, aCountry.Length);
             * 

             * Exercise 5,6,7
            double finalPrice = 0;
            GetPriceWithDiscount(200.10, 20, out finalPrice);
            Console.WriteLine("The final price is: " + finalPrice);
            GetPriceWithDiscount(200.10, 20, out finalPrice);
            finalPrice = GetPriceWithDiscount(200.10, 20, DiscountType.BestDeal);
            Console.WriteLine("The final price is: " + finalPrice);

            double price = 200.10;
            int age = 15;
            GetPriceWithDiscount(ref price, age);
            Console.WriteLine("The final price is: " + finalPrice);
             

            double price = 200.50;
            int age = 20;
            double finalPrice = 0;

            finalPrice = GetPriceWithDiscount(price);
            finalPrice = GetPriceWithDiscount(price, DiscountType.Promotion);
            finalPrice = GetPriceWithDiscount(price, DiscountType.Promotion, age);
            ******************/

            double price = 200.50;
            int age = 3;
            double finalPrice = 0;

            finalPrice = GetPriceWithDiscount(price);
            Console.WriteLine(finalPrice);
            finalPrice = GetPriceWithDiscount(price, DiscountType.Promotion);
            Console.WriteLine(finalPrice);
            finalPrice = GetPriceWithDiscount(price, DiscountType.Promotion, age);
            Console.WriteLine(finalPrice);

            int price2 = 23;
            finalPrice = GetPriceWithDiscount(price2, DiscountType.Promotion, age);
            Console.WriteLine(finalPrice);

        }


        static bool IsWeekendDay(DateTime date)
        {
            return ((date.DayOfWeek == DayOfWeek.Sunday) || (date.DayOfWeek == DayOfWeek.Saturday));
        }


        static void PrintSeason(Seasons aSeason)
        {
            switch (aSeason)
            {
                case Seasons.Spring:
                    Console.WriteLine("Spring is here!");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("Summer time!");
                    break;
                case Seasons.Autumn:
                    Console.WriteLine("It's autumn!");
                    break;
                case Seasons.Winter:
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


        static void GetPriceWithDiscount(double price, out double priceWithDiscount, int age = 14)
        {
            double discount = 0;

            discount = GetDiscountByAge(age);

            priceWithDiscount = (1 - discount) * price;
        }

        static private double GetDiscountByAge(int age)
        {
            double discount;
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
                discount = 0.05;
            }
            return discount;
        }


        static double GetPriceWithDiscount(double price, DiscountType discountType = DiscountType.General, int age = 14)
        {
            double priceWithDiscount = 0, discount = 0;

            discount = GetDiscountByAge(age);

            discount += GetDiscountByType(discountType);

            priceWithDiscount = (1 - discount) * price;
            return priceWithDiscount;
        }

        static double GetDiscountByType(DiscountType discountType)
        {
            double discount = 0;
            switch (discountType)
            {
                case DiscountType.Promotion:
                    discount += 0.25;
                    break;
                case DiscountType.BestDeal:
                    discount += 0.5;
                    break;
            }
            return discount;
        }


        static double GetPriceWithDiscount(int price, DiscountType discountType = DiscountType.General, int age = 14)
        {
            double priceWithDiscount = 0, discount = 0;

            discount = GetDiscountByAge(age);

            discount += GetDiscountByType(discountType);

            priceWithDiscount = (1 - discount) * price;
            return priceWithDiscount;
        }


        static void GetPriceWithDiscount(ref double price, int age)
        {
            double initialPrice = price;
            GetPriceWithDiscount(initialPrice, out price, age);
        }
    }
}
