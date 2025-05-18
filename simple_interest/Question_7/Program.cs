using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nProgram to Calculate Simple Interest .....");
            Console.Write("\nEnter the Principal Amount : ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Rate of Interest (Anually) : ");
            float r = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter the Time of the Interest (in years) : ");
            float t = Convert.ToSingle(Console.ReadLine());

            float interest = (p * t * r) / 100;
            Console.Write("\n\nThe value of Simple Interest is : "+interest);
            Console.ReadKey();  

        }
    }
}
