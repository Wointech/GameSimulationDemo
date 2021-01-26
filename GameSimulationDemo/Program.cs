using System;
using System.Collections.Generic;

namespace GameSimulationDemo
{
    class Program
    {
        static void Main(string[] args) 
        {
            Player player1 = new Player { Id = 1, FirstName = "Ömer", LastName = "Yıldırım", DateOfBirth = new DateTime(1996,01,11), TcNo = "125454578",IsTheInformationcorrect = false};
            Player player2 = new Player { Id = 2, FirstName = "Murat", LastName = "Yıldırım", DateOfBirth = new DateTime(1994, 01, 15), TcNo = "4554884121548" ,IsTheInformationcorrect = true };
            Player player3 = new Player { Id = 3, FirstName = "Fatih", LastName = "Yıldırım", DateOfBirth = new DateTime(1997, 01, 02), TcNo = "91515132121" ,IsTheInformationcorrect = true };

            Game game1 = new Game { Id = 1 , GameName = "Euro Truck Simulator 2"};
            Game game2 = new Game { Id = 2, GameName = "Sniper Elite 4" };
            Game game3 = new Game { Id = 3, GameName = "Lord of the rings conquest" };
            Game game4 = new Game { Id = 4, GameName = "Pes 2020" };

            Campaign campaign1 = new Campaign {Id = 1 , CampaignName = "Fifty Fifty", CampaignDetail = "Yüzde 50 indirim uygulanacak"};
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "Black Friday", CampaignDetail = "Tüm oyunlarda yüzde 70 indirim uygulanacak" };

            List<Player> players = new List<Player> { player1,player2, player3};

            PlayerManager playerManager1 = new PlayerManager();
            playerManager1.Add(player1);


            SellService sellService = new SellService();
            sellService.Buy(player1,campaign1,game4);

            PlayerManager playerManager = new PlayerManager();
            playerManager.GetList(players);

        }
    }
}
