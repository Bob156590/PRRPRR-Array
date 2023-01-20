using System;

namespace Uppgift_5._1
{
    class program
    {
        static void Main(string[] args)
        {
            string svar2;
            string[] frågor = {"Vad är 2*15?", "vad är huvudstaden av Tyskland?", "Vliken är bättre TF2 eller TFT?", "vilken tal är störe 5 eller 6?" };
            string[] svar = { "30", "Berlin".ToLower(), "TF2".ToLower(), "6"};
            Console.WriteLine("Välj en nummer mellan 1-4 för att få ett fråga.");
            int val = int.Parse(Console.ReadLine());
            switch (val)
            {
                case 1:
                    Console.WriteLine(frågor[0]);
                    svar2 = Console.ReadLine();
                    if (svar2 == svar[val-1])
                    {
                        Console.WriteLine("Rätt");
                    }
                    else
                    {
                        Console.WriteLine("fel");
                    }
                    break;
                case 2:
                    Console.WriteLine(frågor[1]);
                    svar2 = Console.ReadLine();
                    if (svar2 == svar[val-1])
                    {
                        Console.WriteLine("Rätt");
                    }
                    else
                    {
                        Console.WriteLine("fel");
                    }
                    break;
                case 3:
                    Console.WriteLine(frågor[2]);
                    svar2 = Console.ReadLine();
                    if (svar2 == svar[val-1])
                    {
                        Console.WriteLine("Rätt");
                    }
                    else
                    {
                        Console.WriteLine("fel");
                    }
                    break;
                case 4:
                    Console.WriteLine(frågor[3]);
                    svar2 = Console.ReadLine();
                    if (svar2 == svar[val])
                    {
                        Console.WriteLine("Rätt");
                    }
                    else
                    {
                        Console.WriteLine("fel");
                    }
                    break;
                default:
                    Console.WriteLine("Du kan bara skriva 1-4");
                    break;
            }
        }
    }
}