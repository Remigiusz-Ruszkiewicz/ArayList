using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayList
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList collection = new SortedList();
            collection.Add("Tytus", "Romek");
            collection.Add("Anna", 56);
            collection.Add("9", "x");

            if (collection.ContainsKey("Tytus"))
            {
                Console.WriteLine("Romek");
            }
            //Console.WriteLine(item[]);
            //Console.WriteLine(item[]);
            foreach (DictionaryEntry item in collection)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.Read();
            
        }
    }
}
