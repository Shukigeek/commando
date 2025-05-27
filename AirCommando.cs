using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string codeName, string status) : base(name, codeName, status)
        {
        }

        public void Parachuting()
        {
            Status = "parachuting";
            Console.WriteLine("the commandot is parachuting");
        }

        public override void Attacking()
        {
            Status = "attacking";
            Console.WriteLine("air trooper is attecking from the air");
        }


    }
}
