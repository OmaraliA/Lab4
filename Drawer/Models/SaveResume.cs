using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Modles
{
    class SaveResume:Drawer
    {
        public static void Save()
        {
            Game.wall.Save();
            Game.snake.Save();
            Game.food.Save();
        } //сохранение

        public static void Resume()
        {
            Game.wall.Resume();
            Game.snake.Resume();
            Game.food.Resume();
        } // продолжение
    }
}
