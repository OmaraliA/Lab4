using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Modles
{
    class EndGame
    {
        public static void lastKey()
        {
            ConsoleKeyInfo lastKey = Console.ReadKey();

            switch (lastKey.Key) // выбор между выходом и новой игрой 
            {
                case ConsoleKey.Escape:
                    Game.inGame = false;
                    Console.Clear();
                    break;
                case ConsoleKey.Y:
                   // Game.sCore = 0;
                    Console.Clear();
                    Program.Main();
                    break;
                default:
                    break;
            }
        } // ласт баттн
        public static void endGame() // конец игры
        {
            Game.inGame = false;
            Console.Clear();
            Console.SetCursorPosition(25, 10);
            Console.WriteLine("GAME OVER");

            Console.SetCursorPosition(10, 11);
            Console.WriteLine("Press Y to play again, ESC to quit");
            lastKey();
        }
    }
}
//ass