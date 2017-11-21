using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit( Figure figure) //для фигуры
        {
            foreach(var p in pList)
            {
                if (figure.IsHit(p)) //это вызывает Ф1
                  { return true; }
            }
            return false;
        }

        private bool IsHit(Point point)//для точки //ф1
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                { return true; }
            }
            return false;
        }
    }

}
