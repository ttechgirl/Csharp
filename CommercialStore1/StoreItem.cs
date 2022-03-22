using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialStore1
{
    public class StoreItem
    {
      public class CItem
      {
            public double Item;
            public CItem Next;

      }

        public CItem Head = null;
        public int Size;  

      public int Count()
      {
            return Size;    
      }
    
      public int Add(CItem NewItem)
      {
        CItem cItem = new CItem();
            cItem= NewItem;
            cItem.Next = Head;
            Head = cItem;

            return Size++;

      }
        public CItem Retrieve(int Position)
        {
            CItem Current = Head;

            for (int i = Count() - 1; i > Position && Current != null; i--)
            {
                Current = Current.Next;
            }

            return Current;
        }

        public void ShowItem(double item)
        {
            Console.WriteLine("Item: {0}", item);
        }

        internal void ShowItem<T>(string v1, int v2, object item)
        {
            throw new NotImplementedException();
        }
    }





}
 