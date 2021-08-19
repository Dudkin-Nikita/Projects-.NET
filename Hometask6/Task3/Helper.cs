using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task3
{
    public static class Helper
    {
        public static IEnumerable<Vacation> ReadFile(string filePath)
        {
            var strings = File.ReadLines(filePath).ToArray();

            for (var i = 0; i < strings.Length; i++)
            {
                (string, DateTime, DateTime) emploee;
                var newValue = strings[i].Split(',');
                if (newValue.Length > 3)
                {
                    Console.WriteLine($"Wrong amoun of arguments in line : {i + 1}");
                    continue;
                }
                try
                {
                   
                    emploee = (newValue[0], Convert.ToDateTime(newValue[1]), Convert.ToDateTime(newValue[2]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"EXCEPTION. {ex.Message} in line: {i + 1}");
                    continue;
                }
                yield return emploee;
            }
        }
    }

}
