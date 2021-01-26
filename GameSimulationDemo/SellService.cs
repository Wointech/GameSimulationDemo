using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo
{
    class SellService : ISellService
    {
        public void Buy(Player player, Campaign campaign, Game game)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " " +  game.GameName + " oyununu " 
                + campaign.CampaignName + " kampanyası dahilinde satın aldınız. Teşekkür ederiz");
        }
    }
}
