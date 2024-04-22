using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager_3ITB
{
    internal interface IGameState
    {
        void Enter(); // Metoda zavolaná při vstupu do fce
        void Exit(); // Metoda zavolaná při výstupu z fce
        void Update(); // Metoda pro aktualizaci
        void Render(); // Metoda pro vykreslení
    }
}
