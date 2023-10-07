using System;

namespace Beecrowd
{
    public class AreaDoCirculo
    {
        public AreaDoCirculo()
        {
            double raio = Convert.ToDouble(Console.ReadLine());
            double n = 3.14159;
            double area = n * Convert.ToDouble(Math.Pow(raio, 2));
            
            
            Console.WriteLine("A={0:F4}", area);
        }
    }
}
