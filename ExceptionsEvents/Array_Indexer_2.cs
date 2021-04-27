using System;

namespace LearnCsharp
{

	class SingleDimArray
	{
	    public static void Main(string[] args) 
	    {

            int[] iArray=new int[10];
	        
            for(int i=0;i<10;i++){
                iArray[i] = 2 * (i+1);
            }
			//Add your code 


            foreach (var item in iArray)
            {
                Console.WriteLine((item)); 
            }
            
        }

	}

}