using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager_3ITB
{
    internal class Game
    {
        // Třída, která to celé spojuje. Základní kámen celé hry.
        private GameStateManager gameStateManager;

        public Game()
        {
            gameStateManager = new GameStateManager();
            gameStateManager.ChangeState(new MainMenuState(gameStateManager));
        }

        public void Run()
        {
            while (true)
            {
                gameStateManager.Update();
                gameStateManager.Render();
            }
        }
    }
}
