using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Cylinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cylinder Calculator: ");

            Console.Write("Please enter the cylinder's width: ");
            string radiusInput = Console.ReadLine();
            int radius = int.Parse(radiusInput);

            Console.Write("Please enter the cylinder's height: ");
            string heightInput = Console.ReadLine();
            int height = int.Parse(heightInput);

            double pi = 3.1415926;

            double volume = pi * (radius * radius) * height;

            double area = 2 * pi * radius * (radius + height);

            Console.WriteLine("The volume of the cylinder is: " + volume);
            System.Console.WriteLine("The surface area of the cylinder is: " + area);
        }
    }
}