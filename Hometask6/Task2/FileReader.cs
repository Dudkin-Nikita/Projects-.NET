using System;
using System.IO;
using System.Collections.Generic;

namespace Task2
{
    public class FileReader
    {
        private readonly Stream _stream;

        public FileReader(Stream stream)
        {
            _stream = stream ?? throw new ArgumentNullException();
        }

        public List<Object> ReadFromStream()
        {
            StreamReader sr = new(_stream);
            List<Object> fruits = new();
            string text = string.Empty;
            while ((text = sr.ReadLine()) != null)
            {
                string[] words = text.Split(new char[] { ',' });

                for(int i = 1; i < words.Length; i++)
                {
                    words[i] = words[i].Replace(".", ",");
                }

                fruits.Add(new Object() {Name = words[0], First = double.Parse(words[1]), Second = double.Parse(words[2]) });
            }

            return fruits;
        }


    }
}
