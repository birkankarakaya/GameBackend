using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IPlayerManager
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
