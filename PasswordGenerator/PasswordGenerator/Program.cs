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
            string path = "";
            Console.WriteLine("What do you want the length of the password to be?");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to export the password?");
            string export = Console.ReadLine();
            if(export == "yes" || export == "Yes")
            {
                Console.WriteLine("Please type the export path.");
                path = Console.ReadLine();
            }
            Console.WriteLine("Option one: Letters Only");
            Thread.Sleep(1000);
            Console.WriteLine("Option two: Letters & numbers");
            Thread.Sleep(1000);
            Console.WriteLine("Option three: Letters, numbers, & symbols.");
            Thread.Sleep(1000);
            Console.WriteLine("What option would you like?");
            int option = Int32.Parse(Console.ReadLine());
            Random rand = new Random();
            int i = 1;
            String finalpassword = "";
            switch (option)
            {
                case 1:
                    
                    String letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    
                    while (i < length){
                        int randomletter = rand.Next(1, 52);
                        finalpassword += letters[randomletter];
                        i++;

                    }
                    break;
                case 2:
                    letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

                    while (i < length)
                    {
                        int randomletter = rand.Next(1, 62);
                        finalpassword += letters[randomletter];
                        i++;

                    }
                    break;
                case 3:
                    letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890&%$#";

                    while (i < length)
                    {
                        int randomletter = rand.Next(1, 66);
                        finalpassword += letters[randomletter];
                        i++;

                    }
                    break;
            }
            Console.WriteLine("Your final password is " + finalpassword);
            Console.ReadLine();
            if(export == "yes" || export == "Yes")
            {
                System.IO.File.WriteAllText(@"" + path, finalpassword);
            }

        }
    }
}
