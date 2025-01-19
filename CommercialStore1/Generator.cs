using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Generator
{
    public void Show<TypeOfValue>(string v, TypeOfValue value)
    {
        Console.WriteLine(value);
    }

   
}

public class Exercise
{

  static int Main()
  {
        var ex = new Generator();
        var Value1 = 33;  // declaring an integer value
        ex.Show("Fuel", Value1);

        var Value2 = 'A'; // declaring character
        ex.Show("Plug", Value2);

        var Value3 = 20.33; //declaring double
        ex.Show("Switch", Value3);


        return 0;


  }

}



