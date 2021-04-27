using System;

namespace LearnCsharp
{
 
 class JaggedArray
 {
         public static void Main(string[] args) 
        {
   //Write Your Code Here
            int[][] iTickets = new int[3][];
            iTickets[0] = new int[3] {1, 5, 7};
            iTickets[1] = new int[4] {2, 8, 6, 4};
            iTickets[2] = new int[2] {3, 9};
            
            DisplayArray(iTickets);
        }

        private static void DisplayArray(int[][] iTickets)
        {
         //Write Your Code Here
        //   Console.WriteLine("EmpNo")
           for (int n = 0; n < iTickets.Length; n++) {
     
                for (int k = 0; k < iTickets[n].Length; k++) {
                    // Print the elements in the row
                   Console.Write(iTickets[n][k]+"|");
                }
                Console.WriteLine();
            }
        }

}
}