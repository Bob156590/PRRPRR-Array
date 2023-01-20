using System;

namespace Uppgift_5._1
{
    class program
    {
        static void Main(string[] args)
        {
            string[] namn = { "Jokob", "Elliot", "Johana", "Rongresturant", "Abdi" };

            Array.Sort(namn);

            Console.WriteLine(namn[0]);
        }
    }
}