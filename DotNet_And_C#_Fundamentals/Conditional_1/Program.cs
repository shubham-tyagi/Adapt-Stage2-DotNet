using System;

namespace Conditional_1
{
    class Program
    {
    public static void Main(string[] args) {
		//Student code goes here ---->
            // Console.WriteLine("Enter");
		    int physics = Convert.ToInt32(Console.ReadLine());
		    int chemistry = Convert.ToInt32(Console.ReadLine());
		    int math = Convert.ToInt32(Console.ReadLine());
		
		    int average = (math + physics + chemistry)/3;
		    if(physics>100 || physics<0 || chemistry>100 || chemistry<0 || 
		        math>100 || math<0){
		      Console.WriteLine("INVALIDMARKS");
		    }
		    else{
    		    if(average>=70){
    		        Console.WriteLine("DISTINCTION");
    		    }
    		    else if(average>=60){
    		        Console.WriteLine("FIRST");
    		    }
    		    else if(average>=50){
    		        Console.WriteLine("SECOND");
    		    }
    		    else if(average>=40){
    		        Console.WriteLine("THIRD");
    		    }
    		    else {
    		        Console.WriteLine("FAIL");
    		    }
		    }
	    }
    }
}
