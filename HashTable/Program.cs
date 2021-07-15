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
           
            MyMapNode<string , int> myMapNode = new MyMapNode<string, int>(10);
            string[] paragraph;
            string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            paragraph = input.Split(' ');

            int num = 1;
            foreach(string i in paragraph)
            {
                num = myMapNode.Check(i);
                if(num > 1)
                {
                    myMapNode.Add(i, num);
                }
                else
                {
                    myMapNode.Add(i, 1);
                }
            }
            IEnumerable<string> dist = paragraph.Distinct<string>();
            foreach(var i in dist)
            {
                myMapNode.Display(i);
            }

            MyMapNode<string, int> mapNode = new MyMapNode<string, int>(10);
            string[] phrase;
            string inputPhrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            phrase = inputPhrase.Split(' ');

            int number = 1;
            foreach(string i in phrase)
            {
                num = mapNode.Check(i);
                if(number > 1)
                {
                    mapNode.Add(i, num);
                }
                else
                {
                    mapNode.Add(i, 1);
                }
            }

            IEnumerable<string> unique = phrase.Distinct<string>();
            string delWord = Console.ReadLine();
            mapNode.Remove(delWord);
            foreach(var i in unique)
            {
                mapNode.Display(i);
            }
        }
    }
}
