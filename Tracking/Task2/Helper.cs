using System.Collections.Generic;

namespace Task2
{
    public class Helper
    {
        public static Dictionary<string, string> NormalizeDictionary(Dictionary<string, string> dict)
        {
            Dictionary<string, string> newDict = new();
            foreach(var c in dict)
            {
                if(!newDict.ContainsKey(c.Key.ToLower()))
                {
                    newDict[(c.Key).ToLower()] = c.Value;
                }
            }
            return newDict;
        }
    }
}
