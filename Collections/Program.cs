using System;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main()
        {
            var num = new ArrayList();
            num.Add("Adewunmi");
            num.Add(200);


            Console.WriteLine("Number of Items: {0}", num.Count);

            for(int i = 0 ; i < num.Count; i++)
            {
                Console.WriteLine(num[i]);
            }

            foreach (var item in num)
            {
                Console .WriteLine(item);
            }






        }








    }
}
