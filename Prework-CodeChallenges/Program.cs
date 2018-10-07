using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem1();
            //Problem2();
            Problem3();
            //Problem4();
        }

        /*
        static void Problem1() 
        {
            //request user to input 5 numbers between 1-10
            int[] userArray = new int[5];
            int favNumber;

            for (int i = 0; i < userArray.Length; i++)
                {
                    Console.WriteLine("Pick a number: ");
                    favNumber = Convert.ToInt32(Console.ReadLine());

                    userArray[i] = favNumber;
                }
            
            //output array to the console
            Console.WriteLine(string.Join(",", userArray));

            //ask user to select a number
            Console.Write("Select a number: ");
            int selectedNum = Convert.ToInt32(Console.ReadLine());

            //output score of chosen number as a product of that number multiplied by its occurence
            int occurence = 0;
            for (int i = 0; i < userArray.Length; i++)
            {
                if(userArray[i] == selectedNum)
                {
                    occurence++;
                }
            }
            Console.WriteLine(selectedNum * occurence);
        }
        */

        /*static void Problem2()
        {
            //get input of year
            //determine if year is divisible by 4
            //except every year that is evenly divisible by 100
            //unless the year is also evenly divisible by 400
        }
        */

        static void Problem3()
        {
            //Initialize sequence
            int[] sequenceArr = { 1, 3, 2 };
            int sequenceSum = 0;
            int sequenceProduct = 1;

            //Return 'Yes' if array is perfect sequence; 
            //Return 'No if array is not a perfect sequence
            for (int i = 0; i < sequenceArr.Length; i++)
            {
                sequenceSum += sequenceArr[i];
                sequenceProduct *= sequenceArr[i];

                if (sequenceSum == sequenceProduct)
                {
                    Console.WriteLine("Yes, this is a perfect sequence!");
                }
                else
                {
                    Console.WriteLine("No, this is not a perfect sequence!");
                }
            }
        }
        
        //static void Problem4()  
        //{
        //    //Get a matrix of integers

        //    //Use for loops to loop through an array to get the sum of the array

        //    //Return sum of each row in a single dimensional integer array
        

        //}

}
}
