using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Task1
{
    public class Helper
    {
        public async static Task<BigInteger> GCD(BigInteger first, BigInteger second)
        {
            var task1 = AsyncFactorize.FactorizationAsync(first);
            var task2 = AsyncFactorize.FactorizationAsync(second);

            List<BigInteger> firstFactor = task1.Result;
            List<BigInteger> secondFactor = task2.Result;

            BigInteger result = await Calculations(firstFactor, secondFactor);
            return result;

            
        }

        public static Task<BigInteger> Calculations(List<BigInteger> first, List<BigInteger> second)
        {
            var task = new Task<BigInteger>(() =>
            {
                List<BigInteger> newList = new List<BigInteger>();
                foreach (var s in first)
                {
                    if(second.Contains(s))
                    {
                        newList.Add(s);
                        second.Remove(s);
                    }
                }
                BigInteger res = BigInteger.One;
                foreach (BigInteger s in newList)
                {
                    res *= s;
                }
                return res;
            });
            task.Start();
            return task;
        }
    }
}
