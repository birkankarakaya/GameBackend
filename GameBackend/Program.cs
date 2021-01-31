using System;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(new Player { FirstName = "Birkan", BirthYear = 2000, LastName = "Karakaya" });

        }
    }
}