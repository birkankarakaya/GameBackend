using GameBackend.Abstract;
using GameBackend.Entity;
using System;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Game game = new Game();
            Campaign campaign = new Campaign();

            PlayerManager playerManager = new PlayerManager();
            CampaignManager campaignManager = new CampaignManager();

            player.Id = 1;
            player.TcNo = "12345678911";
            player.FirstName = "Birkan";
            player.Nickname = "deneme123";
            player.EMail = "asdgfgfgh@gmail.com";
            player.Age = "20";
            player.DateofRegistration = System.DateTime.Now;
            playerManager.Set(player);

            campaign.Id = 1;
            campaign.CampaingName = "Hoşgeldin İndirimi";
            campaign.Amount = 50;
            campaignManager.Set(campaign);
        }
    }
}
