using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager_3ITB
{
    internal class MainMenuState : IGameState
    {
        private GameStateManager manager;

        public MainMenuState(GameStateManager gameStateManager)
        {
            manager = gameStateManager;
        }

        public void Enter()
        {
            // Pokud bych chtěl spojit do menu více komponent, klidně bych si je zde mohl zavolat. Něco jako OnLoad();
        }

        public void Exit()
        {
            // Klidně by tu mohl být clear konzole. 
        }

        public void Update()
        {
            // Logika menu.
            string input = Console.ReadLine();
            if (input == "1")
            {
                manager.ChangeState(new PlayingState(manager));
            }
            else if (input == "3")
            {
                Environment.Exit(0);
            }
        }

        public void Render()
        {
            Console.Clear();
            Console.WriteLine("Vítejte v hře Hádej číslo!");
            Console.WriteLine("1. Hrát hru");
            Console.WriteLine("2. Pravidla");
            Console.WriteLine("3. Konec");
            Console.Write("\nVolba: ");
        }
    }
}
