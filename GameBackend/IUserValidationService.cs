using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IUserValidationService
    {
        bool Validate(Player player);
    }
}
