using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class PlayerManager : IPlayerManager
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player))
            {
                Console.WriteLine("Kayıt Başarılı");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız");
            }
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt Silindi");
        }
    }
}
