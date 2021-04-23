using System;

class Source {
    static bool isPrime(int num){
        for(int i=2;i<=(num/2);i++){
            if(num%i == 0)
                return false;    
        }	    
        return true;
	}
	static void Main() {
	    
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        
        if(a>b || a<3 || b>1000)
            Console.WriteLine("INVALID_INPUT");
        else{
            int sum = 0;
            for(int i = a;i<=b;i++){
                if(isPrime(i))
                    sum = sum + i;
            }
            Console.WriteLine(sum);
        }
        
	}
	
}
