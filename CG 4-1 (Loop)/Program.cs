using System;

namespace CG_4_1__Loop_
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for number, declare name, convert from string to integer
            Console.Write($"Enter a number: ");
            string number = Console.ReadLine();
            int numberInt = int.Parse(number);


            //declare solution as integer
            int solution = 0;

            //declare values of loop (as integers) from 2 to 20
            for (int loopValue = 2; loopValue <= 20; loopValue++)
            {
                Console.WriteLine(loopValue * numberInt);
                //multiply value from loop with user entered number and print to console
                solution += loopValue * numberInt;
                //add answers from multiplying loop values with user entered number together
                
            }
            
            
            //print answer to console
            Console.WriteLine(solution);
            Console.ReadLine();

        }
    }
}
