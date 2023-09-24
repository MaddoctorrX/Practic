using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic
{
    class Position
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Position(int x,int y)
        {
            X = x;
            Y = y;
        }
    }
    class Food
    {
        public List<Food> foodList;
        private char _symbolFood;
        private int foodCount;
        public Position position {  get; set; }

        public Food(char symbolFood,int foodCount) : this(symbolFood)
        {
            foodList = new List<Food>();
            this.foodCount = foodCount;
            for (int i = 0; i < foodCount; i++)
            {
                foodList.Add(new Food(symbolFood));
            }
        }

        public Food(char symbolFood)
        {
            _symbolFood = symbolFood;
        }

        public int GetCountFood()
        {
            return foodList.Count;
        }

        public char GetSymbolFood()
        {
            return _symbolFood;
        }
    }
}
