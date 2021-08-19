using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            var values = Helper.ReadFile("data.csv");
            var sortedVacations = Vacation.Sort(values);
            ListVac.SerializeToJson(sortedVacations);
            Console.ReadLine();
        }
    }
}
