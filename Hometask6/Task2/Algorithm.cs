using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Algorithm
    {
        public static string NameSearch(List<Object> list, double first, double second, int amount)
        {
            if (amount < 1)
            {
                throw new ArgumentException("Wrong argument");
            }
            var items = from l in list
                        select new
                        {
                            Name = l.Name,
                            Distance = Math.Sqrt((l.First - first) * (l.First - first) + (l.Second - second) * (l.Second - second))
                        };

            var items2 = items.AsParallel()
                .AsOrdered()
                .OrderBy(x => x.Distance)
                .Take(amount)
                .GroupBy(x => x.Name)
                .Select(group => new { Name = group.Key, Count = group.Count() })
                .OrderByDescending(pair => pair.Count)
                .Take(1)
                .Select(pair => pair.Name)
                .ToArray();

            string result = items2[0];
            return result;
        }
    }
}
