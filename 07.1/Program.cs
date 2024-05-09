using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1
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
            Console.Write($"Текст у зворотньому порядку : ");

            for (int i = sign.Length - 1; i >= 0; i--)
            {
                Console.Write($" {sign[i]} ");
            }
            //Console.WriteLine($"Кількість символів : {count}");

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
