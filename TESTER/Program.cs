using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TESTER.Game_States;

namespace TESTER {
    class Program {
        static void Main(string[] args) {
            InitialiseGameProperties();

            MainMenuState menu = new MainMenuState();
            GameState state = menu.Display();

            state.Display();

            //Console.ReadKey();
        }

        static void InitialiseGameProperties() {
            Console.BufferHeight = Console.WindowHeight = 50;
            Console.BufferWidth = Console.WindowWidth = 107;
        }
    }
}
