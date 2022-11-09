using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begining_again
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();

            string vardas = "";
            while (vardas != "stop")
            {
                Console.WriteLine("Iveskite savo varda: ");
                vardas = Console.ReadLine();
                Console.WriteLine("Sveiki {0} [ENTER - testi]", vardas);
            }

            Console.Clear();
            Console.WriteLine("Ate...");
            Console.ReadLine();

            Farenheit_to_Celsius Converter = new Farenheit_to_Celsius();
            Converter.Input_Celsius();
            Converter.Change_to_Kelvins();
            Console.ReadLine();

        }
    }
}
