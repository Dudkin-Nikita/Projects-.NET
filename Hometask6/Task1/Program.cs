using System;
using System.Numerics;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BigInteger number = 72;
                BigInteger number2 = 96;

                var f1 = Factorize.Factorization(number);

                var task = AsyncFactorize.FactorizationAsync(number);
                var f2 = task.Result;

                var task2 = Helper.GCD(number, number2);
                Console.WriteLine(task2.Result);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Mistake");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
