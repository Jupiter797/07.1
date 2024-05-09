using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Ведіть текст : ");
            string text = Console.ReadLine();

            char[] sign = text.ToCharArray();

            int count = 0;

            for (int i = 0; i < sign.Length; i++)
            {
                if (sign[i] != ' ')
                    count++;
            }
            Console.WriteLine($"Кількість символів : {count}");

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
