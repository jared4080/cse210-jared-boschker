using System;
using System.Runtime.InteropServices;


namespace Learning03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fractionInstance = new Fraction();
            Random random = new Random();

            int min = 1;
            int max = 101;

            for (int i = 0; i < 20; i++)
            {
                int randNumTop = random.Next(min, max);
                int randNumBottom = random.Next(min, max);

                fractionInstance.SetTop(randNumTop);
                fractionInstance.SetBottom(randNumBottom);

                Console.WriteLine($"Fraction {i + 1} string: {fractionInstance.GetFractionString()} number: {fractionInstance.GetFractionDecimal()}");
            }
        }
    }
}