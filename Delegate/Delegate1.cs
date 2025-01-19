using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Delegate1
    {


        public delegate void BankLoan(); //declaring a delegate
        public delegate void Simple(String s);

        public static void Main()
        {

            //introducing anonymous method to delegate

            BankLoan bl = delegate () //assigning delegate as a method
            {

            };

            bl(); // called the delegate variable

            //lamda expression

            BankLoan bl2 = () => { };
            bl2();




            var pr = new Delegate1();
            BankLoan loan1 = pr.Terms; //assigning nonstatic method to delegate 


            Simple msg = Welcome; //static method
            msg += Bank;  //multi-delegate
            msg("Welcome to the Wonderful World of C# Programming!");

            //delegate that returns value
            Cbn cbn = Delegate2.Naira;
            cbn();

            //delegate with return type and return value with nested class
            Delegate2.Gender gen = Delegate2.Person;
            gen("Male");






        }


        public static string Employee { get; set; }

        public static void Welcome(string s)
        {
            Console.WriteLine($"{0}");
        }

        public void Terms()
        {

        }

        public static void Bank(string s)
        {
            Console.WriteLine();

        }


    } 
    public delegate int Cbn();

        public class Delegate2
        {

            public delegate bool Gender(string s);

            public static int Naira()
            {

                return 1000;
            }

            public static bool Person(string s)
            {
                return true;
            }


        }


}











