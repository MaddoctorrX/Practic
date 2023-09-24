using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practic
{
    class FishManager
    {
        Aquarium aquarium;
        private int Damage;
        public FishManager(Aquarium aquarium)
        {
            this.aquarium = aquarium;
        }

        private void Remove(Fish f)
        {
            aquarium.fishes.Remove(f);
        }

        private void CheckStateFish()
        {
            foreach (Fish f in aquarium.fishes)
            {
                if (f.IsDead)
                {
                    Remove(f);
                    Console.WriteLine($"\nРыбка по Имени {f.Name.ToUpper()}" + 
                        " Померла(Нажмите любую кнопку чтобы продолжить)");
                    Console.ReadKey();
                    return;
                }
            }
        }

        private void SetHealth()
        {
            Random rnd = new Random();
            Damage = rnd.Next(1, 6);
            Thread.Sleep(1);
            foreach (Fish f in aquarium.fishes)
            {
                if (rnd.NextDouble() > 0.7)
                {
                    f.TakeDamage(Damage);
                }
            }
        }

        public void Update()
        {
            Console.Clear();
            SetHealth();
            aquarium.Show();
            CheckStateFish();
        }
    }
}
