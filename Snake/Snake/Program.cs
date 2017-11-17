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
            
            List<Point> pList = new List<Point>();
            pList.Add(new Point(3, 6, '*'));
            pList.Add(new Point(8, 13, '@'));
            pList.Add(new Point(4, 4, '%'));
            pList.Add(new Point(3, 7, '$'));
            pList.Add(new Point(6, 2, '`'));
            pList.Add(new Point(2, 3, '&'));
            pList.Add(new Point(7, 9, '^'));

            foreach(Point p in pList)
            {
                p.Draw();
            }


            Console.ReadLine();
        }

       
    }
}
