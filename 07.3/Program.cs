using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть текст : ");
            string text = Console.ReadLine();

            foreach (char line in text)
            {
                Console.WriteLine(line);
            }

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
