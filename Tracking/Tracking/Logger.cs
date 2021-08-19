using System.Reflection;
using System.Text.Json;
using System.Text.Unicode;
using System.Collections;
using System.IO;
using System.Text.Encodings.Web;

namespace Tracking
{
    public class Logger
    {
        public string Path { get; set; }

        public Logger(string path)
        {
            Path = path;
        }

        public void Track(object example)
        {
            ArrayList arrayList = new ArrayList();
            var type = example.GetType();
            foreach (var attr in type.GetCustomAttributes<TrackingEntityAttribute>())
            {
                foreach (var t in type.GetProperties())
                {
                    foreach (var attr1 in t.GetCustomAttributes<TrackingPropertyAttribute>())
                    {
                        string name = string.Empty;
                        if (attr1.PropertyName != "")
                        {
                            name = attr1.PropertyName;
                        }
                        else
                        {
                            name = t.Name;
                        }
                        var value = t.GetValue(example);
                        var anon = new { name, value };
                        arrayList.Add(anon);
                    }
                }
                foreach (var t in type.GetFields())
                {
                    foreach (var attr1 in t.GetCustomAttributes<TrackingPropertyAttribute>())
                    {
                        string name = string.Empty;
                        if (attr1.PropertyName != "")
                        {
                            name = attr1.PropertyName;
                        }
                        else
                        {
                            name = t.Name;
                        }
                        var value = t.GetValue(example);
                        var anon = new { name, value };
                        arrayList.Add(anon);
                    }
                }
            }
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
                IgnoreNullValues = true
            };
            var json = JsonSerializer.Serialize(arrayList, options);
            File.WriteAllText(Path, json);
        }
    }
}
