using System;

namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter the first day
            Console.Write("Enter the first day of school:");
            var date1 = Console.ReadLine();
            //convert to Date
            var schoolStartDate = DateTime.Parse(date1);
            //Console.WriteLine(schoolStartDate);

            Console.Write("Enter today's date:");
            var date2 = Console.ReadLine();
            //convert to Date
            var today = DateTime.Parse(date2);
            //Console.WriteLine(today);

            //Calculate remaining days of summer vacation
            var daysSummerVacation = (schoolStartDate - today).TotalDays;
            Console.WriteLine($"There are {daysSummerVacation} days remaing of summer vacation.  Enjoy!");
            
            Console.ReadLine();
        }
    }
}