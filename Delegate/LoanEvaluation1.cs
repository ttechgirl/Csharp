using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class LoanEvaluation1
    {

        //passing argument to delegate
        public double GetPrincipal()
        {
            Console.Write("Enter the principal:      $");
            double P = double.Parse(Console.ReadLine());

            return P;
        }


        public double GetInterestRate()
        {
            Console.Write("Enter the Interes Rate(%):      ");
            double r = double.Parse(Console.ReadLine());

            return r;
        }


        public double GetPeriod(int TypeOfPeriod, double Periods)
        {
            Console.WriteLine("How do you want to enter the length of time?");
            Console.WriteLine("1 - In Days");
            Console.WriteLine("2 - In Months");
            Console.WriteLine("3 - In Years");
            Console.Write("Your Choice:   ");

            TypeOfPeriod = int.Parse(Console.ReadLine());
            return 0;


            if (TypeOfPeriod == 1)
            {
                Console.Write("Enter the number of days: ");
                Periods = double.Parse(Console.ReadLine());
                return Periods / 360;
            }

            else if(TypeOfPeriod == 2)
            {
                Console.Write("Enter the number of months: ");
                Periods = double.Parse(Console.ReadLine());
                return Periods / 12;
            }

            else if (TypeOfPeriod == 3)
            {
                Console.Write("Enter the number of years: ");
                Periods = double.Parse(Console.ReadLine());
                return Periods ;
            }


            else 
            {
                TypeOfPeriod = 0;
                // The user made an invalid selection. So, we will give up
                Console.WriteLine("Bad Selection\n");
                return Periods / 12;
            }




        }




    }


}
