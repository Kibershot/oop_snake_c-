using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        /*public*/ Direction direction; // убрали паблик так как управление с клавишь перенесли в этот же класс

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

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for(int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
                
            }
            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT; // чтобы снейкюдирекшн был доступен в классе нужно дирекшн сделать пабликом
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat( Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            return false;
        }
    }
}
