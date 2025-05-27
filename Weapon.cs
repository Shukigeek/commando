using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_05
{
    internal class Weapon
    {
        public string Name;
        public string Manufacturer;
        public int NumOfBullets;
        public Weapon(string name, string manuFacturing, int bullets)
        {
            Name = name;
            Manufacturer = manuFacturing;
            NumOfBullets = bullets;
        }
        public void Shoot()
        {
            if (NumOfBullets > 0)
            {
                NumOfBullets--;
                Console.WriteLine($"{Name} fired! Bullets left: {NumOfBullets}");
            }
            else
            {
                Console.WriteLine($"{Name} is out of bullets!");
            }
        }
    }
}
