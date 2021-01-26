using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo
{
    public class PlayerManager : IPlayerManager
    {
        public void Add(Player player)
        {
            if (player.IsTheInformationcorrect)
            {
                Console.WriteLine(player.FirstName + " isimli oyuncu eklendi");
            }
            else
            {
                Console.WriteLine("Bilgilerinizi kontrol ediniz..");
            }
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " isimli oyuncu silindi");
        }

        public void GetList(List<Player> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine(player.FirstName + " " + player.LastName );
            }
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + "isimli oyuncu güncellendi");
        }
    }
}
