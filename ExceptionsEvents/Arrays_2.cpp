using System;

namespace LearnCsharp
{
	class Sortnumbers{
	    public static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
    
            if (n<1 || n>20)
            {
    
                Console.WriteLine("INVALID_INPUT");
            }
    
            else
            {
                int[] arr = new int[n];
                for(int i=0;i<n;i++)
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                Array.Sort(arr);
                if(n%2!=0)
                    Array.Reverse(arr);
                for(int i=0;i<n;i++)
                    Console.Write(arr[i]+" ");
            }

        }
	}
}

