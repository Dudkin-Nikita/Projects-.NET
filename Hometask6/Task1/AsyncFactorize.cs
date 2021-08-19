using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class AsyncFactorize
    {
        public static async Task<List<BigInteger>> FactorizationAsync(BigInteger n)
        {
            var tcs = new TaskCompletionSource<List<BigInteger>>();
            new Thread(Calculation).Start();
            return await tcs.Task;

            void Calculation()
            {
                try
                {
                    var result = Factorize.Factorization(n);
                    tcs.SetResult(result);
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            }
        }
    }
}
