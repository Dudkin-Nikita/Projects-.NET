using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
        public class Vacation
        {
            public string Name { get; set; }
            public DateTime Start { get; set; }
            public DateTime End { get; set; }

            public Vacation(string name, DateTime start, DateTime end)
            {
                Name = name;
                Start = start;
                End = end;
            }

            public static implicit operator Vacation((string, DateTime, DateTime) a) => new(a.Item1, a.Item2, a.Item3);

            public static IEnumerable<ListVac> Sort(IEnumerable<Vacation> vacations)
            {
                return vacations
                    .Where(p =>
                        p.End.Year == 2016 && p.Start.Year == 2016 && p.End.Month > 6 && p.Start.Month > 6)
                    .GroupBy(p => p.Name)
                    .Select(p => new ListVac()
                    {
                        Name = p.Key,
                        Vacations = p
                            .Select(g => new Tuple(g.Start, g.End))
                            .ToList()
                    });
            }
        }
}

