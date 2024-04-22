using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager_3ITB
{
    internal class GameStateManager
    {
        // Třída GameStateManager spravuje stavy hry. Má metody pro změnu stavu a všechno spojuje přes currentState.
        private IGameState currentState;

        public void ChangeState(IGameState newState)
        {
            // Ukončí starý stav
            currentState?.Exit();
            currentState = newState;
            // Inicializuje nový stav
            currentState.Enter();
        }

        public void Update()
        {
            currentState.Update();
        }

        public void Render()
        {
            currentState.Render();
        }
    }
}
