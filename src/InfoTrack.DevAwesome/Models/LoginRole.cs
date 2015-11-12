using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrack.DevAwesome.Models
{
    public class LoginRole
    {
        public Login Login { get; set; }
        public int LoginId { get; set; }

        public Role Role { get; set; }

        public int RoleId { get; set; }
    }
}
