using System;

namespace Beecrowd
{
    public class Extremamente_Basico
    {
        public Extremamente_Basico()
        {
            int x, a, b = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            x = a + b;

            Console.WriteLine("X = {0}", x);
        }
    }
}