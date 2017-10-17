using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[5000];
            Random rnd = new Random();
            int Max = 0;
            int almostMax = 0;
            for(int i =0; i< Arr.Length; i++)
            {
                Arr[i] = rnd.Next(1, 1000000);
            }
            for(int i = 0; i < Arr.Length; i++)
            {
                for(int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        if (Arr[i] > Arr[j] && Arr[i] > almostMax)
                        {
                            Max = Arr[i];
                        }
                    }
                }
            }
            Console.WriteLine("Max:" + Max);
            Console.WriteLine("Second Greatest:" + almostMax); 
        }
    }
}
