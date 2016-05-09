using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Modles
{
    [Serializable]
    class Snake : Drawer
    {

        public Snake()
        {
            color = ConsoleColor.Yellow;
            sign = '*';
            
         }

        public void Move(int dx, int dy) // движение змейки
        {          

            for (int i = body.Count - 1; i > 0; i--) //хвост змейки следует за головой
            {               
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;

            }

            //движение головы
            body[0].x = body[0].x + dx; 
            body[0].y = body[0].y + dy;

            for(int i = body.Count - 1; i > 0; i--)
            {                
                if (body[0].x == body[i].x && body[0].y == body[i].y)//столкновения головы змейки с хвостом - это конец игры
                {
                    EndGame.endGame(); // функция конца игры
                }
            }

            for(int i = 0; i < Game.wall.body.Count; i++)
            {
                if (body[0].x == Game.wall.body[i].x && body[0].y == Game.wall.body[i].y) EndGame.endGame();
            }

            if (body[0].y > 28) { body[0].y = 4; }   else { if (body[0].y < 4) body[0].y = 29; } // через стены топ и боттом
            if (body[0].x > 59) { body[0].x = 0; } else { if (body[0].x < 0) body[0].x = 58; } // через стены слева и с справа
                           

            if (body[0].x == Game.food.body[0].x && body[0].y == Game.food.body[0].y) // когда координаты головы змеи совпадает с коорд. еды 
            {
                
               
                Game.snake.body.Add(new Point { x = Game.snake.body[0].x, y = Game.snake.body[0].y }); // появление нового хвоста
                
                Game.NewFood();
                if (body.Count - 1 == 3) Levels.LoadLevel(++Game.level);

            }

            
            

        }          
           

           
        
        

      
       

    }
    
}
