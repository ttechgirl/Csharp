using System;

namespace Exception
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 2 };

            try
            {

                Console.WriteLine(numbers[10]);

            }
            catch
            {
                Console.WriteLine("");

            }


            Console.WriteLine();
        }

    }
}
