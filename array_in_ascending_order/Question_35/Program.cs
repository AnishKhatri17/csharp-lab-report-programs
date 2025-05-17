using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nC#program to sort array elements in ascending order...........");
            int i, j, n, temp;
            int[] arr = new int[10];

            Console.Write("\nEnter the number of array Elements (max 10) : ");
            n = Convert.ToInt32(Console.ReadLine());

            //Taking array elemets as input from the user .....
            Console.WriteLine("\nEnter the array elements : ");
            for(i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Logic to sort array elements in ascending order.
            for(i=0; i<n; i++)
            {
                for(j=i+1; j<n; j++)
                {           
                                         // if (arr[i] < arr[j]) is the logic for descending order and all other code are same.
                    if (arr[i] > arr[j]) // arr[i] > arr[j] is the logic for ascending order . 
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;  
                    }
                }
            }
                    Console.WriteLine("\n\n\nThe array elements in ascending order is : ");
                    for(i=0; i<n;i++)
            {
                Console.WriteLine(+arr[i]);
            }
            Console.ReadKey();
        }
    }
}
