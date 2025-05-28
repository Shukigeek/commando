using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _27_05
{
    internal class Game
    {
        CommandoFactory commando = new CommandoFactory();
        WeaponFactory weapon = new WeaponFactory();
        EnemyFactory enemy = new EnemyFactory();
        FctoryKnife knife = new FctoryKnife();
        FctoryStone stone = new FctoryStone();

        string[] names = { 
            "shlom", 
            "ariel", 
            "kedem",
            "moshe",
            "nachman",
            "modi",
            "ahral",
            "noam",
            "gil",
            "dor",
            "Yoav",
            "Eitan",
            "Omer",
            "Noam",
            "Daniel",
            "Yonatan",
            "Roy",
            "Liam",
            "Tomer",
            "Ariel",
            "Noa",
            "Tamar",
            "Maya",
            "Yael",
            "Shira",
            "Roni",
            "Ayala",
            "Avigail",
            "Lian",
            "Hadas"
        };
        string[] enemyNames  = {
            "Ahmed",
            "Omar",
            "Youssef",
            "Ali",
            "Hassan",
            "Khaled",
            "Tariq",
            "Fadi",
            "Samir",
            "Nader"
        };
        public void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                commando.CreatCommando($"{names[i]}", $"{i+1}", "");
                commando.CreatCommando($"{names[i+10]}", $"{i+10}", "air");
                commando.CreatCommando($"{names[i+20]}", $"{i+20}", "sea");
                enemy.CreatEnemy($"{enemyNames[i]}", "alive");
                weapon.CreatWeapon("AK-47");
                weapon.CreatWeapon("M16");
                knife.CreatKnife("Fairbairn-Sykes", 280, "silver", "stainlees steel", "Wilkinson Sword");
                stone.CreatStone($"stone {i + 1}", 8000, "black");

            }
            //commando.GetCommandors();
        }
    }
}
