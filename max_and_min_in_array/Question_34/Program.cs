using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nC# program to find Maximum and Minimum elements in an array : ");
            int[] arr = new int[10];
            int i, n, smallest, greatest;
            Console.Write("\nEnter the no. of array elements : ");
            n = int.Parse(Console.ReadLine());

            // Taking array elements as input from the user .....
            Console.Write("\nEnter 10 different integer array elements : \n");
            for (i= 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //For initial values of "greatest" and "smallest" .
            greatest = smallest = arr[0];

            //Comparing the array elements to find greatest and smallest .....
            for(i = 0; i < n;i++)
            {
                if (arr[i] < smallest)
                {
                      smallest = arr[i];
                }
            }
            Console.WriteLine("\n\nThe smallest Array Element is : " + smallest);

            for (i = 0; i < n; i++)
            {
                if ( arr[i] > greatest)
                {
                     greatest = arr[i];
                }
            }
            Console.WriteLine("\n\nThe greatest Array Element is : " + greatest);
                            Console.ReadKey();

        }
    }
}
