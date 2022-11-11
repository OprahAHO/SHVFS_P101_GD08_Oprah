using System;
namespace QUIZ
{

    class QUIZ
    {
        public static void Main()
        {
            int i;
            string name;
            string[]applename = {"Oprah","Naomi","Cloud","Johnny" };
            Random random = new Random();
            int randomnumber=random.Next(0,3);


            Console.WriteLine("Welcome to GUESS GAME!! Please typ U name!!!");
            string username = Console.ReadLine();
            Console.Clear();

           
            for (i=1; ; i++)
            {
                Console.WriteLine($"Hi~ {username}. We have 4 apples. Oprah, Naomi, Cloud, Johnny. And just ONE is best. SO GUESS which ONE");
                name = Console.ReadLine();

                if (name != applename[randomnumber])
                {
                   
                    Console.WriteLine("You are wrong! Try again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (name == applename[randomnumber]) break;
            }
            Console.WriteLine($"You are right! And you Victory after {i} attempts！ ");
            Console.WriteLine("Bye!!");

        }
        

    }
}
    

