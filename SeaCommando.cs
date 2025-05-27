using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName, string status) : base(name, codeName, status)
        {
        }

        public void Dive()
        {
            Status = "diving";
            Console.WriteLine("the commandar is diving");
        }

        public override void Attacking()
        {
            Status = "attacking";
            Console.WriteLine("navy seal is attecking from the sea");
        }
    }
}
