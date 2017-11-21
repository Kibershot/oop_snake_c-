using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake ( Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First(); //Возвращает первый элемент списка
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear(); //затираем последнюю точку хвоста и рисуем новую голову
            head.Draw();
        }
        public Point GetNextPoint() // дай мне следующую точку
        {
            Point head = pList.Last(); // текущая позиция головы
            Point nextPoint = new Point(head); // новая точка копия предыдущего положения головы
            nextPoint.Move(1, direction); // сдвигаем по направлению дирекшен
            return nextPoint;
        }
    }
}
