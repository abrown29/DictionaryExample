using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            animals.Add("Bear", 4);
            animals.Add("Squid", 10);
            animals.Add("Bird", 2);
            animals.Add("Stingray", 0);
            animals.Add("Turtle", 4);
            animals.Add("Leopard", 4);
            if(animals.ContainsKey("Bear"))
            {
                int value = animals["Bear"];
                Console.WriteLine("Bear has " + value + " legs");
            }
            if(animals.ContainsKey("Squid"))
            {
                int value = animals["Squid"];
                Console.WriteLine("Squid has " + value + " legs");
            }
            if(animals.ContainsKey("Dragon"))
            {
                int value = animals["Dragon"];
                Console.WriteLine("Dragon has " + value + " legs");
            }
            if(animals.ContainsKey("Squid"))
            {
                int value = animals["Stingray"];
                Console.WriteLine("Stingray has " + value + " legs");
            }
            //The above queries could be made for efficient to use by using a foreach loop to print out each of the entires with the Console.WriteLine
        } 
    }
}
