using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialStore1
{
    public class Generator1
    {
       

        public void Show<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0}: {1}", msg, value);
        }
    }

    public class Exercise
    {
        static int Main()
        {
            var ex = new Generator();
            


            ex.Show("integer", 100);

            ex.Show<double>("decimal", 1.0);

            ex.Show<char>("character", 'A');




            return 0;


        }

    }



}





