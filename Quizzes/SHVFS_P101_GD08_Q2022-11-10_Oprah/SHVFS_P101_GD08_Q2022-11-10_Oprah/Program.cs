using System;
namespace QUIZ
{

    class QUIZ
    {
        public static void Main()
        {
            int xuanzeshu = 1, lingshigong;
            Console.WriteLine("welcome! Please input a word to GUESS Please!");
            xuanzeshu = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int x = r.Next(100);
            lingshigong = 0;
            {
                while (lingshigong != x)
                {
                    lingshigong = Convert.ToInt32(Console.ReadLine());
                    if (lingshigong < x)
                    {
                        Console.WriteLine("NO change and try again.");
                    }

                }
            }
            Console.WriteLine("YES! you are right!! the word is 'word'");
        }
    }
}
    

