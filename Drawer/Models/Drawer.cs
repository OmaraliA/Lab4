using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Modles
{
    [Serializable]
    class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>();

        public void Draw()
        {
            Console.ForegroundColor = color;

            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
        
        public Drawer()
        {

        }
        
        public void Save()
        {
            string filename = "";

            switch (sign)
            {
                case '#':
                    filename = "wall.dat";
                    break;
                case '*':
                    filename = "snake.dat";
                    break;
                case '$':
                    filename = "food.dat";
                    break;
            }

            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter wr = new BinaryFormatter();
            wr.Serialize(fs, this);

            fs.Close();
        }
        public void Resume()
        {
            string fileName = "";

            switch (sign)
            {
                case '#':
                    fileName = "wall.dat";
                    break;
                case '$':
                    fileName = "food.dat";
                    break;
                case '*':
                    fileName = "snake.dat";
                    break;
            }

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter xs = new BinaryFormatter();
            
            switch (sign)
            {
                case '#':
                    Game.wall.body.Clear();
                    Game.wall = xs.Deserialize(fs) as Wall;
                    break;
                case '$':
                    Game.food.body.Clear();
                    Game.food = xs.Deserialize(fs) as Food;
                    break;
                case '*':
                    Game.snake.body.Clear();
                    Game.snake = xs.Deserialize(fs) as Snake;
                    break;
            }

            fs.Close();


        }



    }
}
