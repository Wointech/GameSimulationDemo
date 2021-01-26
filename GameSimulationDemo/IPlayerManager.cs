using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo
{
    interface IPlayerManager
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
        void GetList(List<Player> players);

    }
}
