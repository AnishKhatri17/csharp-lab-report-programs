using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nC# program to find sum of 20 numbers is an Array ............");
            // Array Declaration ...
            int[] a = new int[20];
            int i, n, sum = 0;
            Console.Write("\nEnter the no. of int array elements (max 20) : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the Array Elemets : \n");
            // Enter the array elements, taking inputs from the user..
            for(i=0; i<n; i ++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Calculating the sum .....
            for(i=0; i<n; i++)
            {
                sum = sum + a[i];   
            }
            Console.WriteLine("\n\n\nThe sum of the Array Elements are : " +sum);
            Console.ReadKey();
        }
    }
}
