using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarkExample.Helper;
using MarkExample.FileHelper;

namespace ConsoleApplication.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            string greeting = helper.GreetUser("Mark", "Barfoot");

            helper.DoSomething();

            Console.WriteLine("\n");
            Console.WriteLine(Environment.NewLine);

            FileReader fileReader = new FileReader();
            fileReader.ReadFile("Animals.txt");

            Console.WriteLine(greeting);
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("You pressed Enter");
                Console.ReadKey();
            }
        }
    }
}
