﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator( int mapWidth, int mapHeight, char sym)
        {
            this.mapHeight = mapHeight; // те чно относятся к переменным класса указывают через this
            this.mapWidth = mapWidth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(3, mapWidth - 2);
            int y = random.Next(3, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
