using System;

namespace LearnCsharp
{
	class Decimaltobinary{
	    public static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            if(n<1 || n>999)
                Console.WriteLine("INVALID_INPUT");
            else{
                string s="";
                while(n!=0){
                    int rem = n%2;
                    s = rem.ToString() + s;
                    n = n/2;
                }
                Console.WriteLine(s);
            }
	    }
	}

}