using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Task3
{
    public class ListVac
    {
        public string Name { get; set; }
        public List<Tuple> Vacations { get; set; }

        public ListVac()
        {
            Vacations = new();
        }

        public static async void SerializeToJson(IEnumerable<ListVac> list)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
                IgnoreNullValues = true
            };

            using (var fs = File.Create("emploees.json"))
            {
                await JsonSerializer.SerializeAsync(fs, list, options);
            }
        }
    }

}
