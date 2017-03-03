using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want the length of the password to be?");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Option one: Letters Only");
            Thread.Sleep(1000);
            Console.WriteLine("Option two: Letters & numbers");
            Thread.Sleep(1000);
            Console.WriteLine("Option three: Letters, numbers, & symbols.");
            Thread.Sleep(1000);
            Console.WriteLine("What option would you like?");
            int option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:

                    break;
            }

        }
    }
}
