using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DecoyDuck : Duck
    {
        public override string display()
        {
            return "display" + " " + this.GetType();
        }
    }
}  

