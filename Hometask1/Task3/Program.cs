using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");
            string inputCode = Console.ReadLine();
            int[] digits = new int[inputCode.Length];
            for (int i = 0; i < inputCode.Length; i++)
            {
                digits[i] = int.Parse(inputCode[i].ToString());
            }
            int sum = 10 * digits[0] + 9 * digits[1] + 8 * digits[2] + 7 * digits[3] + 6 * digits[4] + 5 * digits[5] + 4 * digits[6] + 3 * digits[7] + 2 * digits[8];
            int remainder = sum % 11;
            int lastDigit;
            if (remainder == 0)
            {
                lastDigit = 0;
            }
            else
            {
                lastDigit = 11 - remainder;
            }
            Console.Write("Check sum = ");
            if (lastDigit == 10)
            {
                Console.WriteLine("X");
            }
            else
            {
                Console.WriteLine(Convert.ToString(lastDigit));
            }
            string result = "";
            for (int i = 0; i < inputCode.Length; i++)
            {
                result = string.Concat(result,digits[i].ToString());
            }
            if (lastDigit == 10)
            {
                result = string.Concat(result, "X");
            }
            else
            {
                result = string.Concat(result, lastDigit.ToString());
            }
            Console.WriteLine($"Your ISBN is :{result}");
            Console.ReadLine();
        }
    }
}
