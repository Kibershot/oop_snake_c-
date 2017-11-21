using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 25);


            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            //рамка
            HorizontalLine line = new HorizontalLine(0, 78, 0, '+');
            VerticalLine vertical = new VerticalLine(0, 24, 78, '+');
            HorizontalLine line2 = new HorizontalLine(0, 78, 24, '+');
            VerticalLine vertical2  = new VerticalLine(0, 24, 0, '+');
            line.Drow();
            vertical.Drow();
            line2.Drow();
            vertical2.Drow();

            

            //Zmejka
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            //snake.Move();
            //Thread.Sleep(300);
            //snake.Move();
            //Thread.Sleep(300);

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood(); // вернет точку
            food.Draw();//выводим ее на экран

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }




            Console.ReadLine();
        }

       
    }
}
