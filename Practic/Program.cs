using System;
namespace Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameStart();

            Console.WriteLine("\t\t\tРЫБОК БОЛЬШЕ НЕТ, ВЫ ПРОИГРАЛИ");
            Console.ReadLine();
        }
    }
}
