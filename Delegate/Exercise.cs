using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Exercise1
    {

		delegate string dlgSimple();

		class Exercise
		{
			public static event dlgSimple Simply;

			public static string Welcome()
			{
				Console.WriteLine("Welcome to the Wonderful World of C# Programming!");
				return "";
			}

			public static void SayHello()
			{
				Simply();
			}

			static int Main()
			{
			
				

				Simply += new dlgSimple(Welcome); //confused line 

				SayHello();

				return 0;

				var count = new { LastName = "Seyi" }; //annonymous expression
				dlgSimple dlg = delegate () { return count.LastName; }; //lamda expression and delegate method
			   
				//dlg is an instances used to reference or call the argument
			
			
			}
		}


	}
}
