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
             ***************/

            Season s = Season.Winter;
            PrintSeason(s);
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
    }
}
