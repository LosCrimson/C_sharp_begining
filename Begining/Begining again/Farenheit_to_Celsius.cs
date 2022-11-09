using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begining_again
{
    public class Farenheit_to_Celsius
    {
        private int Celsius;
        private int Kelvins;

        public void Change_to_Kelvins()
        {
            this.Kelvins = this.Celsius + 273;
            Console.WriteLine("In Kelvin it is: " + this.Kelvins);
        }

        public void Input_Celsius()
        {
            Console.WriteLine("Write Celsius: ");
            this.Celsius = Convert.ToInt32(Console.ReadLine());
        }
    }
}
