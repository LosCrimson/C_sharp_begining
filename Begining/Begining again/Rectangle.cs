using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begining_again
{
    public class Rectangle
    {
            //member variables
            private double lenght;
            private double width;

            public void Acceptdetails()
            {
                lenght = 4.5;
                width = 3.5;
            }
            public double GetArea()
            {
                return lenght * width;
            }
            public void Display()
            {
                Console.WriteLine("Lenght: {0}", lenght);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
    }
}
