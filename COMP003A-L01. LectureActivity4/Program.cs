/*
 * Author: Matthew Hudson
 * Course: COMP-003A
 * Purpose: Code for Lecture Activity 4
 * Reference: https://learn.microsfot.com./en-us/csharp/larugage-reference/statements/iteration-statements
 */

using System.Security.Cryptography;

namespace COMP003A_L01._LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for-loop statement");
            Console.WriteLine("".PadRight(50, '*'));

            // count 0-9
            int limit = 10; // variable limit for hte loop
            /*
             * Thefore staement: executes its body wile a speciefied boolean expresion exvaluates to true.
             * There are 3 parts in the for loop statement
             * 1. int counter = 0; => loop variabel initialization
             * 2. counter < limit; => condition
             * 3. counter ++ => interator
             */
            for (int counter = 0; counter < limit; counter++)
            {
                // this code block will execute every loop
                Console.WriteLine($"\tCurrent counter: {counter}");

            }

            Console.WriteLine("\n"); // new line
            Console.WriteLine("".PadRight (50, '*'));
            Console.WriteLine("foreach statement");
            Console.WriteLine("".PadRight(50, '*'));

            // this is a simple arraw with 10 items in it. you will earn more about arrays on module 7
            string[] simpleArray = new string[] { "eleifend", "donec", "pretium", "vulputate", "sapien", "nec", "sagittis", "aliquam", "malesuada", "bibendum"};
            //enumerates the elements of a collection and executes its body for each element of the collection
            foreach (var item in simpleArray)
            {
                Console.WriteLine("\n"); // new line
                Console.WriteLine("".PadRight(50, '*'));
                Console.WriteLine("do-while statement");
                Console.WriteLine("".PadRight(50, '*'));

                /*
                 * The do staement executes a statement or a block of statements while specified
                 * Boolean expresion evalutes to true. because that expression is evaluated afer
                 * each exuction of hte loop, a do loop executes one or more times.The do
                 * statement differs from a while loop, which executes zero or more times.
                 */

                int counter2 = 0; //initial counter2 value

                do
                {
                    Console.WriteLine($"\tCurrent counter2: {counter2}");
                    counter2++;  //counter 2 by 1
                } while (counter2 < 10); // loop until counter 2 is equal to 10 or greater

                Console.WriteLine("\n");
                Console.WriteLine("".PadRight(50, '*'));
                Console.WriteLine("while statement");
                Console.WriteLine("".PadRight(50, '*'));

                /*
                 * This whle statement executes a statement or a vlock fo statement wile a specified
                 * Boolean expression evalutes to true. Because that expression is evaluated before
                 * each execution of the loop, a while loop executes zero or more times. The while
                 * statement differs from a do loop, which executes one or more times
                 */

                int counter3 = 0; // initial counter3 value

                while (counter3 < 20)
                {
                    Console.WriteLine($"\tCurrent counter3: {counter3}");
                    counter3 += 2; // add 2 to the value of counter 3
                }    
                Console.WriteLine("\n");
                Console.WriteLine("".PadRight(50, '*'));
                Console.WriteLine("example for loop program that counter 1-20 and checks if it is odd or even");
                Console.WriteLine("".PadRight(50, '*'));

                //1. loop variable 'i' is set 1 instead of 0
                //2. loop as long as the loop varaible is less than or equal to 20
                //3. increment the loop variable by 1
                for (int i = 1; i <= 20; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"\t{i}: even");
                    }
                    else
                    {
                        Console.WriteLine("$\t{i}: odd");
                    }
                }




            }


        }
    }
}
