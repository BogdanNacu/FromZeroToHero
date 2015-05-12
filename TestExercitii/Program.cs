using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWeekend = true;
            DateTime azi = new DateTime();
            
            isWeekend = IsWeekendDay(azi);
            Console.WriteLine(isWeekend);

            DateTime date = new DateTime(2015, 5, 10);
            isWeekend = IsWeekendDay(date);
            Console.WriteLine(isWeekend);

            DateTime date2 = new DateTime(2015, 5, 2);
            isWeekend = IsWeekendDay(date2);
            Console.WriteLine(isWeekend);
        }

        static bool IsWeekendDay(DateTime date)
        {
            return ((date.DayOfWeek == DayOfWeek.Sunday) || (date.DayOfWeek == DayOfWeek.Saturday));
        }
    }
}
