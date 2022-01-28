using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library

{
    public class MallarDuck : Duck, IQuackable, IFlyable
    {
        public override string display()
        {
            return "display " + this.GetType();
        }
        public string Quack()
        {
            return "Quack" + " " + this.GetType();
        }
        public string Fly()
        {
            return "Fly" + " " + this.GetType();
        }
    }
}