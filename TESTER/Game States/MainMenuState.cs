using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTER.Game_States {
    public class MainMenuState : GameState{
        private List<string> _menuOptions = new List<string>(){ "New Game", 
                                                                "Tutorial",
                                                                "Settings",
                                                                "  Exit  " };

        private int _gameOption;
        private int GameOption {
            get { return _gameOption; }
            set {
                if (value > _menuOptions.Count - 1)
                    _gameOption = 0;
                else if (value < 0)
                    _gameOption = _menuOptions.Count - 1;
                else
                    _gameOption = value;
            }
        }

        public MainMenuState() {
            //_menuOptions.Insert(1, "Continue");
        }

        public override GameState Display() {
            while (true) {
                DisplayManuOptions();

                while (true) {
                    ConsoleKeyInfo userInput = Console.ReadKey(true);

                    if (userInput.Key == ConsoleKey.DownArrow) {
                        GameOption++;
                        break; 
                    }

                    if (userInput.Key == ConsoleKey.UpArrow) { 
                        GameOption--; 
                        break; 
                    }

                    if (userInput.Key == ConsoleKey.Enter) {
                        if (_menuOptions[GameOption].Trim() == "Exit") {
                            return new ExitState();
                        }

                        return new MainMenuState();
                    }
                }
            }
        }

        void DisplayManuOptions() {
            Console.Clear();

            Console.WriteLine("\t\t\t\t\t  +------------------+");
            Console.WriteLine("\t\t\t\t\t  |  The Mighty RPG  |");
            Console.WriteLine("\t\t\t\t\t  +------------------+");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < _menuOptions.Count; i++) {
                Console.Write("\t\t\t\t\t");

                if (i == GameOption) 
                    Console.Write("-->");

                Console.Write("\t" + _menuOptions[i]);
               
                if (i == GameOption) 
                    Console.Write("     <--");

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
