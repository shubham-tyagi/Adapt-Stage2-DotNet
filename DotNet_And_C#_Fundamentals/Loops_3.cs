using System;

class Source {
	static void Main() {
        int num = Convert.ToInt32(Console.ReadLine());
        int n = num;
        int i=0,sum = 0;
        while(n!=0){
            i++;
            int rem = n%10;
            sum = sum + Convert.ToInt32(Math.Pow(rem,3));
            n = n/10;
        }
        if(i!=3)
            Console.WriteLine("INVALID_INPUT");
        else if(num == sum)
            Console.WriteLine("ARMSTRONG");
        else 
            Console.WriteLine("NOT ARMSTRONG");
	}
}
