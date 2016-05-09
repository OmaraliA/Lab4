using Drawer.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drawer
{
    class Program
    {
        public static int TmCount;
        public static string dir = "Right";


        static void MoveTime(object state)// сам таймер(действие)
        {
            TmCount++;
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)// меняем направление
                {
                    case ConsoleKey.UpArrow:
                        dir = "Up";
                        break;
                    case ConsoleKey.DownArrow:
                        dir = "Down";
                        break;
                    case ConsoleKey.LeftArrow:
                        dir = "Left";
                        break;
                    case ConsoleKey.RightArrow:
                        dir = "Right";
                        break;
                    case ConsoleKey.Escape:
                        Game.inGame = false;
                        break;
                    

                }
            }

            switch (dir)// меняем положение
            {
                case "Up":
                    Game.snake.Move(0, -1);
                    break;
                case "Down":
                    Game.snake.Move(0, 1);
                    break;
                case "Left":
                    Game.snake.Move(-1, 0);
                    break;
                case "Right":
                    Game.snake.Move(1, 0);
                    break;

            }
            if (Game.inGame)
                {
                    Game.Redraw();
                }

                else {
                    Console.Clear();
                    Console.SetCursorPosition(35, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game Over!");
                }

            }
        

        public static void Main()
        {

            Console.SetWindowSize(60, 30); // консоль позишн
            Levels.LoadLevel(1);
            Game.inGame = true;
            Game.InitRandom(); // задаем змейке и еде начальные рандомные координаты 
            Timer tm = new Timer(new TimerCallback(MoveTime));// создание таймера
            tm.Change(100, 200);
            Game.wall.Draw();
            while (Game.inGame) // основы движение змейки
            {

            }
            tm.Dispose();
             Console.ReadKey();
            }
        }
    }
