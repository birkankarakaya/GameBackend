using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.BirthYear == 2000 && player.FirstName == "Birkan" && player.LastName == "Karakaya")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
