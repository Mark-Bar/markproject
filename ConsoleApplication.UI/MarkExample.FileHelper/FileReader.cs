using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using H = MarkExample.Helper;

namespace MarkExample.FileHelper
{
    public class FileReader
    {
        public void ReadFile(string path)
        {
            H.Helper h = new Helper.Helper();

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string item = reader.ReadLine();
                    Console.WriteLine(h.GreetAnimal(item));
                }
            }
        }
    }
}
