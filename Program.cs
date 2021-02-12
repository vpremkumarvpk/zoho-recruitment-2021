using System;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            char[] ans = new char[100];
            int i, j, k;
            int len = str.Length;
            int mid = len / 2;
            int idx = mid;
            int count = 0;
            int val = str.Length;    
            for (i = 1; i <= val; i++)
            {                
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                idx = 3;
                for (k = 1; k <= i; k++)
                {
                    if (idx >= len)
                        idx = idx % len;
                    Console.Write(arr[idx]);
                    if (idx < len)
                        idx++;                   
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
