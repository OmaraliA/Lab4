using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Modles
{
    class Panel 
    {
        
        public static void PanelDraw(int score, int level)
        {
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("_______________________________________________________________________________");
            Console.SetCursorPosition(0, 28);
            Console.WriteLine("_______________________________________________________________________________");

            Console.SetCursorPosition(0, 0);
            Console.Write("SNAKE ") ;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" GOOD LUCK");

            Console.SetCursorPosition(48, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("F1 - save");
            Console.SetCursorPosition(48, 1);
            Console.Write("F2 - resume");




            Console.SetCursorPosition(20, 2);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("LEVEL : " + level + "   SCORE : " + score);
            
            
        }
    }
}
