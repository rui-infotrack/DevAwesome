using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrack.DevAwesome.Models
{
    public class RetailerRole
    {
        public Retailer Retailer { get; set; }
        public int RetailerId { get; set; }

        public Role Role { get; set; }

        public int RoleId { get; set; }
    }
}
