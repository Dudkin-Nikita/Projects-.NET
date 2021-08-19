using System;
using System.Numerics;
using System.Collections.Generic;

namespace Task1
{
    public class Factorize
    {
        public static List<BigInteger> Factorization(BigInteger n)
        {
            if (n < 2)
            {
                throw new ArgumentException("Must be non-negative");
            }

            List<BigInteger> result = new List<BigInteger>();

            for (BigInteger i = 2; i <= (int)Math.Sqrt((double)n); i++)
            {
                while(n % i == 0)
                {
                    result.Add(i);
                    n /= i;
                }
            }
            if(n != 1)
            {
                result.Add(n);
            }

            return result;
        }
    }
}
