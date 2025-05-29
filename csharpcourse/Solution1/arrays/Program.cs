using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "engin";
            students[1] = "derin";
            students[2] = "salih";

            string[] students2 = new[] { "engin", "derin", "Salih" };

            string[,] regions = new string[,]
            {
                {"istanbul", "izmit", "balıkesir"},
                {"ankara", "konya", "kırıkkale"},
                {"antalya", "adana", "mersin"},
                {"rize", "trabzon", "samsun"},
                {"izmir", "muğla", "manisa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*********************");
            }

            // Aşağıdaki foreach örneğini açmak istersen yorumları kaldırabilirsin
            /*
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.ReadLine();
            */
        }
    }
}
