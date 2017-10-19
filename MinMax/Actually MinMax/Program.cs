using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actually_MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            Random rnd = new Random();
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 50);
            }
                for (int i = 0; i < 5; i++)
                {
                int[] arr2 = new int[10];
                    for (int j = 0; j < 10; j++)
                    {
                       arr2[j] = arr[j + count];
                    }
                    Array.Sort(arr2);
                    for(int l = 0; l < arr2.Length; l++)
                    {
                        Console.Write(arr2[l] + ",");
                    }
                    Console.WriteLine();
                count += 10;
                }
            
        }
    }
}
