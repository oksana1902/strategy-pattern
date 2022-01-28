using System;
using Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            MallarDuck duck1 = new MallarDuck();
            RedheadDuck duck2 = new RedheadDuck();
            RubberDuck duck3 = new RubberDuck();
            DecoyDuck duck4 = new DecoyDuck();

            Duck[] mas = new Duck[] { duck1, duck2, duck3, duck4 };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i].display());
                Console.WriteLine(mas[i].swim());
                if (mas[i] is IFlyable)
                {
                    Console.WriteLine((mas[i] as IFlyable).Fly());
                }
                if (mas[i] is IQuackable)
                {
                    Console.WriteLine((mas[i] as IQuackable).Quack());
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
