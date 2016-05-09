using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Modles
{
    class Levels
    {
               

        public static void LoadLevel(int i)
        {
            
            

            FileStream fs = new FileStream(string.Format(@"C:\Users\андрей\Documents\Visual Studio 2015\Projects\Lab4_TimerSnake\Drawer\Levels\Level{0}.txt", i), FileMode.Open, FileAccess.Read);
            StreamReader rd = new StreamReader(fs);

            string line;
            int row = -1;
            int colomn = 0;

            while ((line = rd.ReadLine()) != null)
            {
                row++;
                colomn = -1;
                foreach( char cc in line)
                {
                    colomn++;
                    if(cc == '#')
                    {
                        Game.wall.body.Add(new Point { x = colomn, y = row });
                        
                    }

                }
            }
            Game.InitRandom();
            rd.Close();
            fs.Close();

        } //Загрузка уровня 
    } 
}
