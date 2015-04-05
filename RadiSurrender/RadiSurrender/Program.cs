using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;

namespace RadiSurrender
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.OnUpdate += Game_OnUpdate;
        }

        static void Game_OnUpdate(EventArgs args)
        {
            Game.Say("/ff");
        }
    }
}