using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nEnter the Radius of a Circle : \t");

            double r = Convert.ToDouble(Console.ReadLine());
            //float r = Convert.ToSingle(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("\nThe area of a Circle is : " + area);

            Console.ReadKey();
        }
    }
}
