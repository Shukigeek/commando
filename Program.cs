using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando = new Commando("shuki","gimal","hide");
            AirCommando airCom = new AirCommando("dan", "alfa", "walk");
            SeaCommando seaCom = new SeaCommando("ahron", "zigzag", "diving");

            Commando[] commandos = new Commando[] { commando,airCom, seaCom };
            foreach (Commando com in commandos) 
            {
                com.Attacking();
            }
        }
        
    }
}
