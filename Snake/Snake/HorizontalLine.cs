﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{ 
    class HorizontalLine : Figure
    {
        //горизонтальная линия это набор точек
 
        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<Point>();
            
            for(int x = xLeft; x<=xReight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //foreach (Point p in pList)
            //{
            //    p.Draw();
            //}
            base.Draw();

            Console.ForegroundColor = ConsoleColor.White; 
        }

    }
}
