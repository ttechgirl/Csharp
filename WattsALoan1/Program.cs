using System;

namespace WattsALoan1
{
   
    public class Program
    {
            static int Main()
            {
                int NumberOfPeriods; //globalfield
                double Principal, IntRate;
                LoanEvaluation loan = new LoanEvaluation(); //instantiation

                Console.WriteLine(
                    "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("Loan Processing\n");
                Console.WriteLine(
                "This program allows you to calculate the amount of money a ");
                Console.WriteLine(
                "customer will owe at the end of the lifetime of a loan\n");

                Principal = loan.GetPrincipal();
                IntRate = loan.GetInterestRate();
                NumberOfPeriods = loan.GetPeriod();
                Console.WriteLine(
                    "%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%\n");

                Console.WriteLine("================================");
                Console.WriteLine("Loan Estimation");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Principal: {0:C}", Principal);
                Console.WriteLine("Interest:  {0:P}", IntRate / 100);
                Console.WriteLine("Period:    {0} months", NumberOfPeriods);
                Console.WriteLine("================================\n");

                return 0;
            
        
        
        
            }
    }
   
}
