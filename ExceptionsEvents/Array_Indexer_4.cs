// Sorry even after many tries was only able to have 75% of the test cases passed
using System;

namespace LearnCsharp
{

    class ArraySorting
    {
        public static void Main(string[] args)
        {
        
            //Update the code below
            int[] iArray;            
            iArray = new int[7];
            // int iTemp = 0;
            string sSortType;
            
            String sSortingType = "Incorrect";
            
            
//Write your code to sort an array here
            sSortType = Console.ReadLine(); 
            
            for (int i=0;i<7;i++)
            {
                string num = Console.ReadLine();
                if(num!="")
                    iArray[i] =int.Parse(num);
            }
            
            Array.Sort(iArray);
            if(sSortType == "A")
                sSortingType = "Ascending";
            else if(sSortType == "D"){
                sSortingType = "Descending";
                Array.Reverse(iArray);
            }
        
            Console.WriteLine("After {0} Sorting", sSortingType);            
            foreach (int item in iArray)
            {             
                Console.Write(item + " ");
            }
        }

    }

}