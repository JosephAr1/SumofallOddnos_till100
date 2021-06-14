using System;

namespace SumofallOddnos_till100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, sum;
            number1 = 2;
            sum = 0;
            while(number1 <=100)
            {
                Console.WriteLine(number1);
                sum = sum + number1;
                number1 = number1 + 2;
            }
            Console.WriteLine("Sum of all Primary numbers till 100 = " + sum.ToString());
        }
    }
}
