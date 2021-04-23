using System;

namespace LearnCsharp
{
	class Rightangletriangle{
	    public static void Main(string[] args) {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            
            if(a<b || a<c)
                Console.WriteLine("INVALID_INPUT");
            else{
                if((Math.Pow(b,2)+Math.Pow(c,2)) == Math.Pow(a,2))
                    Console.WriteLine("RIGHT ANGLE TRIANGLE");
                else
                    Console.WriteLine("NOT RIGHT ANGLE TRIANGLE");
            }
	    }
    }
}