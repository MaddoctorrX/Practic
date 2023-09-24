using System;
using System.Collections.Generic;
using System.Threading;

namespace Practic
{
    class Display
    {
        private int _width;
        private int _height;
        private char _borderSymbol;
        char[,] _body;
        Aquarium aqua;
        int countCharToPrint;
        int countFoodToPrint;
        public Display(int wight, int height, char borderSymbol, Aquarium aqua)
        {
            countCharToPrint = 0;
            this.aqua = aqua;
            _width = wight;
            _height = height;
            _borderSymbol = borderSymbol;
            _body = new char[height, wight];
            SetFoodPosition();
            SetDisplay();
        }

        private void SetDisplay()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    if (i != 0 && i != _height - 1
                        && j > 0 && j < _width - 1)
                    {
                        _body[i, j] = ' ';
                    }
                    else
                    {
                        _body[i, j] = _borderSymbol;
                    }
                }
            }
        }
        private void PrintDisplay()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    Console.Write(_body[i, j]);
                }
                Console.WriteLine();
            }
        }

        private void PrintFishes()
        {
            countCharToPrint = aqua.fishes.Count;
            char symbolToPrint = ' ';
            if (aqua.fishes[0].Symbol != ' ')
                symbolToPrint = aqua.fishes[0].Symbol;

            Random rnd = new Random();

            for (int i = 0; i < countCharToPrint; i++)
            {
                int num1 = rnd.Next(1, _width - 1);
                int num2 = rnd.Next(1, _height - 1);
                _body[num2, num1] = symbolToPrint;
            }
        }
        private void SetFoodPosition()
        {
            countFoodToPrint = aqua.food.GetCountFood();
            char symbolToPrint = ' ';
            if (aqua.food.GetSymbolFood() != ' ')
                symbolToPrint = aqua.food.GetSymbolFood();

            Random rnd = new Random();

            for (int i = 0; i < countFoodToPrint; i++)
            {
                foreach (Food food in aqua.food.foodList)
                {
                    int num1 = rnd.Next(1, _width - 1);
                    int num2 = rnd.Next(1, _height - 1);
                    food.position = new Position(num2,num1);
                }
            }
        }
        public void Show()
        {
            PrintFishes();
            PrintDisplay();
            SetDisplay();
        }
    }
}
