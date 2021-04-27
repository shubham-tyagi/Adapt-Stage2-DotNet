using System;

namespace LearnCsharp
{
	
	class CountOfDivideByFive
	{
	    public static void Main(string[] args)
	    {
			//Update the code below
			int n = Convert.ToInt32(Console.ReadLine());
			int[] iArray;
            iArray = new int[n];
            int iCount = 0;


            for (int iVal =0 ;iVal<n  ;iVal++ )
            {
                iArray[iVal] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int item in iArray)
            {   
                Console.WriteLine(item);
                if(item%5==0)
                    iCount++;
            }
            Console.WriteLine("Count of elements divide by 5: " + iCount);
	    }
	}

}