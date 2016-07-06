using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TESTER.Game_States;

namespace TESTER {
    class Program {
        static void Main(string[] args) {
            MainMenuState menu = new MainMenuState();

            GameState state = menu.Display();

            Console.WriteLine();

            //Console.ReadKey();
        }
    }
}
