using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkExample.Helper
{
    public class Helper
    {
        public string GreetUser(string name, string surname)
        {
            string fullName = $"Hello {name} {surname}";
            return fullName;
        }

        public string GreetAnimal(string name)
        {
            string greeting = $"Hello {name}";
            return greeting;
        }

        public void DoSomething()
        {
            List<string> colours = new List<string>();

            colours.Add("Green");
            colours.Add("Blue");
            colours.Add("Red");
            colours.Add("Yellow");
            colours.Add("Black");
            colours.Add("Pink");
            colours.Add("Brown");
            colours.Add("Blue");

            int counter = colours.Count;

            //foreach (string colour in colours)
            //{
            //    Console.WriteLine(colour);
            //}

            colours.ForEach(e => Console.WriteLine(e));

            List<string> blueColours = colours.Where(e => e == "Blue").ToList();
            bool hasWhite = colours.Any(e => e == "White");

            if (hasWhite == false)
            {
                colours.Add("White");
            }

        }
    }
}
