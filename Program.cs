using System;

namespace Uppgift_5._1
{
    class program
    {
        static void Main(string[] args)
        {
            String[] text = { "Jag gillar *Potatos*", "jagg är siiiii", "katchup är bra"};

            foreach (String s in text) 
            { 
                Console.WriteLine(s+"\n");
            }
        }
    }
}