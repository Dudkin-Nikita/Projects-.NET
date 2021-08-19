using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature: ");
            double enterTemperature = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter speed in meters per second: ");
            double enterSpeed = double.Parse(Console.ReadLine());
            double necessaryTemperature = enterTemperature * 1.8 + 32;
            double necessarySpeed = enterSpeed * 2.237;
            double resultTemperature = 35.74 + 0.6215 * necessaryTemperature + (0.4275 * necessaryTemperature - 35.75) * Math.Pow(necessarySpeed, 0.16);
            double result = (resultTemperature - 32) * 5 / 9;
            if (Math.Abs(necessaryTemperature) > 50 || necessarySpeed > 120 || necessarySpeed < 3)
            {
                Console.WriteLine($"New temperarure is {result} , but it can be incorrect");
            }
            else
            {
                Console.WriteLine($"New temperature is {result}");
            }
            Console.ReadLine();
        }
    }
}
