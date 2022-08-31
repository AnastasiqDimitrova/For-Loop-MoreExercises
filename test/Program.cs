using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Friday":
                case "Saturday":

                    if (hour >= 10 && hour <= 18 && hour != 0)
                    {
                        Console.WriteLine("open");
                    }
           
                    break;
                    else if (day == "Sunday" && hour > 18 && hour < 10)
                    {
                        Console.WriteLine("closed");
                    }
            }
        }
    }
}
