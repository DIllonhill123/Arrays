using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[5000];
            Random rnd = new Random();
            int Max = 0;
            int Max2 = 0;

            for(int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = rnd.Next(1, 1000000);
            }
            for(int i =0; i < Arr.Length; i++)
            {
                for(int j =i + 1; j< Arr.Length; j++)
                {
                    if(Arr[i] > Arr[j])
                    {
                        Max = Arr[i];
                    }
                }
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j] && Arr[i] < Max)
                    {
                        Max2 = Arr[i];
                    }
                }
            }
            Console.WriteLine(Max);
            Console.WriteLine(Max2);
        }
    }
}
