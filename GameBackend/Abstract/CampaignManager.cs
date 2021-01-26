using GameBackend.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Abstract
{
    class CampaignManager
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + "Kampanya İptal edildi");
        }

        public void Set(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + "İndirim uygulandı!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("İndirim içeriği değiştirildi");
        }
    }
}
