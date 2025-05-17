using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nProgram to find Area and Volume of a Rectangular Box ...");
            int length, breadth, height, Area, Volume;
            Console.WriteLine("\nEnter the Length of Rectangle.");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the Breadth of a Rectangle.");
            breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the Height of a Rectangle.");
            height = Convert.ToInt32(Console.ReadLine());

            Area = length * breadth;
            Volume = height * breadth *height;
            Console.WriteLine("The area of a Rectangle is : "+Area);
            Console.WriteLine("The volume of a Rectangle is : "+Volume);
            Console.ReadKey();
        }
    }
}
