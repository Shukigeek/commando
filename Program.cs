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
            Game game = new Game();
            game.Start();

            if (args.Length == 0)
            {
                Console.WriteLine("You must pass the API key as a command - line argument.");
                return;
            }
            string apiKey = args[0]; // Read the first argument (your API key)
                                     // use the key as a part of the httpClient
        }

    }
}
