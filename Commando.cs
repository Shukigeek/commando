using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class Commando
    {
        private string Name;
        private string CodeName { get; set; }
        public string[] Tools = { "hammer", "chisel", "rope", "bag", "water" };
        public string Status;
        public Commando(string name, string codeName, string status)
        {
            this.Name = name;
            this.CodeName = codeName;
            this.Status = status;

        }

        public void Walk()
        {
            Status = "walk";
        }
        public void Hide()
        {
            Status = "hide";
        }
        public virtual void Attacking()
        {
            Status = "attacking";
            Console.WriteLine("commandor is attacking from land");
        }
        public string GetCodeName()
        {
            return CodeName;
        }
        public void SetCodeName(string NewName)
        {
            CodeName = NewName;
        }
        public void SayName(string commanderRank)
        {
            if (commanderRank.ToLower().Equals("general"))
            {
                Console.WriteLine($"the name is: {Name}");
            }
            else if (commanderRank.ToLower().Equals("colonel"))
            {
                Console.WriteLine($"the name is: {CodeName}");
            }
            else
            {
                Console.WriteLine("the name of the oppretive is secrat");
            }
        }
    }
}
