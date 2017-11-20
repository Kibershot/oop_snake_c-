using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(1, 10, 0, '+');
            verticalline vertical = new verticalline(1, 10, 0, '@');
            HorizontalLine line2 = new HorizontalLine(1, 10, 11, '+');
            verticalline vertical2  = new verticalline(1, 10, 11, '@');
            line.Drow();
            vertical.Drow();
            line2.Drow();
            vertical2.Drow();

            Console.ReadLine();
        }

       
    }
}
