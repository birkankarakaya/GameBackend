using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Abstract
{
    class PlayerManager 
    {
        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu Silindi! Gidişinizi görmek bizi üzüyor...");
        }

        public void Set(Player player)
        {
            Console.WriteLine(player.Nickname + "Kullanıcı Başarıyla Oluşturuldu! İyi Oyunlar");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kullanıcı Bilgileri Başarıyla Güncellendi!");
        }
    }
}
