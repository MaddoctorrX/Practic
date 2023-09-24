using System;
using System.Threading;

namespace Practic
{
    class Fish
    {
        public char Symbol { get; }
        public string Name { get; set; }
        public int Health { get; private set; }
        private bool IsHungry { get; }
        public bool IsDead { get; private set; }
        public Fish(string name)
        {
            Symbol = '@';
            Name = name;
            Health = GenerateHP();
            IsHungry = GenerateHungry();
        }

        public void TakeDamage(int count)
        {
            if (Health - count <= 0)
            {
                Health = 0;
                IsDead = true;
            }
            Health -= count;
        }
        private int GenerateHP()
        {
            Random rnd = new Random();
            Thread.Sleep(1);
            return rnd.Next(5, 25);
        }
        private bool GenerateHungry()
        {
            Random rnd = new Random();
            Thread.Sleep(1);
            return rnd.NextDouble() > 0.5;
        }

        private string GetHungry()
        {
            if (IsHungry)
                return "Голодная";

            return "Не голодна";
        }

        public string ShowInfo()
        {
            return $"Name: {Name}(HP:{Health}) Hungry: {GetHungry()}";
        }
    }
}
