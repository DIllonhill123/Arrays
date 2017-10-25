using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedupe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5000];
            Random rnd = new Random();
            //int count = 0;
            int k = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 50);
            }
            Array.Sort(arr);

            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] != arr[k])
                {
                    k++;
                    arr[k] = arr[i];
                }
                if (i != k)
                    arr[i] = -1;

            }
            k--;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("Length: " + k);

            /*for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        arr[j] = 51;
                    }
                }
            }
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 51)
                {
                    count++;
                }
                if(arr[i] == 51)
                {
                    arr[i] = -1;
                }
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("Length: " + count);*/
        }
    }
}
