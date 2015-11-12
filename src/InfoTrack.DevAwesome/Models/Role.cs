using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrack.DevAwesome.Models
{
    public class Role
    {
        [Column("RoleId")]
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<LoginRole> LoginRoles { get; set; }

        public ICollection<RetailerRole> RetailerRoles { get; set; }

        public ICollection<ClientRole> ClientRoles { get; set; }
    }
}
