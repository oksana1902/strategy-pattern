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
            MallardDuck duck1 = new MallardDuck();
            duck1.PerformFly();
            duck1.PerformQuack();
            RedheadDuck duck2 = new RedheadDuck();
            RubberDuck duck3 = new RubberDuck();
            DecoyDuck duck4 = new DecoyDuck();

            IFlyBehavior flyBehavior = new FlyNoWay();
            IQuackBehavior quackBehavior = new DQuack();

            duck1.SetFlyBehavior(flyBehavior);
            duck3.SetQuackBehavior(quackBehavior);

            Duck[] mas = new Duck[] { duck1, duck2, duck3, duck4 };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i].Display());
                Console.WriteLine(mas[i].Swim());
                Console.WriteLine(mas[i].PerformFly());
                Console.WriteLine(mas[i].PerformQuack());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
