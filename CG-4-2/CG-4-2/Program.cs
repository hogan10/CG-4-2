using System;

namespace CG_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //I start with looking at what I need to do
            //create a list with given values then loop through them

            //step 1 is create the array
            int[] myArray = new int[] { 1, 1, 2, 3, 5, 8 };

            //Now the loop

            foreach (int myNumbers in myArray) 

            //print out each value
            {
                Console.WriteLine(myNumbers);
            }
            Console.ReadLine();
        }
    }
}
