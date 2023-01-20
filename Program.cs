using System;

namespace Uppgift_5._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());
            int[] tal = new int[antal];
            Console.WriteLine($"Skriv in {antal} hetal");
            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Här är talen du skrev in");
            for (int i = 0; i < tal.Length; i++)
            { 
                Console.WriteLine($"Tal {i+1}: {tal[i]}");
            }
        }
    }
}