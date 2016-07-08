using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TESTER.Game_States {
    class PlayState : GameState {
        char[,] level = new char[Console.WindowHeight, Console.WindowWidth];
        int x = 0, y = 0;

        public override GameState Display() {
            while (true) {
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo input = Console.ReadKey(true);

                    while (Console.KeyAvailable) Console.ReadKey(true);

                    if (input.Key == ConsoleKey.Enter) {
                        return new MainMenuState();
                    }
                    if (input.Key == ConsoleKey.UpArrow) {
                        y--;
                    }
                    if (input.Key == ConsoleKey.DownArrow) {
                        y++;
                    }
                    if (input.Key == ConsoleKey.LeftArrow) {
                        x--;
                    }
                    if (input.Key == ConsoleKey.RightArrow) {
                        x++;
                    }
                }

                DisplayLevel();

                Thread.Sleep(1000 / 30);
            }
        }

        private void DisplayLevel() {
            Console.Clear();

            level[y, x] = 'X';

            for (int i = 0; i < 50; i++) {
                for (int j = 0; j < 60; j++) {
                    Console.Write(level[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
