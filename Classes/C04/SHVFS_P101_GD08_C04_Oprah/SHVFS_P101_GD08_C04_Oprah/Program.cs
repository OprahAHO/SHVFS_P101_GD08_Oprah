using System;
using System.Xml.Schema;

namespace SHVFS_Oprah
{
    public class program
    {
        public static void Main(string[] args)
        {
            /*var arithmeticOperatorMultiply = 5;
            //shortcuts, shorter ways of writing code the
            arithmeticOperatorMultiply *= 10;
           //arithmeticOperatorMultiply = arithmeticOperatorMultiply * 10
            Console.WriteLine(arithmeticOperatorMultiply);
            Console.ReadLine();
            first we assign a value to our variable, and declanre one if it needs to be declared
            Then there is an evaluation/check*/
            /*  Console.WriteLine("this is BERFOR our FOR LOOP!");
              for (var i = 0; i < 10; i++)
              {
                  Console.WriteLine("this is THE FIRST LINE in our FOR LOOP!");
                  Console.WriteLine($"the value of i is:{i}");
              }
              Console.WriteLine("this is AFTER our FOR LOOP!");
              Console.ReadLine();*/
            //while loop 
            /*var input = "";
            //while (true)
            while (input != "Quit")
            {
                Console.Clear();
                Console.WriteLine($"Enter \"Quit\" to win the game!");
                input = Console.ReadLine();
            }
            Console.WriteLine("CONGRATS! YOU WON!");
            Console.ReadLine();
            //very similar to while BUT
            //it is not TESTED/EVALUATED until the loop is run ONCE*/
            /*int i;
            Console.WriteLine("Enter 1 for options\n" +
                              "      2 to quit\n" +
                              "      3 to start game");
            do
            {
                Console.WriteLine("please make a selection! HAHAHA!");
                i = Convert.ToInt32(Console.ReadLine());
            } while (i < 1 || i > 3);
            Console.WriteLine("Excellent ch01c3!");
            Console.ReadLine();*/
            /*for (var i = 0; i < 7; i++)
            {
                for(var j = 0; j < 10; j++)
                {
                    Console.WriteLine($"i is: {i}, and j is: {j}");  
                }
            }
            Console.ReadLine();*/
            //arrays start at index ZERO
            //arrays hold STUFF
            //this array holds ints!
            /*var scores = new int[5];
            scores[0] = 7;
            scores[1] = 24;
            scores[2] = 2;
            scores[3] = 333333;
            scores[4] = 1;
            //this is bad
            //it USER MAGIC NUMBERS/HARDCODER/INFLEXIBLE?DANGEROUS eg."5"
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"the length of scores is: {scores.Length} | The index is: {1} | The value is: {scores[i]}");

            }
            Console.ReadLine();*/
            var scores = new int[5] { 55, 3, 24, 29, 33 };
            //var scores = new int[] { 55, 3, 24, 29, 33 };
            //var scores = new[] { 55, 3, 24, 29, 33 };
            for(var i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"the length of scores is: {scores.Length} | The index is: {1} | The value is: {scores[i]}");
            }
            Console.ReadLine();
            //age coculater, number guessing game, Quit 
        }
    }
}

