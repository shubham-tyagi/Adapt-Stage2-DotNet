
using System;

namespace LearnCsharp
{

	class TrapRunTimeErrors
	{
	    public static void Main(string[] args)
	    {
            int[] iValue;
            iValue = new int[5];
            
            try{
                for (int iCount = 0; iCount < 10; iCount++)
                {
                    iValue[iCount] = int.Parse(Console.ReadLine());    
                }
                
                foreach (int iCurItem in iValue)
                {
                    Console.WriteLine(iCurItem);
                }
            }
            catch(System.IndexOutOfRangeException)
            {
                Console.WriteLine("Program tried to access index beyond the array size");
            }
            catch(Exception)
            {
                Console.WriteLine("General Exception");
            }

	    }
	}
}