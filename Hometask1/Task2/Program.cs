using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int index;
            int number;
            if (firstNumber > 0)
            {
                index = secondNumber - firstNumber + 1;
                number = firstNumber;
            }
            else
            {
                index = secondNumber;
                number = 1;
            }
            int[] data = new int[index];
            for (int i = 0; i < index; i++)
            {
                data[i] = number;
                number++;
            }
            Console.WriteLine("Numbers, which contains four 1: ");
            for (int i = 0; i < index; i++)
            {
                int counter = 0;
                number = data[i];
                int remainder;
                while (number >=1 )
                {
                    remainder = number % 2;
                    if(remainder == 1)
                    {
                        counter++;
                    }
                    number = number / 2;
                }
                if (counter == 4)
                {
                    Console.WriteLine(Convert.ToString(data[i]));
                }
            }
            Console.ReadLine();
        }
    }
}
