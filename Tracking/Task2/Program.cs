using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("name", "Artem");
            dict.Add("Name", "Alex");
            dict.Add("val", "122");
            dict.Add("Sar", "12");

            dict = Helper.NormalizeDictionary(dict);

            SimpleBinder binder =SimpleBinder.getInstance();
            TestClass entity = binder.Binder(typeof(TestClass),dict);
            //дебаг для демонстрации работы(в entity наш экземпляр)
            Console.ReadLine();
        }
    }
}
