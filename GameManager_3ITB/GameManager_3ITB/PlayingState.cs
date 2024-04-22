using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager_3ITB
{
    internal class PlayingState : IGameState
    {
        private GameStateManager manager;
        private int targetNumber;
        private Random random = new Random();

        public PlayingState(GameStateManager gameStateManager)
        {
            manager = gameStateManager;
        }

        public void Enter()
        {
            targetNumber = random.Next(1, 101); // Hádané číslo.
        }

        public void Exit()
        {
            // Tady bych mohl psát localstorage či nějaká db mechanismus pro ukládání hry.
        }

        public void Update()
        {
            Console.WriteLine("\n--- Hra začíná! ---");
            //Console.WriteLine($"Hádané číslo: {targetNumber}");
            Console.WriteLine("Hádejte číslo mezi 1 a 100.");
            while (true)
            {
                Console.Write("Váš tip: ");
                int guess = int.Parse(Console.ReadLine());
                if (guess < targetNumber)
                {
                    Console.WriteLine("Vaše číslo je nižší.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Vaše číslo je vyšší.");
                }
                else
                {
                    Console.WriteLine("Správně! Uhádli jste číslo.");
                    manager.ChangeState(new MainMenuState(manager));
                    break;
                }
            }
        }

        public void Render()
        {
            // Tady by mohlo být GUI (update func).
        }
    }
}
