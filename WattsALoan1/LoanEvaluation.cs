using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattsALoan1
{
    public class LoanEvaluation
    {
        public double GetPrincipal()
        {
            Console.Write("Enter the Principal:         $");
            double P = double.Parse(Console.ReadLine());

            return P;
        }

        public double GetInterestRate()
        {
            Console.Write("Enter the Interest Rate (%): ");
            double r = double.Parse(Console.ReadLine());

            return r;
        }

        public int GetPeriod()
        {
            Console.Write("Enter the number of months:  ");
            int t = int.Parse(Console.ReadLine());

            return t;




        }



    }
}
