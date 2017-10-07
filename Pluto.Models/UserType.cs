using System;
using System.Collections.Generic;
using System.Text;

namespace Pluto.Models
{
    [Flags]
    public enum UserType
    {
        
        Admin = 1,

        Support = 2,
        Business=4
    }
}
