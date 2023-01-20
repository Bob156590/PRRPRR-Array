using System;

namespace Uppgift_5._5
{
    class program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string svar2 = "";
            string[] svar = { "It is certain", "As I see it, yes", "Reply hazy, try again", "Don't count on it", "It is decidedly so", "Most likely",
                "Ask again later", "My reply is no", "Better not tell you now", "Very doubtful"};
            while (svar2 != "a")
            {
                Console.WriteLine("Write how many question u want and the Magic 8 ball will give u the answer\nAnd once your done u can write a simple 'a' to leave.");
                svar2 = Console.ReadLine();
                Console.WriteLine($"The Magic 8-ball: {svar[random.Next(svar.Length)]}");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
