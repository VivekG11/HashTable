using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyMapNode<string, int> hash = new MyMapNode<string, int>(5);
            string[] words = { "to", "be", "or", "not", "to", "be" };
            int index = 1;
            foreach(string i in words)
            {
                index = hash.Check(i);
                if(index>1)
                {
                    hash.Add(i, index);
                }
                else
                {
                    hash.Add(i, 1);
                }
            }

            IEnumerable<string> items = words.Distinct<string>();
            foreach(var i in items)
            {
                hash.Display(i);
            }
           


        }
    }
}
