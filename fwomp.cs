/* Pleas no hate guis it taek me 2 hour for maek program :( */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace fwomp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("helo welcom to my program! :)\n");
            Blep:
            Console.WriteLine("wat am yor best number?");
            string fwomp = Console.ReadLine();
            if(fwomp.All(char.IsDigit)) {
            Console.WriteLine("\noh! yor best number am " + fwomp + "! am liek yor number! bye bye :D");
            Thread.Sleep(4000);
            } else
            {
                Console.WriteLine("\nis no number fren :( pleas do number!\n");
                goto Blep;
            }
        }
    }
}
