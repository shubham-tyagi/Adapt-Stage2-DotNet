using System;

namespace LearnCsharp
{
   
	class TwoDimArray
	{
	    public static void Main(string[] args)
	    {
			//Update the code below
			
            int [,]iMatrix;
            iMatrix = new int[3,3];

            iMatrix[0, 0] = int.Parse(Console.ReadLine());
            iMatrix[0, 1] = int.Parse(Console.ReadLine());
            iMatrix[1, 0] = int.Parse(Console.ReadLine());
            iMatrix[1, 1] = int.Parse(Console.ReadLine());

            iMatrix[2,0] = iMatrix[0,0] + iMatrix[1,0];
            iMatrix[2,1] = iMatrix[0,1] + iMatrix[1,1];
            
            int iRowSum;
            iRowSum = 0;
            for (int i=0;i<3;i++)
            {
                iRowSum = iMatrix[i,0] + iMatrix[i,1];
                iMatrix[i,2] = iRowSum;
            }
            for(int i=0;i<3;i++){
                for(int j=0;j<3;j++){
                    Console.Write(iMatrix[i,j]);
                    if(j!=2)
                        Console.Write("|");
                }
                Console.WriteLine("");
            }
        }
    }
}