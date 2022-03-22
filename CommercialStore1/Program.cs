using System;

namespace CommercialStore1
{
    internal class Program
    {
        static void Main()
        {
            StoreItem exo = new StoreItem();
            StoreItem.CItem Part;

            Part = new StoreItem.CItem();
            Part.Item = 97.43;
            exo.Add(Part);

            Part = new StoreItem.CItem();
            Part.Item = 274.87;
            exo.Add(Part);

            Part = new StoreItem.CItem();
            Part.Item = 8.7873;
            exo.Add(Part);

            Part = new StoreItem.CItem();
            Part.Item = 2764.4;
            exo.Add(Part);

            Part = new StoreItem.CItem();
            Part.Item = 92.4662;
            exo.Add(Part);

            Part = new StoreItem.CItem();
            Part.Item = 66800.85;
            exo.Add(Part);

            Console.WriteLine("-=- List of Items -=-");

            for (int i = 0; i < exo.Count(); i++)
            {
                StoreItem.CItem One = exo.Retrieve(i);

                exo.ShowItem(One.Item);
            }

            Console.WriteLine("\nNumber of Items: {0}\n", exo.Count());
        
        
          for (int i = 0;i < exo.Count();i++)
          {
                Exercise.Show One = exo.Retrieve(i);

                exo.ShowItem<double>("Item", i + 1, One.Item);
          }

            Console.WriteLine("\nNumber of Items: {0}\n", exo.Count());
        }

    }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
    
}
