using System;
using System.Collections.Generic;

namespace Practic
{
    class Aquarium
    {
        Display display;
        public List<Fish> fishes;
        public Food food;
        readonly int _maxFishes = 6;
        public Aquarium(int width, int height, char border)
        {
            fishes = new List<Fish>();
            food = new Food('+', 10);
            display = new Display(width, height, border,this);
        }
        public void Show()
        {
            display.Show();
            GetInfo();
        }
        public void GetInfo()
        {
            foreach (Fish f in fishes)
                Console.WriteLine(f.ShowInfo());
        }

        public void Add(Fish fish)
        {
            if (fishes.Count <= _maxFishes)
            {
                fishes.Add(fish);
            }
        }
        public void DeleteFish(Fish fish)
        {
            fishes.Remove(fish);
        }
    }
}
