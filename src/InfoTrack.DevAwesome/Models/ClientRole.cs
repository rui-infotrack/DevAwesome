using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrack.DevAwesome.Models
{
    public class ClientRole
    {
        public Client Client { get; set; }
        public int ClientId { get; set; }

        public Role Role { get; set; }

        public int RoleId { get; set; }
    }
}
