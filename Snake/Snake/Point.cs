using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        //данные
        public int x;
        public int y;
        public char sym;

        //конструктор
        public Point()
        {

        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        //метод
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        } 
    }
}
