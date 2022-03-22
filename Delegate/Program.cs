using System;

namespace Delegate
{
    internal class Program
    {


        public delegate void BankLoan(); //declaring a delegate

        static void Main()
        {

            //introducing anonymous method to delegate

            BankLoan bl = delegate () //assigning delegate as a method
            {


            };

            bl(); // called the delegate variable

            //lamda expression

            BankLoan bl2 = () => { };
            bl2();


            var loan = new Loan();
            BankLoan loan1 = loan.Terms; //assigning method to delegate 
            loan1();

            Simple msg = Exercise.Welcome; /*the class is called with the method because the delegae class 
                                           differ and the method is not visible */

            msg();



        }
    }
           
       
    public class Loan //nonstatic method
    {
        public void Terms()
        {

        }
    }
  //using static method 
    public delegate void Simple();

    public class Exercise
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the Wonderful World of C# Programming!");
        }
    }
   

   


    
}