using System;
using System.Threading;

namespace Practic
{
    class Game
    {
        Aquarium aquarium;
        FishManager fishManager;
        public void Init()
        {
            aquarium = new Aquarium(40, 15, '*');
            fishManager = new FishManager(aquarium);
            Fish fish = new Fish("fish1");
            Fish fish1 = new Fish("fish2");
            Fish fish2 = new Fish("fish3");
            aquarium.Add(fish);
            aquarium.Add(fish1);
            aquarium.Add(fish2);
        }

        public void GameStart()
        {
            Init();
            Update();
        }

        public void Update()
        {
            while (aquarium.fishes.Count > 0)
            {
                fishManager.Update();
                Thread.Sleep(800);
            }
        }
    }
}
