using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Object> fruits = new List<Object>();
                using (Stream s = File.OpenRead("data.txt"))
                {
                    var tr = new FileReader(s);
                    fruits = tr.ReadFromStream();
                }
                string name = Algorithm.NameSearch(fruits, 5, 5, 4);
                Console.WriteLine($"Object name : {name}");
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Bad argument");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
